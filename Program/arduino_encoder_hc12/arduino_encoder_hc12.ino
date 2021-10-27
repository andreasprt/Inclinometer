#include <SoftwareSerial.h>
SoftwareSerial HC12(3, 2); // HC-12 TX Pin, HC-12 RX Pin

#define faseA 8
#define faseB 9

unsigned long waktu = 0;
int  stateA, stateAend;
long panjang = 0, counter = 0, panjangLama = 0;

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
  if (millis() - waktu >= 500 && panjang != panjangLama) {
    Serial.print("sudut = ");
    Serial.println(panjang);
    waktu = millis();
    HC12.write("z");
    HC12.print(panjang);
    HC12.println("SetB");
    panjangLama = panjang;
  }

}
