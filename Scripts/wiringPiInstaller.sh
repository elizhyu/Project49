#!/bin/bash

#This script installs wiringPi

#In case git isn't installed
sudo apt-get install git-core

cd
git clone git://git.drogon.net/wiringPi

cd ~/wiringPi
git pull origin

cd ~/wiringPi
./build
