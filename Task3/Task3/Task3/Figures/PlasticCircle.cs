using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class PlasticCircle : Figure, IPlastic
    {
        public PlasticCircle()
        {

        }

        public PlasticCircle(double radius)
        {
            Side = radius;
        }

        private bool AbilityCircleFromTriangle(PlasticEquilateralTriangle triangle, double side)
        {
            return side > triangle.Side / (2 * Math.Sqrt(3));
        }

        private bool AbilityCircleFromSqare(PlasticSquare square, double side)
        {
            return side > square.Side / 2;
        }

        public PlasticCircle(ref PlasticEquilateralTriangle triangle, double side)
        {
            if (AbilityCircleFromTriangle(triangle, side)) 
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            triangle = null;
        }

        public PlasticCircle(ref PlasticSquare square, double side)
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
