//Initailze file header file


#include <stdio.h>
#include <wiringPi.h>	//http://wiringpi.com/download-and-install/
//#include <iostream>
#include <stdlib.h>
#include <string.h>


//COLORS
#define Green_LED 26
#define Yellow_LED 6
#define Red_LED 5
#define Blue_LED 4

//FUNCTIONS
#define record_LED Red_LED	//RED
#define software_status_LED Green_LED //GREEN
#define wifi_LED Blue_LED		//Pin 12
#define stream_LED Yellow_LED	//Pin 24

//BUTTON
#define record_button 0	//Pin 27
#define stream_button 2	//Pin 26
#define shutdown_button 25	//Pin 17


//FUNCTIONS
void Init_Ports(void);	//sets up the IO
void Init_PiCam(void);	//set up 
void start_up_lights(void);	//set up start up lights
void Init_Server(void);
void Updated_Init_PiCam(void);  //doesn't currently work
