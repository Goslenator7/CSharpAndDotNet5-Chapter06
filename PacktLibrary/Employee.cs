using System;

namespace Packt.Shared
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        // new keyword tells the compiler we are deliberately replacing the WriteToConsole method from Person class
        // This is known as hiding/non-polymorphic inheritance. Instead we should override/polymorphic inheritance
        public new void WriteToConsole()
        {
            Console.WriteLine($"{this.Name} was born on {this.DateOfBirth:dd/MM/yy} and was hired on {this.HireDate:dd/MM/yy}");
        }
    }
}