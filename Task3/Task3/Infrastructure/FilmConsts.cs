using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;

namespace Task3.Infrastructure
{
    public class FilmConsts
    {
        public static readonly Type[] ValidFilmTypes = new Type[]
        {
            typeof(FilmSquare),
            typeof(FilmEquilateralTriangle),
            typeof(FilmCircle)
        };
    }
}
