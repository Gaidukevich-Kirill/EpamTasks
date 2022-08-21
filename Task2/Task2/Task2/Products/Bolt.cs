using System;
using System.Collections.Generic;
using System.Text;
using Task2.Exceptions;

namespace Task2.Products
{
    public class Bolt : Product
    {
        public Bolt(string productName, double purchaseCost, double margin, int numberOfUnits)
            : base(productName, purchaseCost, margin, numberOfUnits)
        {

        }

        public static Bolt operator +(Bolt leftProduct, Bolt rightProduct)
        {
            if (leftProduct.ProductName.Equals(rightProduct.ProductName, StringComparison.InvariantCultureIgnoreCase))
            {
                var obj = new Bolt("", 0, 0, 0)
                {
                    ProductName = leftProduct.ProductName,
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
            else
            {
                throw new ProductNameException("Products have different Product Name");
            }
        }

        public static Bolt operator -(Bolt product, int numberOfUnits)
        {
            var obj = new Bolt("", 0, 0, 0)
            {
                ProductName = product.ProductName,
                PurchaseCost = product.PurchaseCost,
                Margin = product.Margin
            };

            if (product.NumberOfUnits >= numberOfUnits)
            {
                obj.NumberOfUnits = product.NumberOfUnits - numberOfUnits;
            }
            else
            {
                throw new ProductQuantityException("Cannot subtract more units than there are in the product.");
            }

            return obj;
        }

    }
}
