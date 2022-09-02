using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PaperSquare : Figure, IPaper
    {
        public PaperSquare(double side)
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
