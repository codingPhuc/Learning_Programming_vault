# find and fixing errors 
making sense of React Error  Messages 
finding locagical error view the browser  devTools  & debugger 
enabling  react strickt mode 
using the react devtools for application analysis  manipulation 

```
Uncaught TypeError: Cannot read properties of undefined (reading 'valueEndOfYear')
    at Results (Results.jsx:8:16)
    at react-stack-bottom-frame (react-dom_client.js?v=d172aed0:16433:20)
    at renderWithHooks (react-dom_client.js?v=d172aed0:4414:24)
    at updateFunctionComponent (react-dom_client.js?v=d172aed0:6092:21)
    at beginWork (react-dom_client.js?v=d172aed0:7179:20)
    at runWithFiberInDEV (react-dom_client.js?v=d172aed0:741:18)
    at performUnitOfWork (react-dom_client.js?v=d172aed0:11013:98)
    at workLoopSync (react-dom_client.js?v=d172aed0:10871:11)
    at renderRootSync (react-dom_client.js?v=d172aed0:10853:15)
    at performWorkOnRoot (react-dom_client.js?v=d172aed0:10495:46)
```
- we can see  that it is an uncaught type errror  
- reading 'valueEndOfYear' fail to access this properties  the object seem to be undefine  

```
  at Results (Results.jsx:8:16)
    at react-stack-bottom-frame (react-dom_client.js?v=d172aed0:16433:20)
    at renderWithHooks (react-dom_client.js?v=d172aed0:4414:24)
    at updateFunctionComponent (react-dom_client.js?v=d172aed0:6092:21)
    at beginWork (react-dom_client.js?v=d172aed0:7179:20)
    at runWithFiberInDEV (react-dom_client.js?v=d172aed0:741:18)
    at performUnitOfWork (react-dom_client.js?v=d172aed0:11013:98)
    at workLoopSync (react-dom_client.js?v=d172aed0:10871:11)
    at renderRootSync (react-dom_client.js?v=d172aed0:10853:15)
    at performWorkOnRoot (react-dom_client.js?v=d172aed0:10495:46)
```
- this is a stack tray  the list of output that occure  the error  
- `Results.jsx:8:16`  we see here that it that the line  8 line of code occur an  error 

# using browser error checker 

take a look  at that code at the time the code executed  , 
the browser have a break point application where we can see where the application break  
we can see that the investment value is intially 2 value adding a number to string will concate the string 




# strict  mode react
strict mode will execute the component function 2 instead of 1  in production it willnot execute 2  
<App />
it immidately suffact that there is a problem  

# using dev  tools 