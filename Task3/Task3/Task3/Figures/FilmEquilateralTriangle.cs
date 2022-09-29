using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmEquilateralTriangle: Figure, IFilm
    {
        public FilmEquilateralTriangle()
        {

        }

        public FilmEquilateralTriangle(double side)
        {
            Side = side;
        }

        private bool AbilityTriangleFromCircle(FilmCircle circle, double side)
        {
            return side > circle.Side * Math.Sqrt(3);
        }

        private bool AbilityTriangleFromSquare(FilmSquare square, double side)
        {
            return side * Math.Sqrt(3) / 2 > square.Side * Math.Sqrt(2);
        }

        public FilmEquilateralTriangle(ref FilmCircle circle, double side)
        {
            if (AbilityTriangleFromCircle(circle, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            circle = null;
        }

        public FilmEquilateralTriangle(ref FilmSquare square, double side)
        {
            if (AbilityTriangleFromSquare(square, side))
                throw new CarveException("It is impossible to carve this figure.");

            Side = side;
            square = null;
        }

        public override double Perimeter => Side * 3;

        public override double Area => Side* Side * Math.Sqrt(3) / 4;
    }
}
