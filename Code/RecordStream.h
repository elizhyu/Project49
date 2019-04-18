
#include <stdio.h>
#include <wiringPi.h>	//http://wiringpi.com/download-and-install/
#include <stdlib.h>
#include <string.h>
#include <stdbool.h> 	//this allows us to use boolean
#include <unistd.h>
#include "Init.h"


//Functions
bool is_recording(void);	//checks if it's recording or not
void rec_button(void);	//start stop button
void shutdown(void);	//shuts down the pi
void set_rec_LED(void);
void toggle(void);
void test_record(void);
void record_toggle(void);
