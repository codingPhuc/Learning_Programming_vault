
## Comparison: `==` (Equality Operator)

- **When both operands are of the same data type (1)**:
    - It returns `true` if the values are the same.
    - It returns `false` if the values are different.
- **When the two operands are of different data types**:
    - The operator converts them to the same data type and then compares the values.
![[Pasted image 20240629160852.png]]
# different between  == and === in javascript : 
- for  == it will show true when the value in the variable in the same even with different typing 
- while for === it will be true if it the same value and type . 
## priority of conversion 
![[Pasted image 20240629161948.png]]example : 
```
false == "hello" 
0 == 'hello' 
'0' =='hello'
```
when comparing null or undefined the value that is compare with will always be  false . So it is best practice to not compare null and undefined with == 
with === there is no conversion to compare between type 
![[Pasted image 20240629162210.png]] 
for value of the same data type comparation is the same with == 
for value of 2 different data type comparation will result in false 

# var const and let 
## var
var is a global scope or a function local scope 
meaning that we can create another varible with var without error
when creating a function it will be push to the head of it scope before compilation of the code  
```
console.log (greeter); 
var greetter= "say hello" 
var greeter ; 
console.log(greeter)
greeter = "say hello"
```
problem with var 
```
var greeter  = "hey hi"
var times = 4  
if(times > 3) 
{
var greeter  = "say hello instead " ; 
}
console.log(greeter )
```
because time >3 return true , greeter turn into "say hello instead" . This is a problem that born the creation of let and const , var can enable you to create another variable in a statement  scope  that you already create out side of it but the execution that used that variable will take the most recently created one 
## let 
let exit in a block scope , block scope are scope that exit in {} 
anything in a {} is call a block scope  
var and let is similar in that both  can be change it it scope but let cannot be created in it scope 

```
let greeting = "say Hi"; greeting = "say Hello instead"; 
console.log(greeting); // This line would print "say Hello instead" to the console
```

but if a variable is create in another scope this is no problem 

```
let greeting = 'Say hi';
if (true) {
let greeting = 'Hello';
}console.log(greeting); // say H
```

## const 
just like let , scope of const is a block scope 
const cannot be updated after creation  or created again like var or let  
variable of const cannot be updated but it attribute can be like creation of a const object all variable in that object can be change 

const greeting = {

  message: "say Hi",

  times: 4

}


greeting = {

  words: "Hello",

  number: "five"

} 



greeting.message = "say Hello instead";
```
``` 
like let , when declaring const it will be move up but not created 
