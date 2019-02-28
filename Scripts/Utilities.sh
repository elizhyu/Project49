#!/bin/bash

#This script will turn on Camera/I2C/SSH

#enable I2C 
echo '>>> Enable I2C'
if grep -q 'i2c-bcm2708' /etc/modules; then
  echo 'Seems i2c-bcm2708 module already exists, skip this step.'
else
  echo 'i2c-bcm2708' >> /etc/modules
fi
if grep -q 'i2c-dev' /etc/modules; then
  echo 'Seems i2c-dev module already exists, skip this step.'
else
  echo 'i2c-dev' >> /etc/modules
fi

#Turn on dtparam=12c1, not sure if it's needed already tho
if grep -q 'dtparam=i2c1=on' /boot/config.txt; then
  echo 'Seems i2c1 parameter already set, skip this step.'
else
	echo "" >> /boot/config.txt
	echo 'Some parameter for I2C' >> /boot/config.txt
	echo 'dtparam=i2c1=on' >> /boot/config.txt
fi


#rewrite the code to reflect how I want it
if grep -q '#dtparam=i2c_arm=on' /boot/config.txt; then
	sed -i "s/#dtparam=i2c_arm=on/dtparam=i2c_arm=on/g" /boot/config.txt
        echo "I2C turned on in boot"
elif grep "dtparam=i2c_arm=off" /boot/config.txt
then
        sed -i "s/dtparam=i2c_arm=off/dtparam=i2c_arm=on/g" /boot/config.txt

else
	sed -i "s/#dtparam=i2c_arm=on/dtparam=i2c_arm=on/g" /boot/config.txt
        echo "I2C turned on in boot"
fi

#Another I2C thing needed
if [ -f /etc/modprobe.d/raspi-blacklist.conf ]; then
  sed -i 's/^blacklist spi-bcm2708/#blacklist spi-bcm2708/' /etc/modprobe.d/raspi-blacklist.conf
  sed -i 's/^blacklist i2c-bcm2708/#blacklist i2c-bcm2708/' /etc/modprobe.d/raspi-blacklist.conf
else
  echo 'File raspi-blacklist.conf does not exist, skip this step.'
fi
 
# install i2c-tools
echo '>>> Install i2c-tools'
if hash i2cget 2>/dev/null; then
  echo 'Seems i2c-tools is installed already, skip this step.'
else
  apt-get install -y i2c-tools
fi

#Enable SSH
systemctl enable ssh
systemctl start ssh


#Enable the camera
grep "start_x=1" /boot/config.txt
if grep "start_x=1" /boot/config.txt
then
        echo "Camera is already set up"
elif grep "start_x=0" /boot/config.txt
then
	sed -i "s/start_x=0/start_x=1/g" /boot/config.txt
	echo "Camera is initialized" 
else #not already set up and no start_x=0
	echo "" >> /boot/config.txt
	echo "#Adding the camera functions" >> /boot/config.txt
	echo "start_x=1" >> /boot/config.txt
	echo "Camera is initailzed"
fi

#reboot

