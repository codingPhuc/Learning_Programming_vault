## Variance in Generic Interfaces  
- Variance in generic interfaces is supported for reference types only. Value types do not support variance. For example, `IEnumerable<int>` cannot be implicitly converted to `IEnumerable<object>`, because integers are represented by a value type.
- [IEnumerable<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1) (T is covariant)[IEnumerator<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1) (T is covariant)
    
- [IQueryable<T>](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1) (T is covariant)
    
- [IGrouping<TKey,TElement>](https://learn.microsoft.com/en-us/dotnet/api/system.linq.igrouping-2) (`TKey` and `TElement` are covariant)
    
- [IComparer<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1) (T is contravariant)
    
-  [IEqualityComparer<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iequalitycomparer-1) (T is contravariant)

- [IComparable<T>](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1) (T is contravariant)


Starting with .NET Framework 4.5, the following interfaces are variant:

- [IReadOnlyList<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1) (T is covariant)
- [IReadOnlyCollection<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1) (T is covariant)
``
### Declaring Variant Generic Interfaces
- you can support both Covariance and contravariance in the same interface , but for different type parameters . An example of this is the Covariance being the return type of a method and the Contravariance being it input type 
```
interface IVariant<out R, in A>
{
    R GetSomething();
    void SetSomething(A sampleArg);
    R GetSetSomethings(A sampleArg);
}
```
#### Covariant 
- you can declare a generic type parameter  covariance by using the `out` key word  
- it much satisfy the following requirement 
	- The type is used only as a return type of interface methods and not used as a type of method arguments. This is illustrated in the following example, in which the type `R` is declared covariant.
 ```interface ICovariant<out R>
{
    R GetSomething();
    // The following statement generates a compiler error.
    // void SetSomething(R sampleArg);

}
```
- there is one contradiction to the rule above it is if you declare a contravariance as a method inside the covariant interface with the same generic key word it will be allow 
```
interface ICovariant<out R>
{
    void DoSomething(Action<R> callback);
}
```
- the  covariance interface should not be used for a constraint for the interface 
```
interface ICovariant<out R>
{
    // The following statement generates a compiler error
    // because you can use only contravariant or invariant types
    // in generic constraints.
    // void DoSomething<T>() where T : R;
}
```
#### Contravariance 
 - in Contravariance can also be used for the generic interface the rule for Contravariance is that it can only be used for method argument the key word it used is `in`
```
interface IContravariant<in A>
{
    void SetSomething(A sampleArg);
    void DoSomething<T>() where T : A;
    // The following statement generates a compiler error.
    // A GetSomething();
}
```
### Extending Variant Generic Interfaces 
- when you extend a variant , you much used `in` or `out` key word to check if the interface support variance. The extended interface does not automatically support variance when you extend them base on the base class 
```
interface ICovariant<out T> { }
interface IInvariant<T> : ICovariant<T> { }
interface IExtCovariant<out T> : ICovariant<T> { }
```

#### code explanation 
- the example show that  IInvariant extend ICovariant but IInvariant is not a variance 
- while because of the `out` key word IExtCovariant is a variance 

- you can also extend both a contravariance and covariance interface as long as the deride class is an invariance 
```
interface ICovariant<out T> { }
interface IContravariant<in T> { }
interface IInvariant<T> : ICovariant<T>, IContravariant<T> { }
```
