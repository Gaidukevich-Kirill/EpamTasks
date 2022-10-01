using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class CarveException : Exception
    {
        public CarveException(string message) : base(message)
        {

        }
    }
}
