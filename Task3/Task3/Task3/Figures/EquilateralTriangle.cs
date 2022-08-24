using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class EquilateralTriangle: Figure, IFilm, IPaper, IPlastic
    {
        public double Side { get; set; }

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
