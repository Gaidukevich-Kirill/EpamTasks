using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;

namespace Task3.Infrastructure
{
    internal class CircleConsts
    {
        public static readonly Type[] ValidCircleTypes = new Type[]
        {
            typeof(FilmCircle), 
            typeof(PaperCircle),
            typeof(PlasticCircle)
        };
    }
}
