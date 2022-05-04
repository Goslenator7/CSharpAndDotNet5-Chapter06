using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        //Fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        //methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // static method to "multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        // instance method to "multiply"
        public Person ProcreateWith(Person partner)
        {
            // "this" references the current instance of the class
            return Procreate(this, partner);
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        //method with a local function
        // local functions are the method equivalent of local variables and are only accessible within the method
        // where they have been defined
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than 0.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        public int MethodIWantToCall(string input)
        {
            return input.Length; // doesn't matter what this does
        }

        // event delegate fields
        public EventHandler Shout;

        //data field
        public int AngerLevel;

        //method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //if something is listening
                //? checks for null inline
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
        
         public int CompareTo(Person other)
         {
            return Name.CompareTo(other.Name);
         }
    }
}
