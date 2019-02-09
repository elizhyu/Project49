#!/bin/bash

#This is the script that runs all the installations and sets everything up

echo "Running the main update/upgrade"
./mainUpdater.sh

echo "Installing wiringPi"
./wiringPiInstaller.sh

echo "Installing picam"
./piCamInstaller.sh

