using System;
using System.Collections.Generic;
using System.Text;
using Task1.Components;

namespace Task1.Products
{
    public class WhiteBread : Bread
    {
        public WhiteBread() : base()
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
                var productPriceMargin = (int)(productPrice * 1.11); //margin 11%

                return productPriceMargin;
            }
        }
    }
}
