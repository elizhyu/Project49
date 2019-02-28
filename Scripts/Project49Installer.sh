#!/bin/bash

#This is the script that runs all the installations and sets everything up
#This has to be run with sudo ./Project49Installer.sh


echo "Running the main update/upgrade"
chmod +x mainUpdater.sh
./mainUpdater.sh
chmod -x mainUpdater.sh

echo "Turning on Camera/I2C/SSH"
chmod +x Utilities.sh
./Utilities.sh
chmod -x Utilities.sh

echo "Adding Networks"
chmod +x Networks.sh
./Networks.sh
chmod -x Networks.sh

echo "Removing old installations"
chmod +x Remover.sh
./Remover.sh
chmod -x Remover.sh

echo "Installing wiringPi"
chmod +x wiringPiInstaller.sh
./wiringPiInstaller.sh

echo "Installing picam"
chmod +x piCamInstaller.sh
./piCamInstaller.sh

echo "Making the C program"
chmod +x ./Maker.sh
./Maker.sh
chmod -x ./Maker.sh


#we have to reboot to complete the changes
reboot
