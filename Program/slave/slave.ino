#define LED       2
#define SLAVE_EN  21


#define RXD2 16
#define TXD2 17

//======================encoder=================
#define faseA 13
#define faseB 12

int sudut = 0, sudutraw, counter = 0, stateA, stateAend;
//long counter = 0, panjangLama = 0;

//======================parsingData=============
String dataIn;
String dt[10];
int i;
boolean parsing = false, parsing2 = false;
int yaw = 0, pitch = 0, roll = 0;
//=================Bluetooth=================
#include "BluetoothSerial.h"



#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
#error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif

BluetoothSerial SerialBT;

int panjang = 0;

void setup() {
  pinMode(LED , OUTPUT);                        // Declare LED pin as output
  pinMode(SLAVE_EN , OUTPUT);                   // Declare Enable pin as output
  pinMode(faseA, INPUT);
  pinMode(faseB, INPUT);


  Serial.begin(9600);                           // set serial communication baudrate
  digitalWrite(SLAVE_EN , LOW);                 // Make Enable pin low
  // Receiving mode ON
  dataIn = "";
  Serial2.begin(9600, SERIAL_8N1, RXD2, TXD2);

  SerialBT.begin("Inclinometer"); //Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");


}
unsigned long waktu = millis();
void loop() {
  //digitalWrite(SLAVE_EN , HIGH);// tx

  //ambilMPU();
  bacaEncoder();
  panjang = counter ;

  Serial.print("panjang = ");
  Serial.println(panjang);

}
void ambilMPU() {
  digitalWrite(SLAVE_EN , LOW);// receiver
  delay(5);
  while (Serial.available() > 0)
  {
    char inChar = (char)Serial.read();
    dataIn += inChar;
    if (inChar == '\n') {
      parsing = true;
    }
  }
  if (parsing)
  {
    parsingData();
    parsing2 = false;
    dataIn = "";
  }

  if (waktu - millis() > 2500) {
    SerialBT.print("X");
    SerialBT.print(yaw);
    SerialBT.print("Y");
    SerialBT.print(pitch);
    SerialBT.print("R");
    SerialBT.print(roll);
    SerialBT.print("P");
    SerialBT.print(panjang);
    SerialBT.print("SetA");

    //      SerialBT.print("yaw   = ");
    //      SerialBT.print(yaw);
    //      SerialBT.print("\n");
    //      SerialBT.print("pitch = ");
    //      SerialBT.print(pitch);
    //      SerialBT.print("\n");
    //      SerialBT.print("roll  = ");
    //      SerialBT.print(roll);
    SerialBT.print("\n\n");
    waktu = millis();
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
  yaw = dt[1].toFloat();
  pitch = dt[2].toFloat();
  roll = dt[3].toFloat();
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
  dataIn = "";
}


void parsingData2()
{
  int j = 0;
  //kirim data yang telah diterima sebelumnya
  Serial.print("data masuk2 : ");
  Serial.print(dataIn);
  Serial.print("\n");
  //  SerialBT.write(dataIn);
  //inisialisasi variabel, (reset isi variabel)
  dt[j] = "";
  //proses parsing data
  for (i = 0; i < dataIn.length(); i++)
  {
    //pengecekan tiap karakter dengan karakter (#) dan (,)
    if ((dataIn[i] == 'z') || (dataIn[i] == 'S') || (dataIn[i] == '='))
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
  panjang = dt[1].toInt();
  Serial.print("pj = ");
  Serial.println(panjang);
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
