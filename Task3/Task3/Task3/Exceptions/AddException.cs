using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class AddException : Exception
    {
        public AddException(string message) : base(message)
        {

        }
    }
}
