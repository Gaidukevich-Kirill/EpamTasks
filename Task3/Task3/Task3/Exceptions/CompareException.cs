﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    internal class CompareException : Exception
    {
        public CompareException(string message) : base(message)
        {

        }
    }
}
