#include <SoftwareSerial.h>

//#define LED       2
#define SLAVE_EN  32
#define btn 18


//SoftwareSerial rs485();

int panjangLama = 0;
long counter = 0;
//======================parsingData=============
String dataIn;
String dt[10];
int i;
boolean parsing = false;


int yaw = 0, pitch = 0, roll = 0;


int panjang = 0;

void ai0() {
  // ai0 is activated if DigitalPin nr 2 is going from LOW to HIGH
  // Check pin 3 to determine the direction
  if (digitalRead(3) == LOW) {
    counter++;
  } else {
    counter--;
  }
}

void ai1() {
  // ai0 is activated if DigitalPin nr 3 is going from LOW to HIGH
  // Check with pin 2 to determine the direction
  if (digitalRead(2) == LOW) {
    counter--;
  } else {
    counter++;
  }
}

void setup() {
  //  pinMode(LED , OUTPUT);                        // Declare LED pin as output
  pinMode(SLAVE_EN , OUTPUT);                   // Declare Enable pin as output
  //  pinMode(faseA, INPUT);
  //  pinMode(faseB, INPUT);
  //
  //  attachInterrupt(faseA, baca, RISING);

  pinMode(2, INPUT_PULLUP); // internal pullup input pin 2

  pinMode(3, INPUT_PULLUP); // internalเป็น pullup input pin 3
  //Setting up interrupt
  //A rising pulse from encodenren activated ai0(). AttachInterrupt 0 is DigitalPin nr 2 on moust Arduino.
  attachInterrupt(0, ai0, RISING);

  //B rising pulse from encodenren activated ai1(). AttachInterrupt 1 is DigitalPin nr 3 on moust Arduino.
  attachInterrupt(1, ai1, RISING);
  // attachInterrupt(faseB, ISR, Mode);

  pinMode(btn, INPUT_PULLUP);

  Serial.begin(9600);                           // set serial communication baudrate
  Serial3.begin(9600);                          //Xbee
  Serial2.begin(9600);                          //RS485
  digitalWrite(SLAVE_EN , LOW);                 // Make Enable pin low
  // Receiving mode ON
  dataIn = "";

  //  SerialBT.begin("Inclinometer"); //Bluetooth device name


}
unsigned long waktu = millis(), waktuEncoder = millis();
void loop() {
  digitalWrite(SLAVE_EN , LOW);// receiver
  if (digitalRead(btn) == 0) {
    counter = panjang = 0;
  }
  if (Serial2.available() > 0)
  {
    char inChar = (char)Serial2.read();
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
  if (millis() - waktuEncoder > 250) {
    panjang = counter * 50 / 24000;
    waktuEncoder = millis();
    Serial.print("Panjang  =================  ");
    Serial.println(panjang);
  }

  if (panjang != panjangLama) {
    Serial.println("==========================kirimBT");
    kirimBT();
    panjangLama = panjang;
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
  roll = dt[3].toFloat() - 1;
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



void kirimBT() {
  Serial3.print(pitch);
  Serial3.print("#");
  Serial3.print(yaw);
  Serial3.print("#");
  Serial3.print(roll);
  Serial3.print("#");
  Serial3.print(panjang);
  Serial3.print("\n");
  waktu = millis();
}
