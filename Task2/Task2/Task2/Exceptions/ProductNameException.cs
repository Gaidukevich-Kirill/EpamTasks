using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exceptions
{
    public class ProductNameException : Exception
    {
        public ProductNameException(string message) : base(message)
        {

        }
    }
}
