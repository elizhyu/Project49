//Intilize file for Senior Design Project

#include "Init.h"
#include "RecordStream.h"


void Init_Ports(void)
{
	system("sudo pkill picam");	//just in case it's running

	delay(100);
	
	system("sudo rm -r ~/picam/rec/tmp -f");
	delay(100);
	
	//this is needed to run all of the things from wiringPi
	//wiringPiSetup();	

	//recording status LED: RED
	pinMode(record_LED,OUTPUT);	//sets it as output

	//software status LED: GREEN
	pinMode(software_status_LED,OUTPUT);

	//wireless status LED: BLUE
	pinMode(wifi_LED,OUTPUT);	//Setting as Output

	//stream LED: YELLOW
	pinMode(stream_LED,OUTPUT);	//Setting as Output

	//record start/stop button: PB_2
	pinMode(record_button,INPUT);	//Setting as Input

	//stream start/stop button: PB_1
	pinMode(stream_button,INPUT); //Setting as Input

	//shutdown_button: PB_3
	pinMode(shutdown_button,INPUT); //Setting as Input

	/*INTERUPTS (going to move these to the intialized buttons)*/
	//wiringPiISR(record_button,INT_EDGE_FALLING, start_up_lights);
	//wiringPiISR(shutdown_button,INT_EDGE_FALLING, start_up_lights);
	//wiringPiISR(stream_button,INT_EDGE_FALLING, start_up_lights);

	wiringPiISR(record_button,INT_EDGE_FALLING, rec_button);	//sets the record button to the record button function

	wiringPiISR(shutdown_button, INT_EDGE_FALLING, shutdown);//shuts down 	the Pi when the the button is pressed (FALLING EDGE)

	wiringPiISR(stream_button, INT_EDGE_FALLING, toggle);
	
	//not sure what the plans for streaming are currently
}

void start_up_lights(void)
  {
    digitalWrite (Green_LED, 0) ;	// On
    delay (100) ;               	// 100 mS
    digitalWrite (Green_LED, 1) ;	// Off
    delay (100) ;					// 100 mS
    digitalWrite  (Yellow_LED, 0); 	//On
    delay (100);					// 100 mS
    digitalWrite (Yellow_LED, 1);	//Off
    delay (100);					// 100 mS
    digitalWrite  (Red_LED, 0);   	 //On
    delay (100);					// 100 mS
    digitalWrite (Red_LED, 1);		//On
    delay (100);					// 100 mS
    digitalWrite  (Blue_LED, 0);  	//On
    delay (100);					// 100 mS
    digitalWrite (Blue_LED, 1);		//Off
    delay (100);					// 100 mS
  }

void Init_Server(void)
{
	chdir("/home/pi/node-rtsp-rtmp-server");
	system("./start_server.sh &");
	for(int i =0; i<150;i++)
	{
		start_up_lights();
	}

	chdir("/home/pi/picam");	//NEED TO CONFIRM

	system("./picam --time --rtspout --rotation 270  --alsadev hw:1,0 -w 1280 -h 720 -v 0 -f 24 --shutter 14000 &");


}

void Init_PiCam(void)
{
	//NOTE: if we want to be able to change the parameters from the PC client we will need to make the numerical values into variables
	//change the directory

	//Init_Server();

	chdir("/home/pi/picam");	//NEED TO CONFIRM

	
	//Initalizes picam software
	system("./picam --time --rotation 270  --alsadev hw:1,0 -w 1280 -h 720 -v 0 -f 24 --shutter 20833 &");

	//old one with the rstp server
	//system("./picam --time --rtspout --rotation 270  --alsadev hw:1,0 -w 1280 -h 720 -v 0 -f 24 --shutter 14000 &");
}



