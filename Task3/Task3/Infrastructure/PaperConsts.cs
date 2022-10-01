using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;

namespace Task3.Infrastructure
{
    public class PaperConsts
    {
        public static readonly Type[] ValidPaperTypes = new Type[]
        {
            typeof(PaperCircle),
            typeof(PaperEquilateralTriangle),
            typeof(PaperSquare)
        };
    }
}
