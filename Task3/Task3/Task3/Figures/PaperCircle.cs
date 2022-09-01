using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PaperCircle : Figure, IPaper
    {
        public PaperCircle(double radius)
        {
            Side = radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Side;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Side * Side;
            }
        }
    }
}
