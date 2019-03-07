
//File for recording and streaming function

#include "RecordStream.h"
#include "Init.h"

bool is_recording(void)


{
	FILE *fo;	//creates the pointer used to read
	fo = fopen("/home/pi/picam/state/record", "r");
	char stat_str = fgetc(fo);	//should pull out the first character in the file
	fclose(fo);	//fo is the file pointer associated with file to be closed

	if(stat_str == 't')
	{
		
		return true;

	}
	else
	{
		//digitalWrite(record_LED,0);	//turn it off? Negative logic?
		return false;
	}


}

void set_rec_LED(void)
{
	if(is_recording())
		digitalWrite(record_LED,0);
		digitalWrite(software_status_LED, 1);

	else
		digitalWrite(record_LED,1);
		digitalWrite(software_status_LED, 0);
}

void rec_button(void)
{
	delay(10);	//for coding debouncing
	FILE *rec_file;	//creates the pinter used to read
	
	//Is recording right now
	if(is_recording() == true)	//we are going to stop recording and turn off light[make it a 1]
	{
		rec_file = fopen("/home/pi/picam/hooks/stop_record", "w");	//opens the file and clears content
		fclose(rec_file);	//closes the file
		
		//ensure that that the record LED gets turned off [setting as 1]
		do
		{
			digitalWrite(record_LED,1);
		}while (digitalRead(record_LED) == 0);

		//ensure green LED gets turned off [setting as 0]
		do
		{
			digitalWrite(Green_LED,0);
		}while (digitalRead(Green_LED) == 1);
	}
	else
	{
		rec_file = fopen("/home/pi/picam/hooks/start_record", "w"); //opens the file and clears content
		fclose(rec_file);//closes the file

		//ensure that that the record LED gets turned on [setting as 0]
		do
		{
			digitalWrite(record_LED,0);
		}while (digitalRead(record_LED) == 1);
		
		//ensure green LED gets turned on [setting as 1]
		do
		{
			digitalWrite(Green_LED,1);
		}while (digitalRead(Green_LED) == 0);
	}
	delay(10);
}

void shutdown(void)
{
	//we need to check if recording
	//if it's recordng we need to shut it down
	//delay a couple seconds to ensure it saves
	FILE *rec_file;	//creates the pinter used to read
	if(is_recording() == true)	//I think this works?
	{
		rec_file = fopen("/home/pi/picam/hooks/stop_record", "w");	//opens the file
		fclose(rec_file);	//closes the file
		delay(3000);
	}
	//run the start up lights to indicate that it's shutting down
	start_up_lights();
	//then turn it off
	system("sudo shutdown now");
}

//function used to test and find pins for push buttons
void toggle(void)
{
	start_up_lights();
}

//5 second recording functions - mapped to the middle button
void test_record(void)
{
	digitalWrite(stream_LED,0);
	system("/home/pi/Project49/Code/fivesec.sh");
	digitalWrite(stream_LED,1);
}

