# Summarization  
-  **Developing a social network app using ASP.NET Core and React JS**   
-  application  is a social   network  app similar  to reddit instagam  and facebook  
- the user of the app can create and manage post   
- the user of the app can interact with other user 
- user can customize there post and profile  
- and chat  with other user  using a group chat or talk to them directly with single chat 
- the application  uses react frontend  using  the prime  library for it main interface 
- the backend using  ASP.net core  for   the creation  of  a management server for controlling the flow of request made by the client server 
- this result  in an social media application that have not only a great UI  provided by the react prime library but also  smooth  and secure data protection and operation  due  too the used of  ASP.NET CORE  indetity framework 
	- this result in a social media application  with  an interactive and great UX and UI with the help of prime react but also  help with a  secure  information flow between front and backend  
	-  the convergence of React  JS and ASP.NET have resulted  in  the creation of  a social media application with a coordinated information flow and  an exceptional UI/UX experience 

A SOCIAL NETWORK  APPLICATION FOR CONNECTIVITY  AND IMAGE SHARING 
AN SOCIAL MEDIA APPLICAITON FOR POST SHARING EMPHASIZING CONNTECTIVITY AND BUILDING  RELATIONSHIP  WITH FRIEND  
SOCIAL NETWORK AP


# Chapter 1  

## Justifying topic  choice 
Introduction: Context and Importance  : 
1. In   Today interconnected world require a high deal  of communication , friend and family have the ability to connect with each other over  a wide range of distances combating loneliness   
2. peoples  are receiving much  more information and knowledge thought  a wider range of medium  then they were before 
3. but that  doesn't  mean that the information being receive is informative  ,  disinformation  that can potentially cause  harm depending on  how it can be perceived by the individual 
Problem Statement: Challenges with Current Attendance Practices  : 
1. social media platform have a large and interconnected database  of  post and user and need to be build on a foundation of both flexibility and  growth  
2. the information  being posted on social media need  to be flexible  to adjust to each user need and  maintainable to prevent bad actor  from creating a hostile  environment for other user 
Existing Solutions: Technological Efforts  
1.  social media app and website like that of Facebooks and Instagram  have  created an environment that encourages  user to  stay engaged with the latest trend  and connect  with   their  friend  personal discovery   
2. these application  help user find their own  hobby and interest helping  them  discover  wide variety of  communities 
Limitations of Current Solutions  : 
1. these social media website although vast in functionality  is not adjustable to their  user preference in  a specific  location like Vietnam for example 
2. these UI/UX  design   are not tailor  to the preference  and cultural  nuances of the Vietnamese user ,  causing a less intuitive user experience due to the culture crash 
Proposed Solution: Innovative Attendance Application  
1. The UI/UX   will be customized to  meet the preferences of the Vietnamese user . Additionally , incorporating features  enhancing Vietnamese user need  and cultural  expectation 
2. This will make the social  media app  more user friendly for   Vietnamese user  , creating a social  tie , a sense of   national proudest , and   creating a more  comfortable  experience  for them  

Primary Goal 
1. Provide a social  network  application that is tailor for the specific experience of Vietnamese user,  to post and share their experiences  and maintain  their connection thought the messaging chat features  
**System Design**:  
 1. the system  is optimize to account for any customization preferences by the user. For example,  user can choose who they want to share the post with, what group  of friend would the user prefer when sharing the posts,  and which post the user will save for latter viewing 
 Data Security and Integrity : 
 1. The data store in the application  backend services is securely protected by ASP.NET core identity frame implementing the authorization  and  authentication method deciding what user can and cannot do  
 2. these protection barrel help with keeping users account protected from bad actor that have the intention to exploit their account vulnerability  
Additional Features  : 
1. their will be advance communication feature like creating and managing group chat  , assigning role and user privilege  in each group chat 
2. allow moderator to monitor user activity  and detect bad actor in  the system \


- **Google.Apis.Auth**
- **Google.Apis.Gmail.v1**
- **Microsoft.AspNetCore.Authentication.JwtBearer**
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore**
- **Microsoft.AspNetCore.OpenApi**
- **Microsoft.EntityFrameworkCore**
- Entity Framework is an open-source [ORM framework](https://en.wikipedia.org/wiki/Object-relational_mapping "Object-relational Mapping") for .NET applications supported by Microsoft. It enables developers to work with data using objects of domain specific classes without focusing on the underlying database tables and columns where this data is stored. With the Entity Framework, developers can work at a higher level of abstraction when they deal with data, and can create and maintain data-oriented applications with less code compared with traditional applications.
- t eliminates the need for most of the data-access code that developers usually need to write
- **Swashbuckle.AspNetCore**
- **System.IdentityModel.Tokens.Jwt**
- **JWT**

- **@fortawesome/fontawesome-svg-core**
- **@react-navigation/native**
- **@vitejs/plugin-react**
- **axios**
- **date-fns**
- **eslint**
- **primereact**
- **react**
- **react-dom**
- **react-router-dom**
- **typescript**
- **vite**
- **zustand**
GitHub.

Vite 


# REACT 
- react make it simple  for UI creation 
- react  will render just the right component when your page  state change bases on the data 
- since  component data  is written in Javascript instead of templates , you can pass rich data thought your app and keep state out of the Dom 
- react principle  is  learn one write any where 
- - when a component state and prop changes instead of changing the entire DOM  react used a virtual DOM which is a light copy of the real DOM to be the initial foundation of the changes then used a diff algorithm to optimize the update to the real DOM   
## JSX
- the language that we used in our project to write react is TSX script TSX is similar to JSX in react that  it is an extension of javascript taht also come with the full power of  ES6  
- TSX help with the separation of concern by  combine  markup with  typescript logic in sperate file  
- you can put any Typescript or Javascript expression using a {} between  markup 
## component 


![[Pasted image 20250119090456.png]]
- build encapsulate component that manage their own state , then compose them to create complex UI 
- an independent  , reusable  building block in react that tell react what to display on the screen 
- component manage the output render in the DOM 

- a component accept and input call prop  and  return  react element describing the UI  

## prop 
- prop are object that  are declare in the react component agrument to accept from it parent component 
- every parent component  can pass information to it child component  using prop
- ![[Pasted image 20250119090404.png]]
## state 
- state can also be pass as prop  
![[Pasted image 20250119090424.png]]
- react have a build in state object when the state object change the component rerender 
- state is used to contain data and information about a component 
- state can be pass down or move up to a  parent or ancestor component 


# Prime react 
- PrimeReact is a rich set of open source UI Components for React. See [PrimeReact homepage](https://primereact.org/) for live showcase and documentation 
-  prime react is open sources 
- 80+ UI components 
- choose from prebuild  themes or design system with the css ligrary of your choice 
- pre build component and themes
- typescript support 
# ASP.NET core 

- ASP.NET Core is a cross-platform, high-performance  web development framework for .NET, , [open-source](https://github.com/dotnet/aspnetcore) framework for building modern, cloud-enabled, Internet-connected apps.
- ASP.NET Core is the open-source version of ASP.NET, that runs on macOS, Linux, and Windows. ASP.NET Core was first released in 2016 and is a re-design of earlier Windows-only versions of ASP.NET.
- Performance is a key focus of ASP.NET Core. It's faster than other popular web frameworks in the independent [TechEmpower benchmarks](https://www.techempower.com/benchmarks/#hw=ph&test=plaintext).
![[Pasted image 20250119121638.png]]
- Built-in [dependency injection](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-9.0).
	-  Dependency Injection (được biệt là DI) là một design pattern khi một đối tượng không được tạo trong các thành phần phụ thuộc vào nó mà yêu cầu nó which is a technique for achieving [Inversion of Control (IoC)](https://learn.microsoft.com/en-us/dotnet/standard/modern-web-apps-azure-architecture/architectural-principles#dependency-inversion) between classes and their dependencies
	- ### Dependency inversion
		- The direction of dependency within the application should be in the direction of abstraction, not implementation details. Most applications are written such that compile-time dependency flows in the direction of runtime execution, producing a direct dependency graph. That is, if class A calls a method of class B and class B calls a method of class C, then at compile time class A will depend on class B, and class B will depend on class C, as shown in Figure 4-1.
	![[Pasted image 20250119143526.png]]
	![[Pasted image 20250119143632.png]]
	- Nó giúp chúng ta đáp ứng tính chất lỏng lẻo (loosely couple), dễ đọc và bảo trì code 
	- Tất cả các service của framework đều được inject khi chúng ta c ần 
	- DI Container là một đối tượng có trách nhiệm tạo các phụ thuộc (**ProductService**) và gán nó cho đối tượng yêu cầu (**HomeController**) nó.
- ASP.NET Core is designed to allow runtime components, APIs, compilers, and languages evolve quickly, while still providing a stable and supported platform to keep apps running.
- Multiple versions of ASP.NET Core can exist side by side on the same server. Meaning one app can adopt the latest version, while other apps keep running on the version they were tested on.

- - The [Model-View-Controller (MVC) pattern](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-9.0) helps make your web APIs and web apps testable. 
	- MVC is a design pattern used to decouple user-interface (view), data (model), and application logic (controller). This pattern helps to achieve separation of concerns.
	- **MVC** (Model-View-Controller) is a pattern in software design commonly used to implement user interfaces, data, and controlling logic. It emphasizes a separation between the software's business logic and display
	- his "separation of concerns" provides for a better division of labor and improved maintenance. Some other design patterns are based on MVC,
	- 1. Model: Manages data and business logic.
![[Pasted image 20250119145620.png]]
1. View: Handles layout and display.
2. Controller: Routes commands to the model and view parts.
	- Create clean model classes and easily bind them to your database. Declaratively define validation rules, using C# attributes, which are applied on the client and server.
	- Using the MVC pattern for websites, requests are routed to a Controller that is responsible for working with the Model to perform actions and/or retrieve data. The Controller chooses the View to display and provides it with the Model. The View renders the final page, based on the data in the Model.
	- ASP.NET gives you a powerful, patterns-based way to build dynamic websites using the MVC pattern that enables a clean separation of concerns.
	- Create clean model classes and easily bind them to your database. Declaratively define validation rules, using C# attributes, which are applied on the client and server.
	- ASP.NET supports many database engines including SQLite, SQL Server, MySQL, PostgreSQL, DB2 and more, 
- ASP.NET Scaffolding is a code generation framework for ASP.NET Web applications. Visual Studio 2013 includes pre-installed code generators for MVC and Web API projects. You add scaffolding to your project when you want to quickly add code that interacts with data models. Using scaffolding can reduce the amount of time to develop standard data operations in your project.
- - [Model binding](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-9.0) automatically maps data from HTTP requests to action method parameters.
- - [Model validation](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-9.0) automatically performs client-side and server-side validation.
## identity  
- securing user data and managing access to various parts of your app is crucial.  
- ASP.NET Core provides a built-in system known as **ASP.NET Core Identity**   which handles **authentication** (verifying who users are) and **authorization** (controlling what users can do in your application). 
- Identity is typically configured using a SQL Server database to store user names, passwords, and profile data. Alternatively, another persistent store can be used, for example, Azure Table Storage
- **ASP.NET Core Identity** is a membership system that adds login functionality to your application. It provides features like: 
- - **User registration** and **login**.
- **Password recovery**.
- **Roles** and **claims-based authorization**.
- Integration with external login providers like **Google**, **Facebook**, and **Twitter**.
- Two-factor authentication (2FA), email confirmation, and more. 
- 1. **Authentication** is the process of identifying the user. It answers the question, _“Who are you?”_
2. **Authorization** comes after authentication and answers, _“What are you allowed to do?”_ For example, an authenticated user might only be authorized to access specific parts of the application.
JWT in ASP.NET core 
- en standard that allows transmitting data between parties as a JSON object in a secure and compact way
- The data transmitted using JWT between parties are digitally signed so that it can be easily verified and trusted.
- simple way to securely transmit information between parties via a JSON object. 
- Verification takes place through a signature. This signature allows only a server that has the key to decode
- In simple terms, tokens are like access keys, with information and a lifetime.
- To make tokens secure, we can encrypt them, so if someone discovers your token, they will not be able to see anything other than a sequence of numbers and letters (hash) like the one below:
- Note that the token is divided by dots (.) where each dot separates each of the three sections of the JWT. In this image, in red is the header, in purple is the payload and in blue is the signature:
- 1. **Header:** The header typically consists of two parts—the token type (JWT) and the signature algorithm used, such as HMAC SHA256 or RSA.
    
2. **Payload:** The second part of the token is the payload, which contains the declarations. Claims are statements about an entity (typically the user) and additional data. There are three types of claims: registered, public and private.
    
3. **Signature:** To create the signature part, you have to take the encoded header, the encoded payload, a secret and the algorithm specified in the header, and sign it.

![[Pasted image 20250119184659.png]]


![[Pasted image 20250119185329.png]]![[Pasted image 20250119185345.png]]

![[Pasted image 20250119185358.png]]
# WebSocket 
## first sources 
- used in the same way as https
- bidirectional  , full duplex protocol 
- unlike https which is stateless protocol , Websocket is  a stateful protocol which mean that the connection will stay alive until the termination of either party  
- the session information  is store in the server 
1. the client  will send a request to the server 
2. the server will establish a HandShake  confirming and verifying the creation of a connection 
3. this connection will then be known as a WebSocket , which allow bidirectional m ful
4. status code  101 is used to indicate the protocol switch to WebSocket 
when to used WebSocket  when we want to fetch large continuous stream of data over a networks 
# signalR 
Why 
- ASP.NET library real time web  functionality to application 
- add  real time web Functionality  
	- real time web functionally is the ability server code to push contents to the connected client instead of client waiting 
- the main feature being chat but also  user refresh a page to see data , or page implementing long polling 
- application like  a chat room how to get the latest chat from the user ,  in our client we will add a call method to call data access method to our server every 3 second and update the chat 
	this application work but it have some problem : 
	- increase the network traffic ( the method is call continuously for each chat message send )
	- HTTP  due to it stateless nature is reestablised for each request 
	- delay in receiving data due to pooling time 
what

- SignalR is an abstraction over some of the transport that are required to do real time work between client and server 

 - RPC is an api to invoke a function from the  server side to client side  , 
- RPC help with the fact that if any change happend in the database it will then push the change to the servers instead of a one way communication  happening only when the client request  
- signal support server push which is a function where server code can call out the client code in the browser using  RPC

- signalR support the following technique for handling real time communication 
	- webSocket 
		- optimal transport because of efficient use of server memory  
		- lowest latency 
		- the most underlying  features 
	- Server-Sent Event 
	- Long Polling
	- in our application we used the Websocket transport to create the chat room use cases

- - signalR used the old webSocket transport when available 
- signal used hub to communicate between client and server 
	- hub is a high level pipeline that allows client and server to call method on each other .
	- signal handle the dispatching of request between client and server allowing for correct recipient 
	- there are two build in protocol in signal a text based protocol on JSON and a binary protocol 
	- which  is which in this



#  Specification  requirement 
