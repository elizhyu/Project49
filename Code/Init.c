//Intilize file for Senior Design Project

#include "Init.h"
#include "RecordStream.h"


void Init_Ports(void)
{
	system("sudo pkill picam");	//just in case it's running

	delay(100);
	
	system("sudo rm -r ~/picam/rec/tmp -f");	//this is to prevent a possible error with the folder
	delay(100);

	//recording status LED: RED
	pinMode(record_LED,OUTPUT);	//sets it as output

	//software status LED: GREEN
	pinMode(software_status_LED,OUTPUT);	//sets it as output

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

	wiringPiISR(record_button,INT_EDGE_FALLING, rec_button);	//sets the record button to the record button function

	wiringPiISR(shutdown_button, INT_EDGE_FALLING, shutdown);//shuts down 	the Pi when the the button is pressed (FALLING EDGE)

	wiringPiISR(stream_button, INT_EDGE_FALLING, test_record);
}

void start_up_lights(void)
  {
	//turn off lights first

	digitalWrite (Green_LED, 1) ;	// Off
	digitalWrite (Yellow_LED, 1) ;	// Off
	digitalWrite (Red_LED, 1) ;	// Off
	digitalWrite (Blue_LED, 1) ;	// Off
	
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

	chdir("/home/pi/picam");	//change directory to go to picam
	
	//starts up picam - this version does not do any error checking
	system("./picam --time --rotation 270  --alsadev hw:1,0 -w 1280 -h 720 -v 0 -f 24 --shutter 20833 &");	
}

void Updated_Init_PiCam(void)
{
	const char errorholder[10] = "error";
	//char *errorholder = "error";
	int ret;
	int find_result = 0;
	int goodToGo = 0;

	//File pointer for File I/O
    FILE *fp;

	//clear all of the contents in the file
    fopen("/home/pi/picam/errorfile.txt","w");
    fclose(fp);


	//while everything it not initalized....
	while(goodToGo==0){

		chdir("/home/pi/picam");	//NEED TO CONFIRM


		//Initalizes picam software
		system("./picam --time --rotation 270  --alsadev hw:1,0 -w 1280 -h 720 -v 0 -f 24 --shutter 20833 > errorfile.txt 2>&1");

		//character array to store string
		char str[200];
		fp = fopen("/home/pi/picam/errorfile.txt" , "r");

		//check and see if there are any things showing "errors"

		while(fgets(str,200,fp)!=NULL) {
			if((strstr(str,errorholder)) != NULL) {
				find_result = 1;
				break;
			}
		}
		//close the file
		fclose(fp);

		//there was an error found....
		if(find_result == 1){
			for(int i=0; i>5;i++)
			{
				digitalWrite (Green_LED, 0) ; //on
				digitalWrite (Yellow_LED, 0) ;	//on
				digitalWrite (Red_LED, 0) ;	//on
				delay(500);	//delay 0.5 seconds
		        digitalWrite (Green_LED, 1) ;	//off
		        digitalWrite (Yellow_LED, 1) ;	//off
		        digitalWrite (Red_LED, 1) ;	//off
		        delay(500);	//delay 0.5 seconds

			}
			find_result=0;	//reseting this flag variable back
		}
		
		else {
		//there was no match, everything is ready to go
		goodToGo = 1;
		}

		//clear all of the contents in the file
		fopen("/home/pi/picam/errorfile.txt","w");
		fclose(fp);
	}
}

