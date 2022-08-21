using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exceptions
{
    public class ProductQuantityException : Exception
    {
        public ProductQuantityException(string message) : base(message)
        {

        }
    }
}
