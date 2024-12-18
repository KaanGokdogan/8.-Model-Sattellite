# This repository contains the Ground Station Interface and Flight Software developed for the 8. Model Satellite Competition.
## Overview
### Ground Station Interface
#### The ground station interface allows users to:
- Monitor real-time telemetry data from the satellite.
- Send commands to control the satellite's operation.
- Visualize satellite data with graphs and live metrics.
### Flight Software
#### The flight software runs on the satellite, enabling:
- Data collection from sensors.
- Communication with the ground station via [UART, LoRa.].
- Execution of predefined mission sequences.
### Technology Stack
####Ground Station Interface: 
- The ground station interface is developed using C# and Windows Forms to provide a responsive and user-friendly application for monitoring and controlling the satellite.
#### Flight Software: 
- The flight software is written in C/C++ and designed to run on an Arduino-compatible microcontroller (Teensy 4.1)
