using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Products
{
    public class WhiteBread : Bread
    {
        public WhiteBread() : base()
        {
            Compounds.Add(new Egg(50, 50));
        }

        public double ProductPrice
        {
            get
            {
                int productPrice = 0;
                foreach (var compound in Compounds)
                {
                    productPrice += compound.Cost;
                }
                double productPriceMargin = productPrice * 1.11; //margin 11%

                return productPriceMargin;
            }
        }
    }
}
