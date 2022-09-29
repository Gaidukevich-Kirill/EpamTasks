using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;

namespace Task3.Infrastructure
{
    public class PlasticConsts
    {
        public static readonly Type[] ValidPlasticTypes = new Type[]
        {
            typeof(PlasticCircle),
            typeof(PlasticEquilateralTriangle),
            typeof(PlasticSquare)
        };
    }
}
