#!/bin/bash

cd
cd Project49
cd Code
cd -B
#./main

#doesn't work
declare -i time_left

for i in {1..10}
do
  #doesn't work
  time_left = 10-#i
  echo Recording: $i/10
  #touch hooks/start_record
  sleep $1
  #touch hooks/stop_record
  sleep 2
  echo Time remaining:
done
echo Done
