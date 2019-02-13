
#!/bin/bash
#How to use: chmod+x TestScript.sh
#./TestScript.sh 10 will run the recording for 10 seconds 
#It will always loop for 10 times - that's what our test plan says

cd
cd Project49
cd Code
make -B
#./main

declare -i time_left
declare -i loop_left
declare -i loop_time
declare -i loop_max
declare -i min
declare -i sec_helper
declare -i sec

loop_time=$(($1+2))

for i in {1..10}
do
	loop_left=10-$i+1
	
	time_left=$loop_left*$loop_time
	echo Recording: $i/10. Recording length $1 seconds
	echo Time Remaining:
	if [ $time_left -ge 60 ]; then
		min=$time_left/60
		sec_helper=60*$min
		sec=$time_left-$sec_helper
		echo $min min $sec seconds
	else
		echo Time remaining:$time_left seconds
 	fi
	touch hooks/start_record
	sleep $1
	touch hooks/stop_record
	sleep 2
done
echo Done

