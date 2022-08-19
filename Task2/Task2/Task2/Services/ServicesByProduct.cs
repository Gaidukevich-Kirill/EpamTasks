using System;
using System.Collections.Generic;
using System.Text;
using Task2.Products;

namespace Task2.Services
{
    internal class ServicesByProduct
    {
        public static Bolt AdditionOfTwoProducts(Bolt leftProduct, Bolt rightProduct)
        {
            var obj = new Bolt("Bolt", 0, 0, 0)
            {
                PurchaseCost = Math.Round((leftProduct.PurchaseCost * leftProduct.NumberOfUnits
                                           + rightProduct.PurchaseCost * rightProduct.NumberOfUnits)
                                          / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits), 2),
                Margin = Math.Round((leftProduct.Margin * leftProduct.NumberOfUnits
                                     + rightProduct.Margin * rightProduct.NumberOfUnits)
                                    / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits), 2),
                NumberOfUnits = leftProduct.NumberOfUnits + rightProduct.NumberOfUnits
            };

            return obj;
        }

        public static Brick AdditionOfTwoProducts(Brick leftProduct, Brick rightProduct)
        {
            var obj = new Brick("Brick", 0, 0, 0)
            {
                PurchaseCost = Math.Round((leftProduct.PurchaseCost * leftProduct.NumberOfUnits
                                           + rightProduct.PurchaseCost * rightProduct.NumberOfUnits)
                                          / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits), 2),
                Margin = Math.Round((leftProduct.Margin * leftProduct.NumberOfUnits
                                     + rightProduct.Margin * rightProduct.NumberOfUnits)
                                    / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits), 2),
                NumberOfUnits = leftProduct.NumberOfUnits + rightProduct.NumberOfUnits
            };

            return obj;
        }

        public static Screw AdditionOfTwoProducts(Screw leftProduct, Screw rightProduct)
        {
            var obj = new Screw("Screw", 0, 0, 0)
            {
                PurchaseCost = Math.Round((leftProduct.PurchaseCost * leftProduct.NumberOfUnits
                                + rightProduct.PurchaseCost * rightProduct.NumberOfUnits)
                               / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits),2),
                Margin = Math.Round((leftProduct.Margin * leftProduct.NumberOfUnits
                          + rightProduct.Margin * rightProduct.NumberOfUnits)
                         / (leftProduct.NumberOfUnits + rightProduct.NumberOfUnits), 2),
                NumberOfUnits = leftProduct.NumberOfUnits + rightProduct.NumberOfUnits
            };

            return obj;
        }
    }
}
