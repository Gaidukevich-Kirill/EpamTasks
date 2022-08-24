using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class Circle : Figure, IFilm, IPaper, IPlastic
    {
        public double Radius { get; set; }

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
