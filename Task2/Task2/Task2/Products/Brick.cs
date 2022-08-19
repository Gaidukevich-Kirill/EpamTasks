using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Products
{
    public class Brick : Product
    {
        public Brick(string productName, double purchaseCost, double margin, int numberOfUnits)
            : base(productName, purchaseCost, margin, numberOfUnits)
        {

        }
}
}
