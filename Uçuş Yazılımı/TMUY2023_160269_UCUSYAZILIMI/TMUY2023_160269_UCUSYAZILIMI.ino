#include <SimpleKalmanFilter.h>
#include <Adafruit_BMP280.h>
#include <SoftwareSerial.h>
#include <Adafruit_GPS.h>
#include <ezButton.h>
#include <TimeLib.h>
#include <EEPROM.h>
#include <String.h>
#include <Servo.h>
#include <Wire.h>
#include <SPI.h>
#include <SD.h> 
#include <stdlib.h>
#include "MPU6050_6Axis_MotionApps20.h"
#include "TeensyThreads.h"
#include "I2Cdev.h"
#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
 #include "Wire.h"
#endif

#define GPSECHO true
#define M0 40
#define M1 41

const int video_pin=15;
const int servoPin = 0;
const int buzzerPin = 22;
const int bonus_pin=14;
ezButton limitSwitch(33);  // create ezButton object that attach to pin 
SoftwareSerial HC12(7,8);    // HC-12 TX Pin, HC-12 RX Pin
SoftwareSerial Lora(35,34);  // Lora TX Pin, Lora RX Pin
//SoftwareSerial Xbee(0,1);     // XBEE TX Pin , XBEE RX Pin
Adafruit_GPS GPS(&Serial4);
Adafruit_BMP280 bmp;
Servo ServoAyril;
MPU6050 mpu;

SimpleKalmanFilter simpleKalmanFilterPre(1, 1, 0.01);

#define OUTPUT_TEAPOT
#define OUTPUT_READABLE_YAWPITCHROLL
// MPU control/status vars
bool dmpReady = false;  // set true if DMP init was successful
uint8_t mpuIntStatus;   // holds actual interrupt status byte from MPU
uint8_t devStatus;      // return status after each device operation (0 = success, !0 = error)
uint16_t packetSize;    // expected DMP packet size (default is 42 bytes)
uint16_t fifoCount;     // count of all bytes currently in FIFO
uint8_t fifoBuffer[64]; // FIFO storage buffer

// orientation/motion vars
Quaternion q;           // [w, x, y, z]         quaternion container
VectorInt16 aa;         // [x, y, z]            accel sensor measurements
VectorInt16 aaReal;     // [x, y, z]            gravity-free accel sensor measurements
VectorInt16 aaWorld;    // [x, y, z]            world-frame accel sensor measurements
VectorFloat gravity;    // [x, y, z]            gravity vector
float euler[3];         // [psi, theta, phi]    Euler angle container
float ypr[3];           // [yaw, pitch, roll]   yaw/pitch/roll container and gravity vector

// packet structure for InvenSense teapot demo
uint8_t teapotPacket[14] = { '$', 0x02, 0,0, 0,0, 0,0, 0,0, 0x00, 0x00, '\r', '\n' };

volatile bool mpuInterrupt = false;     // indicates whether MPU interrupt pin has gone high
void dmpDataReady() {mpuInterrupt = true;}

const long SERIAL_REFRESH_TIME = 1000;
long refresh_time;

File file;
float KalibreBasinc=994.70,basinc1,TasiyiciKalibre=1000.70;
int takim_no=160269;
int paket_no=1;
bool ayrilma_degiskeni=false,MUY_ayrilma=false,kurtar=false,bayrak_ayrilma=false;
int pitch,roll,yaw;
float filtreyukseklik,denemeyukseklik,yukseklik,hiz;
float irtifa,statu_degis,yuk2,bas2;
float volt,valuevolt;
String aras,aras1,aras2,aras3,aras4,aras5,komut;
byte statu,video_value=0,kurtarma=0,bonus_value=0,statu_video=0,statu_bonus=0,high,low,ilk,son;
String tasiyici;
String Telemetri="PAKET NUMARASI;UYDU STATUSU;HATA KODU;GONDERME SAATI;BASINC1;BASINC2;YUKSEKLIK1;YUKSEKLIK2;IRTIFA FARKI;INIS HIZI;SICAKLIK;PIL GERILIMI;GPS1 LATITUDE;GPS1 LONGITUDE;GPS1 ALTITUDE;PITCH;ROLL;YAW;TAKIM NO";

void setup() 
{
  threads.addThread(YerIstasyonu);
  
  Serial.begin(9600);
  HC12.begin(9600);
  //Xbee.begin(57600);      //XBEE modülü kullanılırsa diye ek kod
  pinMode(M0, OUTPUT);
  pinMode(M1, OUTPUT);
  digitalWrite(M0, LOW);
  digitalWrite(M1, LOW);
  Lora.begin(57600);
  GPS.begin(9600);
  
  GPS.sendCommand(PMTK_SET_NMEA_OUTPUT_RMCGGA);
  GPS.sendCommand(PMTK_SET_NMEA_UPDATE_1HZ);
  GPS.sendCommand(PGCMD_ANTENNA);

  SD.begin(BUILTIN_SDCARD);

  file = SD.open("TMUY2023_160269_TLM.csv", FILE_WRITE);
      if(file)
      {
        file.println(Telemetri);
        file.close();
      }
  limitSwitch.setDebounceTime(250); // set debounce time
  setSyncProvider(getTeensy3Time);
  
  //ilk=EEPROM.read(1);
  //son=EEPROM.read(2);
  //paket_no= ilk + (son << 8);    
  //bayrak_ayrilma=EEPROM.read(3);
  //ayrilma_degiskeni=EEPROM.read(4);
  
  //KALİBRASYON İŞLEMİ SONRASI YORUM SATIRI OLACAK RTC ÇALIŞMASI KONTROLÜ-------
  /*if (timeStatus()!= timeSet) {
    Serial.println("Unable to sync with the RTC");
  } else {
    Serial.println("RTC has set the system time");
  }*/
  //----------------------------------------------------------------------------
  
    #if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
        Wire.begin();
        Wire.setClock(400000); // 400kHz I2C clock. Comment this line if having compilation difficulties
    #elif I2CDEV_IMPLEMENTATION == I2CDEV_BUILTIN_FASTWIRE
        Fastwire::setup(400, true);
    #endif
  mpu.initialize();
    devStatus = mpu.dmpInitialize();
    
    mpu.setXGyroOffset(-74);
    mpu.setYGyroOffset(37);
    mpu.setZGyroOffset(-20);
    mpu.setXAccelOffset(6870); // 1688 factory default for my test chip
    mpu.setYAccelOffset(6870);
    mpu.setZAccelOffset(6870);
    
    if (devStatus == 0) 
    {
        //KALİBRASYON İŞLEMİ SONRASI ALTTAKİ İLK 3 SATIR YORUM SATIRI OLACAK------
        /*mpu.CalibrateAccel(6);
        mpu.CalibrateGyro(6);
        mpu.PrintActiveOffsets();*/
        //------------------------------------------------------------------------
        mpu.setDMPEnabled(true);

        //attachInterrupt(digitalPinToInterrupt(INTERRUPT_PIN), dmpDataReady, RISING);      Sorun çıkardı anlamadım
        mpuIntStatus = mpu.getIntStatus();
        dmpReady = true;
        packetSize = mpu.dmpGetFIFOPacketSize();
    }
  unsigned status;
  status = bmp.begin();
  if (!status) 
  {
    Serial.println(F("Could not find a valid BMP280 sensor, check wiring or "
                      "try a different address!"));
    while (1) delay(10);
  }
  pinMode(video_pin,INPUT); 
  pinMode(bonus_pin,INPUT);       
  pinMode(buzzerPin, OUTPUT);      
  ServoAyril.attach(servoPin);
  ServoAyril.write(0);            
}



void loop() 
{
  limitSwitch.loop(); // MUST call the loop() function first

  
  basinc1 = bmp.readPressure()/100;
  yukseklik = bmp.readAltitude(KalibreBasinc);
  filtreyukseklik = simpleKalmanFilterPre.updateEstimate(yukseklik);


    
  char c = GPS.read();
    if ((c) && (GPSECHO))
    if(GPS.newNMEAreceived())
    {
      if (!GPS.parse(GPS.lastNMEA())) 
        return;                      
    }

    

  if (filtreyukseklik > 150.0)   //Ayrılma Bayrak
  {
     ayrilma_degiskeni=true;
  }
  if(filtreyukseklik <= 120.0 && ayrilma_degiskeni == true)
  {
    ServoAyril.write(120);
  }




  if (limitSwitch.isPressed())
  {
    bayrak_ayrilma=true;
  }
  
  if ( (limitSwitch.isReleased()) && (bayrak_ayrilma == true) /*&& (filtreyukseklik <= 120.0) && (ayrilma_degiskeni == true)*/ )
  {
    MUY_ayrilma=true;
  }



  statu_degis=filtreyukseklik - denemeyukseklik;
                                                                                                    //Statü parametreleri değişecek
  if ((filtreyukseklik < 7.00) && (ayrilma_degiskeni == false))  
  {
    statu = 0;
  }
  if ((filtreyukseklik < 1000.) && (filtreyukseklik > 7.00)) 
  { 
    statu = 1;
  }
  if ((filtreyukseklik <= 1000.) && (filtreyukseklik > 120.00) && (statu_degis < 0.0)) 
  { 
    statu = 2;
  }
  if ((filtreyukseklik <= 130.10) && (filtreyukseklik >= 110.50) && (ayrilma_degiskeni == true)) ///
  {
    statu = 3;
  }
  if ((filtreyukseklik <= 120.00) && (filtreyukseklik > 7.00) && (MUY_ayrilma=true))
  {
    statu = 4;
  }
  if ((filtreyukseklik <= 7.00) && (ayrilma_degiskeni == true)) 
  {
    statu = 5;  
    //kurtar=true;
    tone(buzzerPin,262);
  }

  

  valuevolt = analogRead(23);         // Analog pin
  volt = (valuevolt * 14.3) / 1023.0; 
  video_value = digitalRead(video_pin);
  bonus_value = digitalRead(bonus_pin);



  
   if (!dmpReady) return;
  if (mpu.dmpGetCurrentFIFOPacket(fifoBuffer)) 
  { 
    mpu.dmpGetQuaternion(&q, fifoBuffer);
    mpu.dmpGetGravity(&gravity, &q);
    mpu.dmpGetYawPitchRoll(ypr, &q, &gravity); 
  }
    yaw = ypr[0] * 180/M_PI;
    pitch = ypr[1] * 180/M_PI;
    roll = ypr[2] * 180/M_PI;     



  
  if (millis() > refresh_time)
  {
   if(kurtar)         //TEST için 2 satır kapanacak
     kurtarma+=1;

    String gps_lat=String(GPS.latitude,4);   
    float gps1_lat1 = ((gps_lat.substring(0,2).toFloat);
    float gps1_lat2 = (gps_lat.substring(2,gps_lat.length()).toFloat) / 60.0;
    float gps1 = gps1_lat1+gps1_lat2;


    String gps_long=String(GPS.longitude,4);
    float gps1_long1 = ((gps_long.substring(0,2).toFloat);
    float gps1_long2 = (gps_long.substring(2,gps_long.length()).toFloat) / 60.0;
    float gps2 = gps1_long1+gps1_long2;


    hiz = abs(denemeyukseklik - filtreyukseklik);


    if (HC12.available() && MUY_ayrilma == 1)
    {      
      tasiyici = HC12.readStringUntil('*');
    
      bas2 = tasiyici.toFloat();
      yuk2 = bmp.seaLevelForAltitude(TasiyiciKalibre,bas2);
    
      if(bas2 == 0.0)
          yuk2=0.0;
        
      irtifa = abs(filtreyukseklik - yuk2);
    }


    
    
    if (video_value == 1 && statu_video < 1)
    { 
      statu=6;
      statu_video++;
    }
    
    if (bonus_value == 1 && statu_bonus < 1 )
    {
     statu=7;
     statu_bonus++;
    }

    

    if (hiz <= 14.00 && hiz >= 12.00 && MUY_ayrilma == false)
      aras1="0";
    else
      aras1="1";
      
    if (hiz <= 8.00 && hiz >= 6.00 && MUY_ayrilma == true)
    {
       aras2="0";
       aras1="1";
    }
    else
      aras2="1";
      
    if (bas2 == 0.00)
      aras3="1";
    else
      aras3="0";    
      
    if (GPS.fix)
      aras4="0";
    else
      aras4="1";    
    
    if (MUY_ayrilma == true)
      aras5="0";
    else
      aras5="1";
            
    aras=aras1+aras2+aras3+aras4+aras5;

    
    String telemetriSD = String(paket_no) + ";" + String(statu) + ";" + String(aras) + ";" + String(day()) + "/" + String(month()) + "/" + String(year()) + "," + String(hour(now())) + "/" + String(minute(now())) + "/" + String(second(now())) + ";" + String(basinc1,2) + ";" + String(bas2,2) + ";" + String(filtreyukseklik) + ";" + String(yuk2,2) + ";" + String(irtifa) + ";" + String(hiz) + ";" + String(bmp.readTemperature()) + ";" + String(volt) + ";" + String(gps1,6) + ";" + String(gps2,6) + ";" + String(GPS.altitude) + ";" + String(pitch) + ";" + String(roll) + ";" + String(yaw) + ";" + String(takim_no);


    if (kurtarma<11) 
    {
      Lora.write((byte)0x06);       //Alıcı Adresi HIGH
      Lora.write((byte)0x42);       //Alıcı Adresi LOW
      Lora.write((byte)0x1a);       //Alıcı Kanalı =0x17=23

      Lora.println(telemetriSD);
      //Xbee.println(telemetriSD);  //XBEE modülü kullanılırsa diye ek kod
      Serial.println(telemetriSD);
      
      file = SD.open("TMUY2023_160269_TLM.csv", FILE_WRITE);
      if(file)
      {
        file.println(telemetriSD);
        file.close();
      }
    }
    
    
    paket_no+=1;
    low= lowByte(paket_no);
    high=highByte(paket_no);
    EEPROM.write(1,low);
    EEPROM.write(2,high);
    EEPROM.write(3,bayrak_ayrilma);
    EEPROM.write(4,ayrilma_degiskeni);
    
    bas2=0.00;
    yuk2=0.00;
    irtifa=0.00;
    tasiyici = "";
    denemeyukseklik=filtreyukseklik;
    refresh_time = millis() + SERIAL_REFRESH_TIME;
  }
}



void YerIstasyonu()
{
  while (1)
  {
    if (Lora.available())
    {
     komut = Lora.read();
     if(komut == "m")
     {
      ServoAyril.write(120);
      MUY_ayrilma=true;
     }
    }
    /*if(Xbee.available())   //XBEE modülü kullanılırsa diye ek kod
  {
    komut = Xbee.read();
    if(komut == "m")
     {
      ServoAyril.write(105); 
     }
  }*/
    threads.yield();
  }
}

time_t getTeensy3Time()
{
  return Teensy3Clock.get();
}
