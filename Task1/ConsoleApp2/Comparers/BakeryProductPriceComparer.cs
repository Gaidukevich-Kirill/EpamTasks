using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Task1.Comparers;
using Task1.Products;
using Task1.Components;

namespace ConsoleApp2.Comparers
{
    public class BakeryProductPriceComparer : IComparer<BakeryProducts>
    {
        private readonly TypeOfSort _type;

        public BakeryProductPriceComparer(TypeOfSort type)
        {
            _type = type;
        }

        public int Compare(BakeryProducts left, BakeryProducts right)
        {
            switch (_type)
            {
                case TypeOfSort.Ascending:
                    return left.ProductPrice.CompareTo(right.ProductPrice);
                case TypeOfSort.Descending:
                    return -(left.ProductPrice.CompareTo(right.ProductPrice));
            }

            throw new Exception();
        }


    }
}
