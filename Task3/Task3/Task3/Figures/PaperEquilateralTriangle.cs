using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;
using Task3.Exceptions;

namespace Task3.Figures
{
    public class PaperEquilateralTriangle : Figure, IPaper
    {
        public PaperEquilateralTriangle()
        {

        }

        public PaperEquilateralTriangle(double side)
        {
            Side = side;
        }

        private bool AbilityTriangleFromCircle(PaperCircle circle, double side)
        {
            return side > circle.Side * Math.Sqrt(3);
        }

        private bool AbilityTriangleFromSquare(PaperSquare square, double side)
        {
            return side * Math.Sqrt(3) / 2 > square.Side * Math.Sqrt(2);
        }

        public PaperEquilateralTriangle(ref PaperCircle circle, double side)
        {
            if (AbilityTriangleFromCircle(circle, side))
                throw new CarveException("It is impossible to carve this figure.");
            
            Side = side;
            circle = null;
        }

        public PaperEquilateralTriangle(ref PaperSquare square, double side)
        {
            if (AbilityTriangleFromSquare(square, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            square = null;
        }

        public override double Perimeter => Side * 3;

        public override double Area => Side * Side * Math.Sqrt(3) / 4;
    }
}
