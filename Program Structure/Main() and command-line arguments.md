

- The `Main` method is the entry point of a C# application .(Libraries and services do not require a `Main` method as an entry point) , when the application is first started  The main method is the first method that is invoked 
- if there is more than one class that have the main method you must used `StartupObject` to compile your program , 
## Concept 
- the `Main` method is the execution of the program it is where the program should start and end 
- `Main` is declared inside a class or struct . Main must be static and it need not be public. The closing class or struct that contain the main is not require to be static 
- `Main` can either have a void , int, Task  , or `Task<int>` return Type. 
  - Main can used a async modifier if Main return a task or `Task<int>` modifier  . This specifically excludes an async void Main method 
  - The `Main` method can be declared with or without a `string[]` parameter that contains command-line arguments. When using Visual Studio to create Windows applications, you can add the parameter manually or else use the [GetCommandLineArgs()](https://learn.microsoft.com/en-us/dotnet/api/system.environment.getcommandlineargs#system-environment-getcommandlineargs) method to obtain the command-line arguments. Parameters are read as zero-indexed command-line arguments. Unlike C and C++, the name of the program is not treated as the first command-line argument in the `args` array, but it is the first element of the [GetCommandLineArgs()](https://learn.microsoft.com/en-us/dotnet/api/system.environment.getcommandlineargs#system-environment-getcommandlineargs) method.
- the following showcase the main method structure 
```
public static void Main() { }
public static int Main() { }
public static void Main(string[] args) { }
public static int Main(string[] args) { }
public static async Task Main() { }
public static async Task<int> Main() { }
public static async Task Main(string[] args) { }
public static async Task<int> Main(string[] args) { }
```