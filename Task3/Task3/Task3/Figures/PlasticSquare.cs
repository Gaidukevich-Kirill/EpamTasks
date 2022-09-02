using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PlasticSquare : Figure, IPlastic
    {
        public PlasticSquare(double side)
        {
            Side = side;
        }

        public override double Perimeter
        {
            get
            {
                return Side * 4;
            }
        }

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }
    }
}
