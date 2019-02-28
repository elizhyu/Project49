
#!/bin/bash

#this is my remover script - allows for a clean install of wiringPi and picam

#takes us home
cd

#removes wiringPi
rm -rf wiringPi

#remove the script make_dirs.sh
rm make_dirs.sh

#remove the binary
rm -R picam-1.4.7-binary
rm -R picam-1.4.7-binary.tar.xz

#remove picam
rm -R picam/
