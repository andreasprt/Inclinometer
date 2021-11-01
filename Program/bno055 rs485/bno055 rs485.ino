#include "I2Cdev.h"
#include "MPU6050_6Axis_MotionApps_V6_12.h"

#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
#include "Wire.h"
#endif
MPU6050 mpu;
#define OUTPUT_READABLE_YAWPITCHROLL

#define INTERRUPT_PIN 2  // use pin 2 on Arduino Uno & most boards
#define LED_PIN 13 // (Arduino is 13, Teensy is 11, Teensy++ is 6)
bool blinkState = false;

bool dmpReady = false;  // set true if DMP init was successful
uint8_t mpuIntStatus;   // holds actual interrupt status byte from MPU
uint8_t devStatus;      // return status after each device operation (0 = success, !0 = error)
uint16_t packetSize;    // expected DMP packet size (default is 42 bytes)
uint16_t fifoCount;     // count of all bytes currently in FIFO
uint8_t fifoBuffer[64]; // FIFO storage buffer

Quaternion q;           // [w, x, y, z]         quaternion container
VectorInt16 aa;         // [x, y, z]            accel sensor measurements
VectorInt16 gy;         // [x, y, z]            gyro sensor measurements
VectorInt16 aaReal;     // [x, y, z]            gravity-free accel sensor measurements
VectorInt16 aaWorld;    // [x, y, z]            world-frame accel sensor measurements
VectorFloat gravity;    // [x, y, z]            gravity vector
float euler[3];         // [psi, theta, phi]    Euler angle container
float ypr[3];           // [yaw, pitch, roll]   yaw/pitch/roll container and gravity vector

// packet structure for InvenSense teapot demo
volatile bool mpuInterrupt = false;     // indicates whether MPU interrupt pin has gone high

#include <SoftwareSerial.h>
#define en   10   // connected to RS485 Enable pin

SoftwareSerial k (8, 9);
int ofset[6] = {1460,  1732, 2631, 96, -14,  35}; // ax,ay,az,gx,gy,gz


void setup() {
  pinMode(en, OUTPUT);
  k.begin(9600);
  Serial.begin(9600);
  pinMode(LED_PIN, OUTPUT);

#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
  Wire.begin();
  Wire.setClock(400000); // 400kHz I2C clock. Comment this line if having compilation difficulties
#elif I2CDEV_IMPLEMENTATION == I2CDEV_BUILTIN_FASTWIRE
  Fastwire::setup(400, true);
#endif

  mpu.initialize();
  pinMode(INTERRUPT_PIN, INPUT);
  devStatus = mpu.dmpInitialize();

  // ax,ay,az,gx,gy,gz

  mpu.setXAccelOffset(ofset[0]);
  mpu.setYAccelOffset(ofset[1]);
  mpu.setZAccelOffset(ofset[2]);
  mpu.setXGyroOffset(ofset[3]);
  mpu.setYGyroOffset(ofset[4]);
  mpu.setZGyroOffset(ofset[5]);

  if (devStatus == 0) {
    mpu.CalibrateAccel(6);
    mpu.CalibrateGyro(6);
    mpu.PrintActiveOffsets();
    mpu.setDMPEnabled(true);

    attachInterrupt(digitalPinToInterrupt(INTERRUPT_PIN), dmpDataReady, RISING);
    mpuIntStatus = mpu.getIntStatus();
    dmpReady = true;

    packetSize = mpu.dmpGetFIFOPacketSize();
  } else {}

}
unsigned long waktu = 0;

void loop() {
  digitalWrite(en, HIGH);
  if (!dmpReady) return;
  if (mpu.dmpGetCurrentFIFOPacket(fifoBuffer)) { // Get the Latest packet
    waktu = millis();
#ifdef OUTPUT_READABLE_YAWPITCHROLL
    mpu.dmpGetQuaternion(&q, fifoBuffer);
    mpu.dmpGetGravity(&gravity, &q);
    mpu.dmpGetYawPitchRoll(ypr, &q, &gravity);
    // kirimBT();
    if (waktu - millis() > 250) {
      k.print("ypr#");
      k.print(ypr[0] * 180 / M_PI);
      k.print("#");
      k.print(ypr[1] * 180 / M_PI);
      k.print("#");
      k.print(ypr[2] * 180 / M_PI);
      k.print("#");
      k.print("\n");
      k.flush();
      Serial.print("ypr#");
      Serial.print(ypr[0] * 180 / M_PI);
      Serial.print("#");
      Serial.print(ypr[1] * 180 / M_PI);
      Serial.print("#");
      Serial.println(ypr[2] * 180 / M_PI);
      waktu = millis();
    }
    //printSerial();
#endif


  }
}
void dmpDataReady() {
  mpuInterrupt = true;
}

void kirimBT() {
  if (waktu - millis() > 2500) {
    k.print("ypr#");
    k.print(ypr[0] * 180 / M_PI);
    k.print("#");
    k.print(ypr[1] * 180 / M_PI);
    k.print("#");
    k.print(ypr[2] * 180 / M_PI);
    k.print("#");
    k.println();
    k.flush();
    waktu = millis();
  }
}
void printSerial() {
  if (waktu - millis() > 1000) {
    Serial.print("ypr#");
    Serial.print(ypr[0] * 180 / M_PI);
    Serial.print("#");
    Serial.print(ypr[1] * 180 / M_PI);
    Serial.print("#");
    Serial.print(ypr[2] * 180 / M_PI);
    Serial.print("#");
    Serial.println();
    Serial.flush();
    waktu = millis();
  }
}
