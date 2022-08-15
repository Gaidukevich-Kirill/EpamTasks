using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Comparers
{
    public class CompoundCaloriesComparer : IComparer<Compound>
    {
        public int Compare(Compound leftComponent, Compound rightComponent)
        {
            if (leftComponent.Calories < rightComponent.Calories)
            {
                return -1;
            }
            else if (leftComponent.Calories > rightComponent.Calories)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            //return leftComponent.Calories.CompareTo(rightComponent.Calories);
        }
    }
}
