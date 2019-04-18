#include <stdio.h>
#include <wiringPi.h>	
#include <wiringPiI2C.h>
#include <stdlib.h>
#include "BMS.h"

int battery_stats(void)
{
    int BMS_fd = wiringPiI2CSetup(0x55);
    FILE *fp = fopen("/home/pi/Project49/execution_data/battery_info.txt", "w+");

    int VOLT = wiringPiI2CReadReg16(BMS_fd, BATT_VOLT);
    int TIME = wiringPiI2CReadReg16(BMS_fd, AVG_TIME_REM);
    //int intTemp = wiringPiI2CReadReg16(BMS_fd, INT_TEMP_K);
    int SOC = wiringPiI2CReadReg16(BMS_fd, STATE_OF_CHARGE);
    //int current = wiringPiI2CReadReg16(BMS_fd, AVG_CURRENT);

    printf("\nVOLT printout: %d\n", VOLT);
    printf("TIME printout: %d\n", TIME);
    //printf("INT_TEMP: %d\n", intTemp);
    printf("PERCENT: %d\n\n", SOC);
    //printf("AVG current: %d\n", current);

    fprintf(fp, "%d %d", SOC, TIME);
    fclose(fp);

    return SOC;
}
