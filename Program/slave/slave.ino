#define LED       2
#define EN  21

#define RXD2 16
#define TXD2 17

String dataIn;
String dt[10];
int i;
boolean parsing = false;

//=================Bluetooth=================
#include "BluetoothSerial.h"

#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
#error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif


BluetoothSerial SerialBT;

void setup() {
  pinMode(LED , OUTPUT);                        // Declare LED pin as output
  pinMode(EN , OUTPUT);                   // Declare Enable pin as output
  Serial.begin(9600);                           // set serial communication baudrate
  digitalWrite(EN , LOW);                 // Make Enable pin low
  // Receiving mode ON
  dataIn = "";
  Serial2.begin(9600, SERIAL_8N1, RXD2, TXD2);

  SerialBT.begin("ESP32test"); //Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");
  SerialBT.println("Inclinometer Siap");

  digitalWrite(EN , LOW); //receiver
//  digitalWrite(EN , HIGH);   //tx
}
unsigned long waktu = millis();
void loop() {
  digitalWrite(EN , HIGH); 
  delay(5);
  //  SerialBT.println("Inclinometer Siap bro");
  if (millis() - waktu >= 1000) {
    digitalWrite(EN , HIGH);
    delay(10);
    Serial.println('k');
    Serial.flush();
    //digitalWrite(EN , LOW);
   // cekSerial1();
    waktu = millis();
  }



}

void cekSerial1() {
  while (Serial.available() > 0  )
  {
    char inChar;
    if (Serial.available() > 0)
      inChar = (char)Serial.read();
    //    else if ( Serial2.available() > 0)
    //      inChar = (char)Serial2.read();

    dataIn += inChar;
    if (inChar == '\n') {
      parsing = true;
    }
  }
  if (parsing)
  {
    parsingData();
    parsing = false;
    dataIn = "";
  }
}

void cekSerial2() {
  while (Serial2.available() > 0  )
  {
    char inChar;
    if (Serial2.available() > 0)
      inChar = (char)Serial2.read();
    //    else if ( Serial2.available() > 0)
    //      inChar = (char)Serial2.read();

    dataIn += inChar;
    if (inChar == '\n') {
      parsing = true;
    }
  }
  if (parsing)
  {
    parsingData();
    parsing = false;
    dataIn = "";
  }
}
void parsingData()
{
  int j = 0;
  //kirim data yang telah diterima sebelumnya
  Serial.print("data masuk : ");
  Serial.print(dataIn);
  Serial.print("\n");
  //  SerialBT.write(dataIn);
  //inisialisasi variabel, (reset isi variabel)
  dt[j] = "";
  //proses parsing data
  for (i = 0; i < dataIn.length(); i++)
  {
    //pengecekan tiap karakter dengan karakter (#) dan (,)
    if ((dataIn[i] == '#') || (dataIn[i] == '@') || (dataIn[i] == '='))
    {
      //increment variabel j, digunakan untuk merubah index array penampung
      j++;
      dt[j] = ""; //inisialisasi variabel array dt[j]
    }
    else
    {
      //proses tampung data saat pengecekan karakter selesai.
      dt[j] = dt[j] + dataIn[i];
    }
  }
  if (waktu - millis() > 500) {
    SerialBT.print("X");
    SerialBT.print(dt[1].toFloat());
    // SerialBT.print("\n");
    SerialBT.print("Y");
    SerialBT.print(dt[2].toFloat());
    //SerialBT.print("\n");
    SerialBT.print("Z");
    SerialBT.print(dt[3].toFloat());
    SerialBT.print("Set");
    SerialBT.print("\n");
    waktu = millis();
  }
  //kirim data hasil parsing
  //  Serial.print("data 1 : ");
  //  Serial.print(dt[0]);
  //  Serial.print("\n");
  //  Serial.print("yaw   = ");
  //  Serial.print(dt[1].toFloat());
  //  Serial.print("\n");
  //  Serial.print("pitch = ");
  //  Serial.print(dt[2].toFloat());
  //  Serial.print("\n");
  //  Serial.print("roll  = ");
  //  Serial.print(dt[3].toFloat());
  //  Serial.print("\n");
  //  Serial.print("data 5 : ");
  //  Serial.print(dt[4]);
  //  Serial.print("\n\n");


  //  SerialBT.print("data 1 : ");
  //  SerialBT.print(dt[0]);
  //  SerialBT.print("\n");
  //  SerialBT.print("yaw   = ");
  //  SerialBT.print(dt[1].toFloat());
  //  SerialBT.print("\n");
  //  SerialBT.print("pitch = ");
  //  SerialBT.print(dt[2].toFloat());
  //  SerialBT.print("\n");
  //  SerialBT.print("roll  = ");
  //  SerialBT.print(dt[3].toFloat());
  //  SerialBT.print("\n\n");
  //delay(1000);
}
