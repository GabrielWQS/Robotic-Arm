#include <Servo.h>
#include <Wire.h>
#include <Adafruit_PWMServoDriver.h> //Necessário adicionar a biblioteca Adafruit PWMServoDriver

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
uint8_t servo_0 = 0, servo_1 = 1, servo_2 = 2, servo_3 = 3, servo_4 = 4;

int posicao_0 = 322, posicao_1_2 = 322, posicao_3 = 322;

char entrada;

void setup() 
{
  Serial.begin(9600);
  Serial.println("16 channel Servo test!");
  pwm.begin(); 
  pwm.setPWMFreq(60);  // Analog servos run at ~60 Hz updates
  Serial.println("Pressione W ou D para movimentar a Garra");
}

void setServoPulse(uint8_t n, double pulse) 
{
  double pulselength;
  
  pulselength = 1000000;   // 1,000,000 us per second
  pulselength /= 60;   // 60 Hz
  Serial.print(pulselength); Serial.println(" us per period"); 
  pulselength /= 4096;  // 12 bits of resolution
  Serial.print(pulselength); Serial.println(" us per bit"); 
  pulse *= 1000;
  pulse /= pulselength;
  Serial.println(pulse);
  pwm.setPWM(n, 0, pulse);
}

void loop() 
{
    if(Serial.available()>0)
  {
      //    Base
      entrada = Serial.read();
      Serial.print("Tecla pressionada: ");
      Serial.println(entrada);
      
      if(entrada == 'a' && posicao_0 > SERVO_0_MIN)
      {
        pwm.setPWM(servo_0, 0, --posicao_0);
        Serial.println("Servo Base: ");Serial.println(posicao_0);
      }
      if(entrada == 'd' && posicao_0 < SERVO_0_MAX)
      {
        pwm.setPWM(servo_0, 0, ++posicao_0);
        Serial.println("Servo Base: "); Serial.println(posicao_0);
      }
      
      //    Junta Dupla
      if(entrada == 'w' && posicao_1_2 > SERVO_1_MIN)
      {
        pwm.setPWM(servo_1, 0, --posicao_1_2);
        pwm.setPWM(servo_2, 0, --posicao_1_2);
        Serial.println("Servo Junta Dupla: ");Serial.println(posicao_1_2);
      }
      if(entrada == 's' && posicao_1_2 < SERVO_1_MAX)
      {
        pwm.setPWM(servo_1, 0, ++posicao_1_2);
        pwm.setPWM(servo_2, 0, ++posicao_1_2);
        Serial.println("Servo Junta Dupla: ");Serial.println(posicao_1_2);
      }

      //    Junta
      if(entrada == 'q' && posicao_3 > SERVO_3_MIN)
      {
        pwm.setPWM(servo_3, 0, --posicao_3);
        Serial.println("Servo Junta: ");Serial.println(posicao_3);
      }
      if(entrada == 'e' && posicao_3 < SERVO_3_MAX)
      {
        pwm.setPWM(servo_3, 0, ++posicao_3);
        Serial.println("Servo Junta: "); Serial.println(posicao_3);
      }
  }
}
