#define NETDEVICES "/proc/net/dev"


#define _GNU_SOURCE

#include <argp.h>
#include <signal.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include <unistd.h>
#include <wiringPi.h>
#include "Init.h"


static unsigned int o_refresh = 20; /* milliseconds */
static unsigned int o_gpiopin = Blue_LED;
static int o_detach = 0;

static volatile sig_atomic_t running = 1;
static char *line = NULL;
static size_t len = 0;

int activity(FILE *netdevices);
void NetworkLedChanger(int on);
int NetworkIndicator(void);
