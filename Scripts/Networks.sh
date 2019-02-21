#!/bin/bash

#This script will add networks right away
#Have to run it as sudo ./Networks.sh
cd

cat > /etc/wpa_supplicant/wpa_supplicant.conf << EOF
ctrl_interface=DIR=/var/run/wpa_supplicant GROUP=netdev
update_config=1
country=US

network={
	ssid=""
	psk=""
	key_mgmt=WPA-PSK
}

network={
        ssid="Carmel Hoods"
        psk="boilerup1"
        key_mgmt=WPA-PSK
}

EOF
chmod 600 /etc/wpa_supplicant/wpa_supplicant.conf
wpa_cli -i wlan0 reconfigure

