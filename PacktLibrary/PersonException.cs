using System;

namespace Packt.Shared
{
    //Extending the exception class to make our own exceptions
    //Constructors are not inherited as other methods are so we must explicitly declare and call base constructor implementations
    public class PersonException : Exception
    {
        public PersonException() : base() { }

        public PersonException(string message) : base(message) { }

        public PersonException(string message, Exception innerException) : base(message, innerException) { }

    }
}