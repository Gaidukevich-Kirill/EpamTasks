using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PlasticEquilateralTriangle : Figure, IPlastic
    {
        public PlasticEquilateralTriangle(double side)
        {
            Side = side;
        }

        public override double Perimeter
        {
            get
            {
                return Side * 3;
            }
        }

        public override double Area
        {
            get
            {
                return Side * Side * Math.Sqrt(3) / 4;
            }
        }
    }
}
