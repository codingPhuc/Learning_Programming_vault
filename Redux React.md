# Problem that redux fix 
## Context  
when you are using context the parent component can pass data value thought any of it children without the need to create a drop drilling effect  or the sibling component don't have to moving state up  you can specify which component used with context value bases on the situation . 
But this will lead to a problem of component resuabily where the component cannot be reused effectively  due to unwanted effect between different component when specifying Context 
like B is reused in A and C but we only want B in  A to affect A not B in C ... 

# the Flow of context 

![[Drawing 2024-10-03 18.04.11.excalidraw]]
- the component or UI when ever an event listener will be call will call the dispacther 
- the dispacher will have a action parameter specifying which operation the store will do 
- when the reducer receive the action it will change the subcriber state then send the change back vie a call back function