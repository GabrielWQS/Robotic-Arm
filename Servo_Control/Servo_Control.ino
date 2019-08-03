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
#define SERVO_5_MIN  110 
#define SERVO_5_MAX  535
#define SERVO_6_MIN  110 
#define SERVO_6_MAX  535


// our servo # counter

int position_0 = 0, position_1 = 0, position_2 = 0, position_3 = 0, position_4 = 0, position_5 = 0, position_6 = 0;
double pulselength_0 = 0, pulselength_1 = 0, pulselength_2 = 0, pulselength_3 = 0, pulselength_4 = 0, pulselength_5 = 0, pulselength_6 = 0; 

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
  position_4 = getPosition(cont, myServoString);  
  position_5 = getPosition(cont, myServoString);  
  position_6 = getPosition(cont, myServoString);  
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
        pulselength_4 = map(position_4, 0, 180, SERVO_4_MIN, SERVO_4_MAX);
        pulselength_5 = map(position_5, 0, 180, SERVO_5_MIN, SERVO_5_MAX);
        pulselength_6 = map(position_6, 0, 180, SERVO_6_MIN, SERVO_6_MAX);
        
        //pwm.setPWM(0, 0, pulselength_0);
        //pwm.setPWM(1, 0, pulselength_1);
        //pwm.setPWM(2, 0, pulselength_2);
        //pwm.setPWM(3, 0, pulselength_3);
        //pwm.setPWM(4, 0, pulselength_4);
        //pwm.setPWM(5, 0, pulselength_5);
        //pwm.setPWM(6, 0, pulselength_6);

        Serial.print("Servo 0: "); Serial.print(position_0); Serial.print(" PL: "); Serial.println(pulselength_0);
        Serial.print("Servo 1: "); Serial.print(position_1); Serial.print(" PL: "); Serial.println(pulselength_1);
        Serial.print("Servo 2: "); Serial.print(position_2); Serial.print(" PL: "); Serial.println(pulselength_2);
        Serial.print("Servo 3: "); Serial.print(position_3); Serial.print(" PL: "); Serial.println(pulselength_3);
        Serial.print("Servo 4: "); Serial.print(position_4); Serial.print(" PL: "); Serial.println(pulselength_4);
        Serial.print("Servo 5: "); Serial.print(position_5); Serial.print(" PL: "); Serial.println(pulselength_5);
        Serial.print("Servo 6: "); Serial.print(position_6); Serial.print(" PL: "); Serial.println(pulselength_6);

        
        
        
        
        
        
        

      }
  }
}

/*
[123|456|789|012|]
[10|20|30|40|]
[180|180|180|180|]
*/
