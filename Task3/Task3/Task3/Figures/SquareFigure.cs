using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figures
{
    public class SquareFigure : Figure
    {
        public double Side { get; set; }

        public SquareFigure(double side)
        {
            Side = side;
        }

        public double Perimeter
        {
            get
            {
                return Side * 4;
            }
        }

        public double Square
        {
            get
            {
                return Side * Side;
            }
        }
    }
}
