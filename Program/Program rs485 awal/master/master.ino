#include <SoftwareSerial.h>
#define LED       6    // Declare LED pin
#define MASTER_EN   10   // connected to RS485 Enable pin

SoftwareSerial k(9, 11);

void setup() {
  pinMode(LED , OUTPUT);            // Declare LED pin as output
  pinMode(MASTER_EN , OUTPUT);      // Declare Enable pin as output
  Serial.begin(9600);               // set serial communication baudrate
  k.begin(9600);
  digitalWrite(MASTER_EN , LOW);    // Make Enable pin low
  // Receiving mode ON
}

void loop() {
  digitalWrite(MASTER_EN , HIGH);     // Make Enable pin high to send Data
  delay(5);                           // required minimum delay of 5ms
  Serial.println('A');                // Send character A serially
  Serial.flush();                     // wait for transmission of data
  k.println('A');                // Send character A serially
  k.flush();                     // wait for transmission of data

  delay(1000);
  digitalWrite(MASTER_EN , LOW);      // Receiving mode ON
}
