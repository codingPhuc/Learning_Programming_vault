# what is react 
React is a Javascript library that is used of the development of front end application  
React is not a frame work 
## different between React and Angular
Angular  is a framework while React is a library  

![[Drawing 2024-10-02 12.15.10.excalidraw]]
- the react community is very active compare to angular 
- react is easy to learn harder to master then Angular 
![[Drawing 2024-10-02 12.18.28.excalidraw]]
- A framework is a collection of item already build in , most of the thing you need don't need to be imported , while a library need constant import to work 



# Rendering 
## Virtual Dom  
virtual dom is a concept in react that help with the loading of data when the UI element is constantly changing 
example of problem that a virtual DOM fix : 
transaction site that always constantly updating the UI 
the Virtual will first calculate the UI changes in the Virtual dom each then compare the changes with the real DOM then update the real dom
# Component  


A Component is a reusable  independent  piece of UI interface 
. A component can change bases on the user interaction with it state or other outside effect or component interaction with it prop 

The idea of a component is like a lego brick you need to classify the smallest brick to then build a bigger compartment 
then used that compartment to build the whole set
## prop  
passing prop to a component require the used of the JSX syntax ,  the passing method is like those build in to React like  but this time we define our own way of passing
```
export default function Profile() {  

return (  

<Avatar  

person={{ name: 'Lin Lanying', imageId: '1bX5QH6' }}  

size={100}  

/>  

);  

}
```
here we are passing the prop of name an imageId to the Avatar component 
This is call a one way data flow in which the parrent component pass data value to the child  component   

## state  
State is value that store poperties of a component it is used to help component 'Remember something' between render
when you want to change a value in a component without it being create again and do not have value updated you used useState 
an example 
```
import { sculptureList } from './data.js';

export default function Gallery() {
  let index = 0;

  function handleClick() {
    index = index + 1;
  }

  let sculpture = sculptureList[index];
  return (
    <>
      <button onClick={handleClick}>
        Next
      </button>
      <h2>
        <i>{sculpture.name} </i> 
        by {sculpture.artist}
      </h2>
      <h3>  
        ({index + 1} of {sculptureList.length})
      </h3>
      <img 
        src={sculpture.url} 
        alt={sculpture.alt}
      />
      <p>
        {sculpture.description}
      </p>
    </>
  );
}

```
if we used this code it will move to the next image whenever the button is click but it is useless now because there is not state value . 
when the button is click 2 thing happen : 
- the component does not know if the value need to be render
- value is not updated due to it being initalize again 
### solution 
we will declare the index state value as hook that will  help in changing the index 
```
import { useState } from 'react';
import { sculptureList } from './data.js';

export default function Gallery() {
  const [index, setIndex] = useState(0);

  function handleClick() {
    setIndex(index + 1);
  }

  let sculpture = sculptureList[index];
  return (
    <>
      <button onClick={handleClick}>
        Next
      </button>
      <h2>
        <i>{sculpture.name} </i> 
        by {sculpture.artist}
      </h2>
      <h3>  
        ({index + 1} of {sculptureList.length})
      </h3>
      <img 
        src={sculpture.url} 
        alt={sculpture.alt}
      />
      <p>
        {sculpture.description}
      </p>
    </>
  );
}

```
this will finally change our image
### thing to note
each state is independent to it component 
a state is used to remember information on each render of the component
Hook  is used to hook into a component to add feature 
Hook much be call independently 
Hook much be the first line of a program 




# Context  
context are 
## Purity   
## reference 
## suspense 
## Error Boundaries 


## Javascript file management 
## improving app performance 

# Hook  
## StateHook 
## Effect Hook  
## Context Hook 
## Ref Hook  



# Component  
is a function in  react 
JXS is javascript cannot write attribute in html  
react is dynamic javascript value using { } 
{} string a number directly  
javascript function return 1 thing  you much warp them in a component 
give a value to another Component  are custom attribute you can add in  to any component in a React library 
can you pass anything as prop   yes you can you can even add anything between them organize 
key prop is another build in prop on react help to tell one component apart from another you will get warn in React 
how does it display something in browser 

# Rendering in React 
Virtual DOM 
DOM ( document object model  ) model every html in the webpage  
state of the react change update the virtual dom 
diff check for changes 
Reconciliation update the DOM with the real DOM  
Even handling in react is build by having special build in Event like on click on change and on submit you need to bind a function to React 
usedstate take an argument like 0 retrun an array with the var and a funciton to update the state 
control component used state value for better state control 
here how it work the user state then click on the button  the user used the use state then output the component  then it will show to the user 
# Hooks 
used to add new feature into functional component there are five main type of hook  
## managesate 
useState ( )
useReducer  
# use data pass thought context 
usecontext 
let you used data pass thought react context
# 'reference ' HTMl 
useRef()
referen hook
referent thing like html element 
# effect hook 
external system 
# improving app perf 
usememo  
useCallback() 
performance 
## three major hook used state
useState() useEffect() useRef()

# purity 

react component should work
mean thata the same input should also return the same output 
to keep something pure it should only return the JXS and it should not change any object before rendering cup is impure changest the varible count before output 

Strict mode is a component that tell us that we should not do something 
effect are code that reach outside our react application like calling a REST sever or react application 
the best way of doing this is with a Even handler 
or if you do not have an event handle er ten you should just used  useeffect hook 
step outside the React application with a dom used the React hook with useRef 
Context is used for jumbing thought the component tree then used the data in any prop 
1. create context 
2. warp the child on  

Portals context for component move element into any component to selecet  
create protal function  then choose the html  into it 
suspense help to have fall back component when the data is ready  
react app are all javascript may crash , you used error boudary 
and display a more helpful for the user 
# still not understanding portal 

# suspense loading component
it used full for lazy loading component 
# error landing 
thought an error when using 


![[Pasted image 20241002131904.png]]

## JSX  in React Library 
JSX was create for the reason of seperation of  different object to save to 
![[Drawing 2024-10-02 12.30.22.excalidraw ]]

- the first reason for why JSX is need is because of the load nature of the program   if we split the file into seperate order and the file B is dependent on the execution of file C then there will be an error 
- JSX fix this in a sense that an algorithm will be used to handle and order the javascript file for us 

