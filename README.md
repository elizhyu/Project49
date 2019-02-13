# Project49

Purdue Senior Design - Wearable headset  

git clone https://github.com/jpats523/Project49.git  

How to set everything up  
1)git clone https://github.com/jpats523/Project49.git  
2)cd Project49  
3)cd Scripts  
4)chmod +x Project49Installer.sh  
5)./Project49Installer.sh  
*Note - there may be a notification about not being able to delete a directory. That's there on purpose to handle an error where sometimes the directory doesn't get made correctly so it deletes to it and the picam program will then recreate the directories after it gets run again"  
  
How to use the testing script program: chmod+x TestScript.sh  
1)chmod+x TestScript.sh  
2a)./TestScript.sh 10 will run the recording for 10 seconds. It needs to have an input # with a space after sh  
2b)./TestScript.sh 60 will run the recording for 1 minute  
It will always loop for 10 times - that's what our test plan says. There is a delay of 2 seconds between each recording  



