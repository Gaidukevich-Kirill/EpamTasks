using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    internal class PaintException : Exception
    {
        public PaintException(string message) : base(message)
        {

        }
    }
}
