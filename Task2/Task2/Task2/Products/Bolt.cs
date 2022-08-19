using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Products
{
    public class Bolt : Product
    {
        public Bolt(string productName, double purchaseCost, double margin, int numberOfUnits)
            : base(productName, purchaseCost, margin, numberOfUnits)
        {

        }

    }
}
