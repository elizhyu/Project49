//Main File for Senior Design Projecct

#include <stdio.h>	//Standard library needed
#include <stdbool.h> 	//this allows us to use boolean
#include <wiringPi.h>	//might not need it in the main file
bool stream_bool = true;	//setting the initial streaming to true
bool wifi_found = false; //flag for checking network activity


#include "Init.h"	//the intialize GPIO 
#include "RecordStream.h"	//the recording functions and sets up the interrupts for the pushbuttons
#include "NetworkChecker.h"
//#include "bq27xxx_battery.c"
//#include "bq27xxx_battery_i2c.c"

int main(void)
{
	wiringPiSetup();
	Init_Ports();	//initilze the GPIO's
	start_up_lights();	//start up light
	Init_PiCam();	//sets up just PiCam, NO SERVER
	digitalWrite(Green_LED,0);

	int counter = 0;
	int Networkcounter = 0;
	int wifi_check_freq = 20000;
	while(1)
	{
		if (counter == wifi_check_freq)
		{
			wifi_found = NetworkIndicator();
			counter = 0;
			Networkcounter ++;

			if (wifi_found)
				wifi_check_freq = 35000;
			else
				wifi_check_freq = 20000;
		}
		set_rec_LED();
		counter++;		
	}
}
