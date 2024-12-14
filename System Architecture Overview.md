# introduction to problem 

## Collage study 
in school you are expected to  do 2 to 4 year making it about 80% of SET knowledge 
this is not possible so  in SET we compress the time 
in the start of the course people  send message saying that they want to be front end back end but in the end we need to learn full stack to get the overview of software development like how doctor need to be Da khoa first in all flied 
![[Drawing 2024-06-19 09.38.22.excalidraw|500]]
when a full stack engineer reach their senior year that will when they specialize into one single 
you are a web concept (net centric programmer) this mean that you
## think that matter when creating an application 
focus on multiple language does not mean more scaling 
- language speed may be different in some language but does not affect overall performance 
- speed up diff in 10 millisecond is not noticeable 
what really matter when creating a system  
- Good maintenance  
- UX 
- UI

# backend 
## API (application programming interface)  

![[3 tier architect 2024-06-19 09.42.56.excalidraw|700]] 
GUI(graphical user interface )  the client side of the application 
API is used in embedded + mobile development  , API is used to control the GUI of an application  
### how client and server communication work 
the communication  between client and backend server act like a mail service 

### API servers and webserver 
API server help with client side communication 
webserver  is place that store a lot of resources file such as html and CSS
- webserver is already configure if you add in dependency like framework and library 
API server return data think of it like JSON or database data for the most part, while webserver return HTML CSS and javascript   
this is because computer think similar to human do in  a way, they used verb and word 
![[machine understanding 2024-06-19 10.41.37.excalidraw]]
human used verb and word to understand each other while machine used protocol and syntax , one such protocol is the [[HTTPS Protocols]](Hyper Text Transfer Protocols)

![[Drawing 2024-11-20 17.47.32.excalidraw]]
## database server 
the database server have two main components , first is the data second is the application or program that manage that data 

## Different between server and host  

Host is like your computer at home , when people say local host it really mean local computer. Host can contain many different type of servers  
an AWS region is not a host but a collection of host that have many different server on each host 
![[Drawing 2024-11-20 loadbalancer]]
- in scenario 1 there can be 1 host due to the lack of finance 
- in scenario 2 there can be multiple host 



## key principles in API  
- stateless  
	- it does not save the user data or the user state , an example of a state full API is Facebook , Facebook cache the user data then send let the user log back without needing to re enter the credential again 
- cacheable (cache hit)
benefit Flexible , Scalable 
- Flexible meaning any computer OS  or  hardware can run the API 
- Scalable meaning that the API can be call several time without error 
# Different Type of Rendering ,Server Communication 
think can be hard on the CPU and RAM 
- CPU is like a car motor
	- the faster the CPU the faster the car(computer  )
- RAM is like a car tank 
	- the web have suck many information or data it is store in the RAM 
Server communicate with client can be affected by : 
- bandwidth  $\rightarrow$  Package that can transfer over the internet like truck that can only load a fix amount 
- CPU $\rightarrow$ package loaded on to the  truck(bandwidth) in the closest 
- RAM storage house 




## how google work 
![[Top 10 server 2024-06-19 17.48.50.excalidraw | 5000]]
google work is simplify into different 3 stage the user type in a query , which in turn call for the http request of google the google backend will get the data in the database bases on the query information then show the top 10 to the application user 


## Client side render
where the client communicate with both the Web API and Web Server 
an example of client side render is youtube , when you render the client side you will see an empty html page that will show scaffold layout containing HTML + CSS + Javascript 
![[Drawing 2024-06-19 18.15.49.excalidraw]]
here the client is responsible for both loading the data from the API and showing the page to the end user  

## Server side render 
an example of server side is ecommerce website  
![[Drawing 2024-06-19 17.57.52.excalidraw]]
here the webserver is an intermediate that is responsible for loading  the page for the user in html and css and also adding data thought that page with the API , it does this by getting the data from the API first then an operation call hydrate to load and show the page to the user 
think of the web sever like  an empty basket with , The API transfer the items into the webserver then the hydrate process will load the items into the basket  then the basket is send back to the user 

## how SEO(export search engine) work 

these search engine work on the benefit that benefit them - scarp all the html and css  -> organize the info -> then rate the website 
## Advantage of client side and server side render 

| Client Side                                                                                                    | Server Side                                                                               |
| -------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| beneficial for the owner server due to the fact that all loading and computation is created on the client side | beneficial for the SEO algorithm due to the fact that it require 2 operation instead of 1 |
| loading for the client is slower on the initial load then the Server side                                      | loading is quicker when compare with client side                                          |
| string in the search bar with that have # is client side                                                       | # without is server side                                                                  |








