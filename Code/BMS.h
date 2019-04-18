/*
Regitster definitions for TI bq27750
Lower byte holds LSB data
Upper byte holds MSB data
Performing a 16 bit read starting at lower byte will return complete value
*/


#include <stdio.h>
#include <wiringPi.h>	
#include <wiringPiI2C.h>
#include <stdlib.h>

int battery_stats(void);

#define BMS_I2C_ADDRESS     0x55

#define MAC_REG             0x00
#define AT_RATE_TIME        0x04
#define AVG_CURRENT         0x14
#define AVG_TIME_REM        0x16
#define AVG_TIME_TO_FULL    0x18
#define DESIGN_CAPACITY     0x3C
#define STATE_OF_CHARGE     0x2C
#define BATT_VOLT           0x08
#define INT_TEMP_K          0x28
#define DES_CAP             0x3C

#define ALT_MAN_ACCESS      0x3E
#define MAC_DATA            0x40
#define MAC_DATA_LENGTH     0x61

