//Main File for Senior Design Projecct

#include <stdio.h>	//Standard library needed
#include <stdbool.h> 	//this allows us to use boolean
#include <wiringPi.h>	//might not need it in the main file
bool stream_bool = true;	//setting the initial streaming to true
bool wifi_found = false; //flag for checking network activity


#include "Init.h"	//the intialize GPIO 
#include "RecordStream.h"	//the recording functions and sets up the interrupts for the pushbuttons
#include "NetworkChecker.h"
#include "BMS.h"


int main(void)
{
	wiringPiSetup();	//needed to use wiringPi
	Init_Ports();	//initilze the GPIO's
	start_up_lights();	//start up light
	Init_PiCam();	//sets up just PiCam, NO SERVER
	digitalWrite(Green_LED,0);	//turn on the green light once everything has been set up

	int counter = 0;
	int Networkcounter = 0;
	int wifi_check_freq = 20000;
	uint min_timer = 0;
	int battery_percent;

	while(1)
	{
		if (counter == wifi_check_freq)
		{
			wifi_found = NetworkIndicator();
			counter = 0;
			Networkcounter ++;

			if (wifi_found)
				wifi_check_freq = 3500;
			else
				wifi_check_freq = 2000;
		}
		set_rec_LED();
		counter++;	

		//timer for checking battery status and restarting recording every ~minute
		if(min_timer >= 35000)
		{
			min_timer = 0;
			battery_percent = battery_stats();
			if(battery_percent < 5)
			{
				printf("Warning: battery is low! System shutdown in 30 seconds!\n");

				for(int i=0; i<30; i++)
				{
					digitalWrite(Green_LED,0);
					digitalWrite(Yellow_LED,1);

					delay(500);

					digitalWrite(Green_LED,1);
					digitalWrite(Yellow_LED,0);

					delay(500);
				}
				shutdown();
			}

			record_toggle(); //checks if recording, stops and restarts recoring if true -> prevents recording from stopping
		}	
		delay(1);
		min_timer++;

	}
}
