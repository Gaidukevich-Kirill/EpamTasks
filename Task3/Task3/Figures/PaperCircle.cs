using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PaperCircle : Figure, IPaper
    {
        public PaperCircle()
        {

        }

        public PaperCircle(double radius)
        {
            Side = radius;
        }

        private bool AbilityCircleFromTriangle(PaperEquilateralTriangle triangle, double side)
        {
            return side > triangle.Side / (2 * Math.Sqrt(3));
        }

        private bool AbilityCircleFromSqare(PaperSquare square, double side)
        {
            return side > square.Side / 2;
        }

        public PaperCircle(ref PaperEquilateralTriangle triangle, double side)
        {
            if (AbilityCircleFromTriangle(triangle, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            triangle = null;
        }

        public PaperCircle(ref PaperSquare square, double side)
        {
            if (AbilityCircleFromSqare(square, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            square = null;
        }

        public override double Perimeter => 2 * Math.PI * Side;

        public override double Area => Math.PI * Side * Side;
    }
}
