#!/bin/bash

#this is the preview script for seeing what the camera is seeing

#delete all the things in the folder
rm -rf ~/picam/5sec

#record and set the directory
#echo -e "dir=/tmp" > hooks/start_record
#my best guess
#echo -e "dir=~/picam/5sec" > hooks/start_record

#delay 5 seconds
sleep 5

#stop recording
#hooks/stop_record
