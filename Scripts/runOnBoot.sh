#!/bin/bash

#this script will add the main file to the file that allows the program to run on boot
#nned to confirm that this works

echo '#!/bin/sh -e
#
# rc.local
#
# This script is executed at the end of each multiuser runlevel.
# Make sure that the script will "exit 0" on success or any other
# value on error.
#
# In order to enable or disable this script just change the execution
# bits.
#
# By default this script does nothing.

# Print the IP address
_IP=$(hostname -I) || true
if [ "$_IP" ]; then
  printf "My IP address is %s\n" "$_IP"
fi
#    /home/pi/Project49/Code/main
exit 0' > /etc/rc.local
