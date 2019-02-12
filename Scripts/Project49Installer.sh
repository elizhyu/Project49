#!/bin/bash

#This is the script that runs all the installations and sets everything up

echo "Running the main update/upgrade"
chmod +x mainUpdater.sh
./mainUpdater.sh

echo "Installing wiringPi"
chmod +x wiringPiInstaller.sh
./wiringPiInstaller.sh

echo "Installing picam"
chmod +x piCamInstaller.sh
./piCamInstaller.sh

