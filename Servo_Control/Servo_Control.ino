#include <Servo.h>
#include <Wire.h>
#include <Adafruit_PWMServoDriver.h> //Necessário instalar adicionar a biblioteca Adafruit PWMServoDriver

Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver(0x41);

// Comprimento Minímo e Máximo do pulso
#define SERVO_0_MIN  110 
#define SERVO_0_MAX  535 
#define SERVO_1_MIN  110 
#define SERVO_1_MAX  535
#define SERVO_2_MIN  110 
#define SERVO_2_MAX  535
#define SERVO_3_MIN  110 
#define SERVO_3_MAX  535
#define SERVO_4_MIN  110 
#define SERVO_4_MAX  535


// our servo # counter

int position_0 = 0, position_1 = 0, position_2 = 0, position_3 = 0;
double pulselength_0 = 0, pulselength_1 = 0, pulselength_2 = 0, pulselength_3 = 0; 

int cont = 0;
bool enable = false, servoStart = false, servoEnd = false;

void setup() 
{
  Serial.begin(9600);
  Serial.println("Robotic Arm by Gabriel Wallace");
  pwm.begin(); 
  pwm.setPWMFreq(60);  // Analog servos run at ~60 Hz updates
}

String readSerialString()
{
  String myString = "";
  String myServoString = "";
  char caracter;
  
  while(Serial.available() > 0) 
  {
    caracter = Serial.read();

    if(caracter == '[')//Se for igual a '[' inicio do comando para os servos
      servoStart = true;
    if(caracter == ']')//Se for igual a ']' final do comando para os servos
      servoEnd = true;
      
    if (caracter != '\n' && servoStart == false)
      myString.concat(caracter);
    if(servoStart == true)//Salva apenas string para os servos
      myServoString.concat(caracter);
      
    delay(10);//buffer
  }
    
  Serial.println("myString: " + myString);
  Serial.println("myServoString: " + myServoString);

  if(servoStart == true && servoEnd == true)
  {
    setNextPosition(myServoString);
  }  

  servoStart = false;
  servoEnd = false;
  
  return myString;
}

void setNextPosition(String myServoString)
{
  cont = 0;
  position_0 = getPosition(cont, myServoString); 
  position_1 = getPosition(cont, myServoString); 
  position_2 = getPosition(cont, myServoString);
  position_3 = getPosition(cont, myServoString);  
}

int getPosition(int i, String v)
{
  String posString = "";
  cont++;
  while(v[cont] != '|')
  {
    posString.concat(v[cont]);
    cont++;
  }

  return posString.toInt();
}

void loop() 
{
    if(Serial.available()>0)
  {
      String input = readSerialString();
      
      if(input == "START")//Se receber 'START' os próximos comandos serão aceitos
      {
        enable = true;
        Serial.println("Enable = true");
      }
        else if(input == "STOP")//Se receber 'STOP' nenhum comando será executado
        {
          enable = false;
          Serial.println("Enable = false");
        }

      if(enable)//
      {
        pulselength_0 = map(position_0, 0, 180, SERVO_0_MIN, SERVO_0_MAX);
        pulselength_1 = map(position_1, 0, 180, SERVO_1_MIN, SERVO_1_MAX);
        pulselength_2 = map(position_2, 0, 180, SERVO_2_MIN, SERVO_2_MAX);
        pulselength_3 = map(position_3, 0, 180, SERVO_3_MIN, SERVO_3_MAX);
        
        //pwm.setPWM(0, 0, pulselength_0);
        //pwm.setPWM(1, 0, pulselength_1);
        //pwm.setPWM(2, 0, pulselength_2);
        //pwm.setPWM(3, 0, pulselength_3);

        Serial.println(position_0);
        Serial.println(position_1);
        Serial.println(position_2);
        Serial.println(position_3);

        Serial.println(pulselength_0);
        Serial.println(pulselength_1);
        Serial.println(pulselength_2);
        Serial.println(pulselength_3);

      }
  }
}
