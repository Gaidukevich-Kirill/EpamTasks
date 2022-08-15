using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Comparers
{
    public class CompoundCostComparer : IComparer<Compound>
    {
        public int Compare(Compound leftComponent, Compound rightComponent)
        {
            if( leftComponent.Cost < rightComponent.Cost)
            {
                return -1;
            }
            else if(leftComponent.Cost > rightComponent.Cost)
            {
                return 1;
            }
            else 
            { 
                return 0; 
            }

            //return leftComponent.Cost.CompareTo(rightComponent.Cost);
        }
    }
}
