## Program Structure
## overview  
the general  Structure of a  C# Programming  contain one or more file each file contain  zero or more name space each namespace should ha contain types suck as structs , interface , class , enumerations , and delegates or , other namespaces 
### top level statement  
```
// A skeleton of a C# program
using System;

// Your program starts here:
Console.WriteLine("Hello world!");

namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }
}
```
- this is a top level C# program running using _top-level statements_ as the program entry point  

[[Top-level statements - programs without `Main` methods]]
### Main 
- you can also create static method Name Main as the program entry points  
```
// A skeleton of a C# program
using System;
namespace YourNamespace
{
    class YourClass
    {
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.WriteLine("Hello world!");
        }
    }
}
```
[[Main() and command-line arguments]]
