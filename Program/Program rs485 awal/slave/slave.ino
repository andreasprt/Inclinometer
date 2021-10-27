#include <SoftwareSerial.h>

#define LED       2
#define SLAVE_EN  10
SoftwareSerial k(8, 9);

void setup() {
  pinMode(LED , OUTPUT);                        // Declare LED pin as output
  pinMode(SLAVE_EN , OUTPUT);                   // Declare Enable pin as output
  Serial.begin(9600);
  k.begin(9600);
  // set serial communication baudrate
  digitalWrite(SLAVE_EN , LOW);                 // Make Enable pin low
  // Receiving mode ON
}

void loop() {
  while (Serial.available())                    // If serial data is available then enter into while loop
  {
    Serial.println("Serial 1 ");
    if (Serial.read() == 'A')                   // if available data is A
    {

      digitalWrite(LED , !digitalRead(LED));    // LED Blink
    }
  }
  while (k.available())                    // If serial data is available then enter into while loop
  {
    Serial.println(" Software Serial ");
    if (k.read() == 'A')                   // if available data is A
    {

      digitalWrite(LED , !digitalRead(LED));    // LED Blink
    }
  }
}
