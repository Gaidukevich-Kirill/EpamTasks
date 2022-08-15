using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Products;
using ConsoleApp2.Components;

namespace ConsoleApp2.Comparers
{
    public enum typeOfSort
    {
        Ascending = 1,
        Descending = -1
    }

    public class BakeryProductCaloriesComparer : IComparer<BakeryProducts>
    {
        private readonly TypeOfSort _type;

        public BakeryProductCaloriesComparer(TypeOfSort type)
        {
            _type = type;
        }

        public int Compare(BakeryProducts left, BakeryProducts right)
        {
            switch (_type)
            {
                case TypeOfSort.Ascending:
                    return left.ProductCalories.CompareTo(right.ProductCalories);
                case TypeOfSort.Descending:
                    return -(left.ProductCalories.CompareTo(right.ProductCalories));
            }

            throw new Exception();
        }
    }
}
