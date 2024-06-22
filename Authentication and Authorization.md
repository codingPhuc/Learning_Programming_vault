
**Authentication** is the process of verifying the identity of a user or service. It’s about confirming “you are who you say you are”. This is usually done through something you know (like a password), something you have (like a physical device), or something you are (like a fingerprint). It’s the first step in accessing a system and it’s about establishing an identity.

**Authorization**, on the other hand, comes after authentication and determines what level of access an authenticated user should have. It’s about answering the question “what are you allowed to do?”. This could involve determining the functions a user can use, the data they can access, and how different levels of access interact with each other.


# Authentication Flow (JWT)

![[Pasted image 20240613104022.png]]  
JWT  ,is a token to authenticate the user. The token act like an id or access card for each unique user , the access the system the user much first login with the correct credential then the system will return a JWT . With the JWT  the user can then make an API call that will return the desire result 
![[Pasted image 20240613104034.png]]
if there is no JWT token there will be no data or value return 
- The term “JWT token” is redundant because JWT stands for JSON Web Token. So, it’s better to just say “JWT”.
- It’s important to mention that the server validates the JWT. If the token is invalid, expired, or not included in the request, the server will not return the desired data.
- JWTs are not just for APIs. They can be used in any scenario where you need to authenticate a user.