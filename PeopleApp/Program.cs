using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            //call static method
            var baby2 = Person.Procreate(harry, jill);

            //call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            WriteLine($"{harry.Name}'s first child is named {harry.Children[0].Name}.");

            WriteLine();
            WriteLine($"5! is {Person.Factorial(5)}");
            WriteLine();
            WriteLine("Delegates");
            int answer = p1.MethodIWantToCall("Frog");
            
            //Unsure why the below is in the book as instructions and code placement unclear
            /*
            delegate int DelegateWithMatchingStringSignature(string s);

            // create a delegate instance that points to the method
            var d = new DelegateWithMatchingStringSignature(p1.MethodIWantToCall);

            // call the delegate, which calls the method
            int answer2 = d("Frog");
            */
        }
    }
}
