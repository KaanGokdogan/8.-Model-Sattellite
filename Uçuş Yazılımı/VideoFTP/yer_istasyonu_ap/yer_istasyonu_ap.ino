#include "WiFi.h"
#include "SPIFFS.h"
#include <WiFi.h>

const char* ssid = "B-DISPATE";
const char* password = "bdispate%1";

IPAddress AP_LOCAL_IP(192, 168, 1, 5);
IPAddress AP_GATEWAY_IP(192, 168, 1, 5);
IPAddress AP_NETWORK_MASK(255, 255, 255, 0);
  
void setup()
{
  Serial.begin(115200);
  
  if (!WiFi.softAPConfig(AP_LOCAL_IP, AP_GATEWAY_IP, AP_NETWORK_MASK))
  {
    Serial.println("AP Config Failed");
    return;
  }
  WiFi.softAP(ssid, password);
  Serial.print("AP IP address: ");
  IPAddress IP = WiFi.softAPIP();
  Serial.println(IP); 
}

    
void loop(void){ 
}
