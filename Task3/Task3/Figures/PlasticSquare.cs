using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PlasticSquare : Figure, IPlastic
    {
        public PlasticSquare()
        {

        }

        public PlasticSquare(double side)
        {
            Side = side;
        }

        private bool AbilitySquareFromTriangle(PlasticEquilateralTriangle triangle, double side)
        {
            return side > triangle.Side / (1 + 2 / Math.Sqrt(3));
        }

        private bool AbilitySquareFromCircle(PlasticCircle circle, double side)
        {
            return side * Math.Sqrt(2) > circle.Side * 2;
        }

        public PlasticSquare(ref PlasticEquilateralTriangle triangle, double side)
        {
            if (AbilitySquareFromTriangle(triangle, side))
                throw new CarveException("It is impossible to carve this figure.");
                
            Side = side;
            triangle = null;
        }

        public PlasticSquare(ref PlasticCircle circle, double side)
        {
            if (AbilitySquareFromCircle(circle, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            circle = null;
        }

        public override double Perimeter => Side * 4;

        public override double Area => Side * Side;
    }
}
