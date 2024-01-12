// See https://aka.ms/new-console-template for more information


Base x = new Base(); // this is legal 
Base y = new Derived(); 

// both object know which memeber to call  
x.DoSomething(); 
y.DoSomething();


// but you cannot access the derived class 
//y.DoMore(); 

// you much access the derive method thought the deride class 
Derived   d  =  new Derived();   

d.DoSomething(); 
d.DoMore();




// you can have also a consumer and a producer of the bases type 


IProducer<Base> prodOfBase = null!;
Base a = prodOfBase.Product();
// it is illegal to assign a Covariance interface to a Derived class 
//Derived f = prodOfBase.Product(); 


// it is allow to add a  product of derived to a Base b and Derived c object 
IProducer<Derived> prodOfDerived = null!;
Base b = prodOfDerived.Product();
Derived C = prodOfDerived.Product();  


// IConsumer of bases allow for the consumsion of Base and Derived object 
IConsumer<Base>  consOfBase = null!;

consOfBase.Consume(new Base()); 
consOfBase.Consume(new Derived());



IConsumer<Derived> consOfDerived = null!;

consOfDerived.Consume(new Derived());




//
// the producer of base can be assign to producer of derive and the producer of base 
// producer of derived cannot have the producer of bases becuase if the product is return it will return base which is illegal 


IProducer<Base> p = prodOfBase;
IProducer<Base>  q = prodOfDerived;
IProducer<Derived> r = prodOfDerived;

// xIProducer<Derived> s = prodOfBase;

// the consumer of base can be assign to consumer  of base  it cannot be assign to derive because the value it consume will include both bases and derive 
// 


IConsumer<Base> t = consOfBase;

IConsumer<Derived> v = consOfBase;
IConsumer<Derived> w= consOfBase;

// xIConsumer<Base> u = consOfDerived;







// the out variance enable used of more derived type
// the more used mean that it is used ful for class that  derived from other class to used this interface 
interface IProducer<out T>
{
    T Product(); 

}

// the in variance enable used of less derivde type  
// the more used mean that it is used ful for class that do not derived from other class to used this interface 
interface IConsumer<in T>
{
    void Consume(T obj);  
}










class  Base
{
    public void DoSomething() => Console.WriteLine($"Doing from {this.GetType().Name}"); 
}

class Derived : Base
{
    public void DoMore() => Console.WriteLine($"Doing more from {this.GetType().Name}  "); 
}