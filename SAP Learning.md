This is to learning about the programming aspect of SAP  
Thing to note about SAP : 
- SAP have a three layer architecture  
- ABAP is included within  SAP as a programming language . When running the SAP code each program will  be compile by the SAP system 
- ABAP have three main part data structure programming database programming and OOP programming   
- SAP can be used on form like GUI or Web 

![[Pasted image 20240625110857.png]] 
- the presentation layer is used to check for when use interact  with the UI 
- application is like a controller of the application 
- database is used to process and retrieve query data 
the procedure to log in into  SAP is bases on different  action : 
[[log in in SAP ]]


## demand for SAP 
there used  to be database specialize in oracle but now all the program and method have switch over to SAP 

# SAP system 

## Deployment Mode
There is three step in development of the application : 
- Developer mode for code testing 
- Beta for a small pool of user 
- Production  for a large scare user setting 

## code for different module 
Code are like ID for running the application : 

- SE38 for running application , and coding act as both an editor and runner only developer can used it 
- SE93 creating the name of the program  
- SE80 for object navigator 
## different approach to SAP  
![[Drawing 2024-06-25 11.22.57.excalidraw]]

B1 Sap : 
- B1  code written in C# is used like a controller to specify and take data from the application 
A1 Sap : 
- used SAP own interacted language like ABAP to act as a controller 
## SAP system process    for different user  
![[Pasted image 20240625112852.png]]
As a SAP developer we will be going thought all the stage of development ,but we focus on these cross client customizing : 
- FI 
- CO 
- MM 
- CD 
in of a client like different branches on github , one branch can have different  type of configuration database changes and operation , developer of SAP work on the main branch to maintain code and built program for the user.
An example : 
think of client 100 as sale team they used the SAP GUI interface the most , the 200 is another team that have access to money and transaction on the SAP system. It would be the best practice if the sale team does not have data access to the transaction team so there will be different client account for different access 

## transport request 
let say we build a program that 
```
select * from database 
```
we then package this program to a file ship the file to google drive it will give us a link that we can share with the user this practice is call transport request .Sharing of package between different client 



## system compilation 
![[Pasted image 20240625130309.png]] 



variant is region that reside
# Question to ask 

Z<PA_ID> take in the Application area / Sub module? 
Z<WRICEF_ID> how is it created , related to Development type table 
each WRICEF development is to have its own package under a Process Area package ? what is a WRICEF development 

CAN a function have the same name in multiple program 
how to find the transport package name when you add a program to  a package 





## code to learn  from  

# project building to understand SAP 
## syntax project 
[[building project]]
## SQL project



## OOP project 




