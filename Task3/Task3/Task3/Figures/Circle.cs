using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figures
{
    internal class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public double Square
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }


    }
}
