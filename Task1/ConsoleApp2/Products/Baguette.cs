using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Products
{
    public class Baguette:BakeryProducts
    {
        public Baguette()
        {

        }

        public override int ProductPrice
        {
            get
            {
                int productPrice = 0;
                foreach (var compound in Compounds)
                {
                    productPrice += compound.Cost;
                }
                int productPriceMargin = (int)(productPrice * 1.26); //margin 26%

                return productPriceMargin;
            }
        }
    }
}
