#include <WiFi.h>
#include <WiFiClient.h>
#include "ESP32FtpServer.h"
#include <SD.h>

const char* ssid = "B-DISPATE";
const char* password = "bdispate%1";

/*IPAddress AP_LOCAL_IP(192, 168, 1, 4);
IPAddress AP_GATEWAY_IP(192, 168, 1, 4);
IPAddress AP_NETWORK_MASK(255, 255, 255, 0);*/

FtpServer ftpSrv;   

File root;
const int chipSelect = 5;
const long SERIAL_REFRESH_TIME = 600;
long refresh_time;
const int pin = 32;
const int pinBonus = 33;

void setup(void)
{
   Serial.begin(115200);
   
  /*if (!WiFi.softAPConfig(AP_LOCAL_IP, AP_GATEWAY_IP, AP_NETWORK_MASK))
  {
    Serial.println("AP Config Failed");
    return;
  }
  WiFi.softAP(ssid, password);
  Serial.print("AP IP address: ");
  IPAddress IP = WiFi.softAPIP();
  Serial.println(IP); */
  
 
  WiFi.begin(ssid, password);
  Serial.println("");
  pinMode(19, INPUT_PULLUP);
  pinMode(pin,OUTPUT);
  pinMode(pinBonus,OUTPUT);

  // Wait for connection
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP());
  
  if (SD.begin(chipSelect))
  {
      Serial.println("SD opened!");
      ftpSrv.begin("bdispate","bdispate");    
  }
  else
  {
    Serial.println("initialization failed. Things to check:");
    Serial.println("1. is a card inserted?");
    Serial.println("2. is your wiring correct?");
    Serial.println("3. did you change the chipSelect pin to match your shield or module?");
    Serial.println("Note: press reset or reopen this serial monitor after fixing your issue!");
    while (true);   
  }
}

void loop(void)
{
  ftpSrv.handleFTP();   

    if (millis() > refresh_time)
    {
      /*int32_t rssi = WiFi.RSSI();
      Serial.print("RSSI: ");
      Serial.println(rssi);*/

      root = SD.open("/");
      printDirectory(root, 0);
  
    refresh_time = millis() + SERIAL_REFRESH_TIME;
    }
  // nothing happens after setup finishes.
}

void printDirectory(File dir, int numTabs) 
{
  while (true) 
  {
    File entry =  dir.openNextFile();
    if (! entry) {
      // no more files
      break;
    }
    //Serial.print(entry.name());
    String namee = String(entry.name());
    Serial.println(namee);
    
    if (entry.isDirectory()) 
    {
      Serial.print("/");
      printDirectory(entry, numTabs + 1);
    } 
    else 
    {
      // files have sizes, directories do not
     
      String boyut=String(entry.size());
      //Serial.println(boyut);
      int sizee = boyut.toInt();
      Serial.println(sizee);
      if(sizee > 490000)
      {
        digitalWrite(pin,HIGH);
      }
      
      if(namee == "basarili.txt")
      {
        digitalWrite(pinBonus,HIGH);
        SD.remove("/basarili.txt");
      }
    }
    entry.close();
  }
}
