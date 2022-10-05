using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task5
{
    public class Student : IComparable<Student>
    {
        public string LastName { get; set; }

        public Test Test { get; set; }

        public Student()
        {

        }

        public int CompareTo([AllowNull] Student other)
        {
            return this.Test.Grade.CompareTo(other.Test.Grade);
        }
    }
}
