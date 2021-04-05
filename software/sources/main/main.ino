#include <PID_v1.h>
#include "StringSplitter.h"

#define MotEn   6
#define MotFwd  4
#define MotRev  5
int encoderPin1 = 2;
int encoderPin2 = 3;
long encoderValue = 0;

double kp = 40, ki = 0.1, kd = 0.1;
double input = 0, output = 0, setpoint = 0;
PID myPID(&input, &output, &setpoint, kp, ki, kd, DIRECT);

String inputString = "";
bool stringComplete = false;
unsigned long prevMillis = 0;

void setup() {
  Serial.begin(115200);
  inputString.reserve(200);
  pinMode(MotEn, OUTPUT);
  pinMode(MotFwd, OUTPUT);
  pinMode(MotRev, OUTPUT);
  pinMode(encoderPin1, INPUT_PULLUP);
  pinMode(encoderPin2, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(encoderPin1), updateEncoder, FALLING);
  TCCR1B = TCCR1B & 0b11111000 | 1;
  myPID.SetMode(AUTOMATIC);
  myPID.SetSampleTime(1);
  myPID.SetOutputLimits(-255, 255);
}

void loop() {
  input = encoderValue;
  myPID.Compute();
  pwmOut(output);
  unsigned long currMillis = millis();
  if (currMillis - prevMillis >= 100) {
    prevMillis = currMillis;
    Serial.print(setpoint, 0);
    Serial.print(",");
    Serial.print(input, 0);
    Serial.print(",");
    Serial.print(myPID.GetKp());
    Serial.print(",");
    Serial.print(myPID.GetKi());
    Serial.print(",");
    Serial.println(myPID.GetKd());
  }
  if (stringComplete) {
    setpoint = inputString.toInt();
    inputString = "";
    stringComplete = false;
  }
}

void pwmOut(int out) {
  if (out > 0) {
    analogWrite(MotEn, out);
    forward();
  } else {
    analogWrite(MotEn, abs(out));
    reverse();
  }
}

void updateEncoder() {
  if (digitalRead(encoderPin2) == HIGH) {
    encoderValue++;
  } else {
    encoderValue--;
  }
}

void forward () {
  digitalWrite(MotFwd, HIGH);
  digitalWrite(MotRev, LOW);
}

void reverse () {
  digitalWrite(MotFwd, LOW);
  digitalWrite(MotRev, HIGH);
}

void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    inputString += inChar;
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
