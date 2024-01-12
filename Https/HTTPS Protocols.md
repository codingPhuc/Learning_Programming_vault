


# Local Area  Network (LAN) 
- is computer networking accoss multiple local network 
- continenen is connected to different ocean cable 
- the resond the internet was able to work so quickly is because there are fiber obtic cable it travel in the speed of light 
- 
# What is  HTTP  ? 
hinh 2 
- hyper text transfer protocol is a set of rule that the computer is  a set of rule that tell the computer how to comunicate to each other 
- HTTP is a stateless protocol meaning that there is no maintain connection 
- 3 parts to  the Request/Response Message 
- HTTP is a TCP/IP based application layer communication protocol that standardizes how client and servers communicate with each other. 
- It is an abstract layer because it standardizes how host communicates . HTTP depend on TCP/ID to get request and responses between the client and server 
- HTTP used port 80 
- layer 7 protocol (application layer) right at the top in the OSI layer 
- light weight https is very light weight 
## how HTTP work ? 
- the client computer is the computer that host the website 
- the server is a computer that give a response  
- when the client server send a request to the server it will send a request then the server can then send a status code back bases on the information in the server 
- there are 5 different type of HTTP Status code : 
- 1xx Information : 
- 2xx Success  : 
- 3xx Redirection 
- 4xx Client Error : 
- 5xx Server Error :
## Exercise 
- open up fire fox 
- go to a website 
- click on the inspect 
- then click on the network tab 
- you can see that there are a lot of different working of http 
# What is HTTPS  ? 
- HTTPs is a http tranfer protocol but it used ssl connection 
- the attacker that want you hack your computer can get the type of data what type of status code the data have but cannot access the data due to encryption 
- HTTPS is more secure than http 
- it used [[SSL]]/TLS encryption 
- it is a layer 4 protocol 
- Heavier than http 
- HTTPs is used port 443 
## how does data tranfer work in HTTPs 
![[https data tranfer.jpg]]

1. a respond is first send by the server with a public key to the client computer 
2. the client computer used the public key to encrypt the session key 
3. the server then used the private key to decrypt the session key 
4. a session between client and server is open 

## the composition of HTTP 
picture 1 

- the start line can include the three different potion ,Method is how the request is being put togheter ,  Target the target of the request , the Version the version of the HTTP 
- the Header information about the resource that the server send back 
- the Body the resource requested  
