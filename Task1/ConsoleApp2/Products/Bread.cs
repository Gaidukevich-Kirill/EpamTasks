using System;
using System.Collections.Generic;
using System.Text;
using Task1.Components;

namespace Task1.Products
{
    public class Bread : BakeryProducts
    {
        public Bread()
        {

        }

        public override int ProductPrice
        {
            get
            {
                var productPrice = 0;
                foreach (var compound in Compounds)
                {
                    productPrice += compound.Cost;
                }

                var productPriceMargin = (int)(productPrice * 1.21); //margin 21%

                return productPriceMargin;
            }
        }
    }
}
