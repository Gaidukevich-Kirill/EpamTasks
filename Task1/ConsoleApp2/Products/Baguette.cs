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
            Compounds.Add(new Sugar(5, 50));
            Compounds.Add(new Flour(50, 50));
            Compounds.Add(new Salt(5, 50));
            Compounds.Add(new Egg(15, 35));
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
