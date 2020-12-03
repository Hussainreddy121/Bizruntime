using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    class CustomeException
    {
        public void custommethod(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
           
        {
            Console.WriteLine(message);
        }
    }
}
