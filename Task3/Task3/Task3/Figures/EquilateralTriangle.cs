using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figures
{
    public class EquilateralTriangle
    {
        private double Side { get; set; }

        public EquilateralTriangle(double side)
        {
            Side = side;
        }

        public double Perimeter
        {
            get
            {
                return Side * 3;
            }
        }

        public double Square
        {
            get
            {
                return Side * Side * Math.Sqrt(3) / 4;
            }
        }
    }
}
