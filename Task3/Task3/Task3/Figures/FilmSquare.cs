using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmSquare : Figure, IFilm
    {
        public FilmSquare(double side)
        {
            Side = side;
        }

        public FilmSquare(ref FilmEquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (1 + 2 / Math.Sqrt(3)))
            {
                Side = side;
                triangle = null;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public FilmSquare(ref FilmCircle circle, double side)
        {
            if (side * Math.Sqrt(2) <= circle.Side * 2)
            {
                Side = side;
                circle = null;
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
