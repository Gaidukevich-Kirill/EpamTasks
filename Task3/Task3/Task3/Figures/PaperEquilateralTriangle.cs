using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;
using Task3.Exceptions;

namespace Task3.Figures
{
    public class PaperEquilateralTriangle : Figure, IPaper
    {
        public PaperEquilateralTriangle(double side)
        {
            Side = side;
        }

        public PaperEquilateralTriangle(ref PaperCircle circle, double side)
        {
            if (side <= circle.Side * Math.Sqrt(3))
            {
                Side = side;
                circle = null;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public PaperEquilateralTriangle(ref PaperSquare square, double side)
        {
            if (side * Math.Sqrt(3) / 2 <= square.Side * Math.Sqrt(2))
            {
                Side = side;
                square = null;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
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
