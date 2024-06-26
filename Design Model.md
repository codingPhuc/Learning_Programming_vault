

# question 
## why do developer need to draw the box again even thought there is already a design ? 
- we need to check if there is any similarity between the items , if there is then group them together 
- help in defining class for each object , items  that is similar  
# Box model 
![[Pasted image 20240622173955.png]]
everything have a box model from the text to element 
4 layer of a box model  :  
Margin  >Border > Padding > Content  
Margin + Border + Padding all have (top right left and bottom) 
while Content can change element width  and height 

## Different between padding and margin 

| Padding                           | Margin                   |
| --------------------------------- | ------------------------ |
| Padding affect outside border box | Affect inside border box |
| Separate the border and element   | Separate the element     |
## different between margin in Son and Padding in father 


| Margin in son                     | Padding in father                                  |
| --------------------------------- | -------------------------------------------------- |
| margin in son affect only it self | padding in father affect all  son inside of father |
# BEM  
![[Pasted image 20240622174855.png]]
B - block 
E - Element 
M - Modifier 
B block is the block tag of all element in html example : <html> , <p>
E is element that define this block usually used with class or id example : <html class = "title">
M is the modifier that change the structure or UI of the class or block in some way like highlight 



