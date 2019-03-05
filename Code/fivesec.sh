#!/bin/bash
#creates a 5 second recording named preview.sh and puts it in the preview folder inside of picam

echo -e "dir=/home/pi/picam/preview\nfilename=preview.ts" > /home/pi/picam/hooks/start_record

sleep 5

touch /home/pi/picam/hooks/start_record
