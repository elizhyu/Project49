/**************************************************************************
Built off the newledPi.c found on github: https://github.com/RagnarJensen/PiLEDlights/blob/master/netledPi.c

Changes were made to just extract the portions needed and then created a header file so that we can use it to call over in the main function
 */

#include "NetworkChecker.h"
#include "Init.h"

/* Reread the netdevices file */
int activity(FILE *netdevices) {
        static unsigned int prev_inpackets, prev_outpackets;
        unsigned int inpackets, outpackets;
        unsigned int device_inpackets, device_outpackets;
        int found_inpackets, found_outpackets;
        int result;
        char *ptr;
        char device[32];
        int inpacketdif, outpacketdif;

        /* Go to the beginning of the netdevices file */
        result = TEMP_FAILURE_RETRY(fseek(netdevices, 0L, SEEK_SET));
        if (result) {
                perror("Could not rewind " NETDEVICES);
                return result;
        }

        /* Clear glibc's buffer */
        result = TEMP_FAILURE_RETRY(fflush(netdevices));
        if (result) {
                perror("Could not flush input stream");
                return result;
        }

        /* Extract the I/O stats */
        inpackets = outpackets = 0;
        found_inpackets = found_outpackets = 0;
        device_inpackets = device_outpackets = 0;
        while (getline(&line, &len, netdevices) != -1 && errno != EINTR) {
                ptr = line;
                while (*ptr == ' ') ptr++; // Skip leading spaces
                if (sscanf(ptr, "%s %*u %u %*u %*u %*u %*u %*u %*u %*u %u %*u %*u %*u %*u %*u %*u", device, &device_inpackets, &device_outpackets)) {
                        if(strstr(device, "lo:")) continue; // Skip loopback interface
                        found_inpackets++;
                        found_outpackets++;
                        inpackets += device_inpackets;
                        outpackets += device_outpackets;
                }

        }
        if (!found_inpackets || !found_outpackets) {
                fprintf(stderr, "Could not find required lines in " NETDEVICES);
                return -1;
        }

        inpacketdif = inpackets - prev_inpackets;
        outpacketdif = outpackets - prev_outpackets;

        /* Anything changed? */
        result = (prev_inpackets  != inpackets) ||
                 (prev_outpackets != outpackets);
        prev_inpackets = inpackets;
        prev_outpackets = outpackets;
        //printf("%d    %d     %d\n",inpacketdif,outpacketdif, result);


        return result;
}


//function that checks the activity, and then sends the result to led, renamed to NetworkLedChanger
int NetworkIndicator(void)
{
/* Open the netdevices file */
    FILE *netdevices = NULL;

    netdevices = fopen(NETDEVICES, "r");
    if (!netdevices) {
            perror("Could not open " NETDEVICES " for reading");
        }

    delay(o_refresh);  //theres a number            
    int status = activity(netdevices);
    if (status == 1) 
        digitalWrite (o_gpiopin, LOW);  //reverse logic
    else
        digitalWrite (o_gpiopin, HIGH); //reverse logic

    return status;   
        
    
}
