using System;
using System.Collections.Generic;
using System.Text;
using Task2.Exceptions;

namespace Task2.Products
{
    public class Screw : Product
    {
        public Screw()
        {

        }

        public Screw(
            string productName, 
            double purchaseCost, 
            double margin, 
            int numberOfUnits)
            : base(
                productName, 
                purchaseCost, 
                margin, 
                numberOfUnits)
        {

        }

        public static Screw operator +(Screw leftProduct, Screw rightProduct)
        {
            if (leftProduct == null || rightProduct == null)
            {
                throw new ArgumentNullException();
            }
            if (!(leftProduct.ProductName.Equals(rightProduct.ProductName,
                    StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new ProductNameException("Products have different Product Name");
            }

            var obj = new Screw()
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
        
        public static Screw operator -(Screw product, int numberOfUnits)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (product.NumberOfUnits < numberOfUnits)
            {
                throw new ProductQuantityException("Cannot subtract more units than there are in the product.");
            }

            var obj = new Screw()
            {
                ProductName = product.ProductName,
                PurchaseCost = product.PurchaseCost,
                Margin = product.Margin,
                NumberOfUnits = product.NumberOfUnits - numberOfUnits
            };

            return obj;
        }
    }
}
