#include <SoftwareSerial.h>
SoftwareSerial HC12(3, 2); // HC-12 TX Pin, HC-12 RX Pin

#define faseA 8
#define faseB 9

unsigned long waktu = 0,sudut = 0, sudutraw, counter = 0;
int  stateA, stateAend;


void setup() {
  // put your setup code here, to run once:
  pinMode(faseA, INPUT);
  pinMode(faseB, INPUT);
  Serial.begin(9600);
  waktu = millis();
  HC12.begin(9600);               // Serial port to HC12
}
void loop() {


  bacaEncoder();
  // HC12.write(sudutraw);
  if (millis() - waktu >= 500) {
    Serial.print("sudut = ");
    Serial.println(sudutraw);
    waktu = millis();
    HC12.write("Z");
    HC12.print(sudutraw);
    HC12.println("setB");
  }

}


void bacaEncoder()
{
  stateA = digitalRead(faseA); // baca status awal dari fase A
  // kalo kondisi state fase A sekarang dan sebelumnya berbeda, berarti ada pulsa yang masuk guys
  if (stateA != stateAend) {
    // kalo state fase B berbeda dengan state fase A, berarti encoder berputar searah jarum jam
    if (digitalRead(faseB) != stateA) {
      counter ++;
    } else {
      counter --;
    }
    //Serial.println(counter);
    sudutraw = counter;
  }
  stateAend = stateA; //update state dari fase
  sudut = sudutraw / 5.57;
 
}
