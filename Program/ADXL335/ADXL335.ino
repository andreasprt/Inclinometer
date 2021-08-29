// Simple angle meter using ADXL335 accelerometer
// from electronicsblog.net/

#define ADC_ref 3.5

#define zero_x 1.569// 1.569

#define zero_y 1.569

#define zero_z 1.569

#define sensitivity_x 0.33

#define sensitivity_y 0.33

#define sensitivity_z 0.33

unsigned int value_x;
unsigned int value_y;
unsigned int value_z;

float xv;
float yv;
float zv;

float angle_x;
float angle_y;
float angle_z;

//int x = 1, y = 2, z = 3;

#define x 1
#define y 2
#define z 3


void setup()   {

  analogReference(EXTERNAL);
  Serial.begin(115200);

}

void loop() {

  //  angle_x = sudutX(40);
  //  angle_y = sudutY(40);
  //  angle_z = sudutZ(40);

  angle_x = sudut(40, x);
  angle_y = sudut(40, y);
  angle_z = sudut(40, z);

  Serial.print("Rotation ");
  Serial.print("x= ");
  Serial.print(angle_x);
  Serial.print(" deg");
  Serial.print(" ");

  Serial.print("y= ");
  Serial.print(angle_y);
  Serial.print(" deg");
  Serial.print(" ");

  Serial.print("z= ");
  Serial.print(angle_z);
  Serial.print(" deg");
  Serial.print("\n");

}
int sudutX(int sample) {
  for (int i = 0; i <= sample; i++) {
    value_x = analogRead(0);
    value_y = analogRead(1);
    value_z = analogRead(2);
    xv = (value_x * ADC_ref / 1024.0 - zero_x) / sensitivity_x;
    yv = (value_y  * ADC_ref / 1024.0 - zero_y) / sensitivity_y;
    zv = (value_z * ADC_ref / 1024.0 - zero_z) / sensitivity_z;
    angle_x += atan(xv / sqrt((yv * yv) + (zv * zv))) * 57.2957795;
  }

  return angle_x / sample;
}
int sudutY(int sample) {
  for (int i = 0; i <= sample; i++) {
    value_x = analogRead(0);
    value_y = analogRead(1);
    value_z = analogRead(2);
    xv = (value_x * ADC_ref / 1024.0 - zero_x) / sensitivity_x;
    yv = (value_y  * ADC_ref / 1024.0 - zero_y) / sensitivity_y;
    zv = (value_z * ADC_ref / 1024.0 - zero_z) / sensitivity_z;
    angle_y += atan(yv / sqrt((xv * xv) + (zv * zv))) * 57.2957795;
  }

  return angle_y / sample;
}
int sudutZ(int sample) {
  for (int i = 0; i <= sample; i++) {
    value_x = analogRead(0);
    value_y = analogRead(1);
    value_z = analogRead(2);
    xv = (value_x * ADC_ref / 1024.0 - zero_x) / sensitivity_x;
    yv = (value_y  * ADC_ref / 1024.0 - zero_y) / sensitivity_y;
    zv = (value_z * ADC_ref / 1024.0 - zero_z) / sensitivity_z;
    angle_z += atan(sqrt((xv * xv) + (yv * yv))) * 57.2957795;
  }
  return angle_z / sample;
}

int sudut(int sample, int sumbu ) {
  for (int i = 0; i <= sample; i++) {
    value_x = analogRead(0);
    value_y = analogRead(1);
    value_z = analogRead(2);

    xv = (value_x * ADC_ref / 1024.0 - zero_x) / sensitivity_x;
    yv = (value_y  * ADC_ref / 1024.0 - zero_y) / sensitivity_y;
    zv = (value_z * ADC_ref / 1024.0 - zero_z) / sensitivity_z;

    angle_x += atan(xv / sqrt((yv * yv) + (zv * zv))) * 57.2957795;
    angle_y += atan(yv / sqrt((xv * xv) + (zv * zv))) * 57.2957795;
    angle_z += atan(sqrt((xv * xv) + (yv * yv))) * 57.2957795;
  }

  //  if (sumbu == "x") {
  //    return angle_x / sample;;
  //  }
  //  if (sumbu == "y") {
  //    return angle_y / sample;;
  //  }
  //  if (sumbu == "z") {
  //    return angle_z / sample;
  //  }
  switch (sumbu) {
    case x:    // your hand is on the sensor
      return 100;
      break;
    case y:    // your hand is close to the sensor
      return 1000;
      break;
    case z:    // your hand is a few inches from the sensor
      return 2000;
      break;

  }
  //return 0
}
