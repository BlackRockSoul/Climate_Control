#include "DHT.h"
#include <Servo.h>
#include <math.h>
#define DHTPIN 2
#define DHT22PIN 4
#define servoPin 9


DHT dht(DHTPIN, DHT11);
DHT dht22(DHT22PIN, DHT22);
Servo servo;

int SetTemp = 23;
float Angle = 180;
static float AngleCh1 = 15;
static float AngleCh2 = 30;
static float AngleCh3 = 60;
int timerRead = 40;
int timer = timerRead - 1;
int razn = 0;
bool closed = false;
static int ServoDelay = 40;


void setup() {
  Serial.begin(9600);
  delay(10);
  servo.attach(9);

  if (servo.read() != 180)
  {
    for (int i = servo.read(); i <= 180; i++)
    {
      servo.write(i);
      delay(ServoDelay);
    }
  }
  dht.begin();
  dht22.begin();
}


void loop() {
  timer++;

  float h = dht.readHumidity();

  float t = dht.readTemperature();

  float h22 = dht22.readHumidity();

  float t22 = dht22.readTemperature();

  float deltaT = (t + t22) / 2;

  float deltaTr = int(round(deltaT));

  float deltaH = (h + h22) / 2;

  if (isnan(h) || isnan(t)) {
    Serial.println("Error");
    return;
  }

  if (Serial.available() < 4)  {

    if (timer == timerRead && closed != true) {

      if (deltaTr > SetTemp)
        razn = int(deltaTr) - int(SetTemp);
      if (razn > 3) razn = 4;
      switch (razn) {
        case int(1): Angle = Angle - AngleCh1; break;
        case int(2): Angle = Angle - AngleCh2; break;
        case int(3): Angle = Angle - AngleCh3; break;
        case int(4): Angle = 0; break;

      }
      if (servo.read() - Angle < 0) Angle = 0;
      razn = 0;
      for (int i = servo.read(); i >= Angle; i--)
      {
        servo.write(i);
        delay(ServoDelay);
      }
      timer = 0;

      if (deltaTr < SetTemp) {
        razn = int(SetTemp) - int(deltaTr);
        if (razn > 3) razn = 4;

        switch (razn) {
          case int(1): Angle = Angle + AngleCh1; break;
          case int(2): Angle = Angle + AngleCh2; break;
          case int(3): Angle = Angle + AngleCh3; break;
          case int(4): Angle = 180; break;
        }
        if (servo.read() - Angle > 180) Angle = 180;
        razn = 0;
        for (int i = servo.read(); i <= Angle; i++)
        {
          servo.write(i);
          delay(ServoDelay);
        }
        timer = 0;
      }

      if (deltaTr == SetTemp) {
        if (Angle != 60)
        {
          Angle = 60;
          for (int i = servo.read(); i <= Angle; i++)
          {
            servo.write(i);
            delay(ServoDelay);
          }
          timer = 0;
        }
      }
    }
  }
  else
  {
    int inByte = Serial.read();
    switch (inByte) {
      case '1': //close the wiiiindooooow!!!!
        {
          if (closed == false) {
            for (int i = servo.read(); i <= 180; i++)
            {
              servo.write(i);
              delay(ServoDelay);
            }
            closed = true;
          }
          else
          {
            for (int i = servo.read(); i >= Angle; i--)
            {
              servo.write(i);
              delay(ServoDelay);
            }
            closed = false;
          }
        } break;

      case '+':
        {
          SetTemp++;
        } break;
      case '-':
        {
          SetTemp--;
        }

    }
  }
  Serial.print("Humidity: ");
  Serial.print(int(deltaH));
  Serial.print("; \t");
  Serial.print("Temperature: ");
  Serial.print(deltaT);
  Serial.print(";");
  Serial.print(t);
  Serial.print(";");
  Serial.print(t22);
  Serial.print("; \t");
  Serial.print("Angle: ");
  Serial.print(int(servo.read()));
  Serial.print(";\t Locked: ");
  if (closed == true) Serial.print("true;"); else Serial.print("false;");
  Serial.print(timer);
  Serial.print(";\t SetTemp: ");
  Serial.print(SetTemp);
  Serial.print(";\t ");
  Serial.print(timerRead);
  Serial.println(";");
  delay(1000);
}
