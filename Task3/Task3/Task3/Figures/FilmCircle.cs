﻿using System;
using System.Collections.Generic;
using System.Text;
using Task3.Exceptions;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmCircle : Figure, IFilm
    {
        public FilmCircle(double radius)
        {
            Side = radius;
        }
        
        public FilmCircle(ref FilmEquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (2 * Math.Sqrt(3)))
            {
                Side = side;
                triangle = null;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public FilmCircle(ref FilmSquare square, double side)
        {
            if (side <= square.Side / 2)
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
                return 2 * Math.PI * Side;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * Side * Side;
            }
        }
    }
}