
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

	else
		digitalWrite(record_LED,1);
}

void rec_button(void)
{
	delay(10);	//for coding debouncing
	//printf("Record/Stop Button Pressed");	
	FILE *rec_file;	//creates the pinter used to read
	//Is recording right now
	if(is_recording() == true)	//we are going to stop recording and turn off light[make it a 1]
	{
		rec_file = fopen("/home/pi/picam/hooks/stop_record", "w");	//opens the file

		fclose(rec_file);	//closes the file
		
		do
		{
			digitalWrite(record_LED,1);
		}while (digitalRead(record_LED) == 0);

		do
		{
			digitalWrite(Green_LED,0);
		}while (digitalRead(Green_LED) == 1);
		//digitalWrite()
		//digitalWrite(record_LED, 1);	//turns off the recording LED (Negative logic?)
		//digitalWrite(record_LED,1);	//turns off the recording LED -> would be better to call isRecording() here to actually check the status
	}
	//stream_resume();
	else
	{

		rec_file = fopen("/home/pi/picam/hooks/start_record", "w");

		
		fclose(rec_file);

		do
		{
			digitalWrite(record_LED,0);
		}while (digitalRead(record_LED) == 1);

		do
		{
			digitalWrite(Green_LED,1);
		}while (digitalRead(Green_LED) == 0);
		//digitalWrite(record_LED,0);	//turns on the recording LED
	}
	delay(10);
	//set_rec_LED();	//not sure why we need this again
	//set_rec_LED();
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
	//run the start up lights to indicate that it's shutting down?
	start_up_lights();
	//then turn it off
	system("sudo shutdown now");	//not sure if this will work...
}

void toggle(void)
{
	start_up_lights();
}




