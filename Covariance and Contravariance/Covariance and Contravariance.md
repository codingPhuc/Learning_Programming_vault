
# What is a Variance  ? 
- Variance is how subtyping between more complex types relate to subtyping between their component , think of it like how a data structure or function  of a  type  derivative relate to a data structure of a base type 
- an example of this is how a list of cat relate to a list of animal 
- when a class is inherited form and form it own function it will overide the function of the base class so the base class function will be a subtype of the deride class function   so it will be Contravariance 
- when a base data structure is being inherited on the other hand it will create a Covariance because the base data structure is prioritize  over the inherited class data structure 
# Covariance and Contravariance Concept  
- if shrinking the cause the consequence to shrink as well then those are Covariance they are changing in the same direction 
- if scaling down the cause make the effect  go larger we are talking about Contravariance effect 
- in C# a covariance is when an object with more derived type argument is assign to an object with less derived type argument 
`string str = "test"; // An object of a more derived type is assigned to an object of a less derived type. object obj = str; // Covariance. IEnumerable<string> strings = new List<string>(); // An object that is instantiated with a more derived type argument // is assigned to an object instantiated with a less derived type argument. // Assignment compatibility is preserved. IEnumerable<object> objects = strings;` 
- a Contravariance is when an object with less derived type argument  is assigned to an object instantiated with more derived type argument 
`static void SetObject(object o) { } Action<object> actObject = SetObject; // An object that is instantiated with a less derived type argument // is assigned to an object instantiated with a more derived type argument. // Assignment compatibility is reversed. Action<string> actString = actObject;`
- when a method is consuming argument then usually it is a contravariance  type 
- when a method is producing  argument then usually it is a covariance type 
- think of the covariance is a parent can have child  but a child cannot be a parent  
- think of contravariant as a child  can be an adult but an adult cannot be child 
- observing the fundamental of object 
[[Variance in Generic Interfaces]]
[[Using Variance in Interfaces for Generic Collections]]
[[Variance in Delegates]]
