using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Instance creation moved to a method or constructor
        CatProcessor catProcessor = new CatProcessor();

        // Using Cat
        catProcessor.DoSomething<Cat>();

        Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\");

        Lifeform life = new Lifeform();
        var delegatePuppy = life.delegatePuppy;
        var delegateLifeForm = life.delegateLifeForm;

        // we can assign the ImAction<Puppy> to the ImAction<Lifeform> due to the in key word 
        // it is due to its contravariance nature 
        delegatePuppy = delegateLifeForm;

        delegatePuppy(new Puppy());
        // Compiler error if you try to use Dog:
        // catProcessor.DoSomething<Dog>();

        // when to use variance  
        var PersonCompare = new PersonComparer();

        // this is invalid because PersoncCompare and EmployeeCompare is an invariance 
        // EmployeeCompare = PersonCompare;

        List<Employee> employees = new List<Employee>
        {
            new Employee() {FirstName = "Michael", LastName = "Alexander"},
            new Employee() {FirstName = "Jeff", LastName = "Price"}
        };

        // it because it is an Person contravarion T generic type allow it to accpect all derivative type of Person 
        IEnumerable<Employee> noduplicates =
            employees.Distinct<Employee>(new PersonComparer());

        foreach (var employee in noduplicates)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }
        // we created a list of employee 
        employees = new List<Employee>();

        // You can pass IEnumerable<Employee>,
        // although the method expects IEnumerable<Person>.  

        PrintFullName(employees);


    }

    interface IProducer<out T>
    {
        T Product();
    }

    interface IConsumer<in T>
    {
        void Consume(T obj);
    }

    class Base
    {
        public void DoSomething() => Console.WriteLine($"Doing from {this.GetType().Name}");
    }

    class Derived : Base
    {
        public void DoMore() => Console.WriteLine($"Doing more from {this.GetType().Name}  ");
    }

    interface ICovariant<out R>
    {
        // Commented out as it generates a compiler error
        // void DoSomething<T>() where T : R;
    }

    class Animal
    {
        public string Name { get; set; }
    }

    class Cat : Animal
    {
        public void Purr()
        {
            Console.WriteLine("Purring...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Pets : IEnumerable<Cat>, IEnumerable<Dog>
    {
        public System.Collections.IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            Console.WriteLine("Cat");
            // Some code.
            return null;
        }

        IEnumerator<IEnumerable> IEnumerable.GetEnumerator()
        {
            // Some code.
            return null;
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            Console.WriteLine("Dog");
            // Some code.
            return null;
        }
    }

    // if you do not add the in key word it will not be a contravariant
    // if it is not a contravariant it will cause the  delegatePuppy = delegateLifeForm;  out put an error 
    public delegate void myAction<in T>(T obj);

    class Lifeform
    {
        public string Name { get; set; } = "LifeForm";

        public myAction<Lifeform> delegateLifeForm = (input) => Console.WriteLine("lifeForm Delegate - " + input.Name);

        public myAction<Puppy> delegatePuppy = (input) => Console.WriteLine("Puppy Delegate - " + input.Name);

    }

    class Puppy : Lifeform
    {
        public Puppy()
        {
            Name = "Puppy";
        }
    }

    class CatProcessor : ICovariant<Cat>
    {
        public void DoSomething<T>() where T : Cat
        {
            // Do something with T, assuming it's a Cat
            T catInstance = Activator.CreateInstance<T>();
            Console.WriteLine($"Processing {typeof(T)} named {catInstance.Name}");
            catInstance.Purr();

            IEnumerable<Animal> pets = new Pets();
            pets.GetEnumerator();
        }
    }
    // When to used Variance
    // Simple hierarchy of classes.  
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Employee : Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // The custom comparer for the Person type  
    // with standard implementations of Equals()  
    // and GetHashCode() methods.  

    // when you implement a generic interface to a class it the class is invariance  
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (Object.ReferenceEquals(x, y)) return true;
            if (Object.ReferenceEquals(x, null) ||
                Object.ReferenceEquals(y, null))
                return false;
            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode(Person person)
        {
            if (Object.ReferenceEquals(person, null)) return 0;
            int hashFirstName = person.FirstName == null
                ? 0 : person.FirstName.GetHashCode();
            int hashLastName = person.LastName.GetHashCode();
            return hashFirstName ^ hashLastName;
        }
    }

    // print out the list of Person 
    // if we change it to a normal list instead it will out put this error  Severity	Code	Description	Project	File	Line	Suppression State
    // Error CS1503  Argument 1: cannot convert from 'System.Collections.Generic.List<Program.Employee>' to 'System.Collections.Generic.List<Program.Person>'	Covariance and Contravariance code  D:\obsidient C# vault\Covariance and Contravariance\Covariance and Contravariance code\Program.cs	56	Active

    public static void PrintFullName(IEnumerable<Person> persons)
    {   
        // because the list of employee is a covariance is it allow to be assign to a list of person type 
        foreach (Person person in persons)
        {
            Console.WriteLine("Name: {0} {1}",
            person.FirstName, person.LastName);
        }
    }
}
