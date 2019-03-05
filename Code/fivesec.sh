#!/bin/bash
#creates a 5 second recording named preview.sh and puts it in the preview folder inside of picam

#remove any files inside the preview folder
rm -r /home/pi/picam/preview/*.ts

#start recording
echo -e "dir=/home/pi/picam/preview\nfilename=preview.ts" > /home/pi/picam/hooks/start_record

sleep 5

#stop recording
touch /home/pi/picam/hooks/start_record
