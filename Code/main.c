//Main File for Senior Design Projecct

#include <stdio.h>	//Standard library needed
#include <stdbool.h> 	//this allows us to use boolean
#include <wiringPi.h>	//might not need it in the main file
//#include <sys/types.h>
//#include <signal.h>
bool stream_bool = true;	//setting the initial streaming to true
bool wifi_found = false; //flag for checking network activity


#include "Init.h"	//the intialize GPIO 
#include "RecordStream.h"	//the recording functions and sets up the interrupts for the pushbuttons
#include "NetworkChecker.h"
#include "bq27xxx_battery.c"
#include "bq27xxx_battery_i2c.c"

int main(void)
{
	//int checking = kill(697,0);
	//printf("%d", checking);
	wiringPiSetup();
	Init_Ports();	//initilze the GPIO's
	start_up_lights();	//start up light
	//Init_Server();	//sets up the server and runs the lights and then sets up PiCam
	Init_PiCam();	//sets up just PiCam, NO SERVER
	digitalWrite(Green_LED,0);
	//printf("All has been set up");

	//can we not just use the readings as interupts?
	int counter = 0;
	int Networkcounter = 0;
	int wifi_check_freq = 10000;
	while(1)
	{
		if (counter == wifi_check_freq)	//this can be even bigger - do we want any flashes?
		{
			wifi_found = NetworkIndicator();
			counter = 0;
			Networkcounter ++;
			printf("%d\n",Networkcounter );

			if (wifi_found)
				wifi_check_freq = 25000;
			else
				wifi_check_freq = 10000;
		}
		set_rec_LED();
		counter++;
		//printf("%d\n",counter);
		
	}
}


