﻿using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmEquilateralTriangle: Figure, IFilm
    {
        public FilmEquilateralTriangle(double side)
        {
            Side = side;
        }

        public FilmEquilateralTriangle(ref FilmCircle circle, double side)
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

        public FilmEquilateralTriangle(ref FilmSquare square, double side)
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