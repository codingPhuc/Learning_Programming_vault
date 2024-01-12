# Covariance and Contravariance Concept  
- if shrinking the cause the consequence to shrink as well then those are Covariance they are changing in the same direction 
- if scaling down the cause make the effect  go larger we are talking about Contravariance effect 
- in C# a covariance is when an object with more derived type argument is assign to an object with less derived type argument 
`string str = "test"; // An object of a more derived type is assigned to an object of a less derived type. object obj = str; // Covariance. IEnumerable<string> strings = new List<string>(); // An object that is instantiated with a more derived type argument // is assigned to an object instantiated with a less derived type argument. // Assignment compatibility is preserved. IEnumerable<object> objects = strings;` 
- a Contravariance is when an object with less derived type argument  is assigned to an object instantiated with more derived type argument 
`static void SetObject(object o) { } Action<object> actObject = SetObject; // An object that is instantiated with a less derived type argument // is assigned to an object instantiated with a more derived type argument. // Assignment compatibility is reversed. Action<string> actString = actObject;`
- when a method is consuming argument then usually it is a contravariance  type 
- when a method is producing  argument then usually it is a covariance type 
- observing the fundamental of object 