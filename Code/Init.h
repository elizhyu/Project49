//Initailze file header file


#include <stdio.h>
#include <wiringPi.h>	//http://wiringpi.com/download-and-install/
//#include <iostream>
#include <stdlib.h>
#include <string.h>

//THESE NUMBERS BELOW NEED TO CHANGE!!!
//dont need '=' or ';' for define statments
#define record_LED 6	//RED
#define software_status_LED 4 //GREEN
#define wifi_LED 26		//Pin 12
#define stream_LED 5	//Pin 24
#define Green_LED 4
#define Yellow_LED 5
#define Red_LED 6
#define Blue_LED 26
#define record_button 0	//Pin 27
#define stream_button 2	//Pin 26
#define shutdown_button 25	//Pin 17



void Init_Ports(void);	//sets up the IO
void Init_PiCam(void);	//set up 
void start_up_lights(void);	//set up start up lights
void Init_Server(void);
