﻿using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmEquilateralTriangle: Figure, IFilm
    {
        public FilmEquilateralTriangle(double side)
        {
            Side = side;
        }

        public double Perimeter
        {
            get
            {
                return Side * 3;
            }
        }

        public double Square
        {
            get
            {
                return Side * Side * Math.Sqrt(3) / 4;
            }
        }
    }
}
