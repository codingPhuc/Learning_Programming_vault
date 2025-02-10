
# Advanced sate management 
- the problem fo shared state : prop  drilling 
- embracing component  composition  
- sharng State with context 
- Managing complex state with reducers 

Yeuwuw
# most react apps consist of multiple component s 
those  component structure in a  components tree  
in most app will not just have component but also state  
- state need to be lifted up due to the used  and change of child and parent component that need that state shared it thought prop and  change it state 
- pass that shared data though most layer of the component this is call props drilling  this can be a problem
	1. write a lot of boilerplat code to repeat  the entred project 

# component composition  

reflactoring the shop component to a warper  
move the code that used the     
moving the code from the child component that used the event in the parent this used the {children }  in the child  component for funtionality 




# react context API  

build into react their to make sharing data accoress component layer good 
createa context value then  provide that value  around multiple component all component in your application  
it can be conneted to state   
get rid of state will be provided to all your application  
the  component that do need to read that state will reach out to the state 

the context API is store in a file call store  it not set in stone  but is recomentded 


you much add  a value props in the  provider 
# different way of consumming context 

different from the provider component  
there is the consumer component  
```
CartContext.consumer 
```
you don't need to declare a hook on the first line of the component but used a tag  CartContext.consumer  to used the context 


# 
if it  context value changest react can also redo the component 


#  useReduce  

a function that reduce one or more complex values to a simpler one 
to reduce one or more value to a simple value 



