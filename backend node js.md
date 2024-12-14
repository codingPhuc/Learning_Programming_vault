backend nodejs different properties 
-  Blocking 
- single thread 
- fast 
- light weight 
CPU : 4 cores 8 threads 
	  6 cores 12 threads 
cores is for processing different loop 

![[drawing .excalidraw]]


core is used to process task one at time cacualting only one calculation , thread run parallel with each other  communicating with a bus 

# different math calculation for a  processor 


![[different math calculation.excalidraw]]
we see that CPU is better for math calculation for number that do not have a direction and number that do have a direction 
GPU is better for multiple dimension math 


# node js is single thread 

## different architecture 

![[blocking.excalidraw]] 
- blocking is when multiple task  run at the same time 
	- this can cause memory or resource allocation 
![[single thread in nodejs.excalidraw]] 
- when one note break the other will stop 
	- it help with and take up less processing 
	- danger of breaking the whole application 



![[single thread in nodejs.excalidraw]]
node js is single thread meaning that it only will break if a task crash also that it take up less processing space 


when nodejs hit an event if the event is big it will make a another thread on a different node to process that event , if the task is small it will try to process it 
- event are user input that is handle by the callback function 
- think of event like a button in winform who code only execute when interaction event is meet 


![[Drawing 2024-08-12 19.48.00.excalidraw]]