using System;
using System.Collections.Generic;
using System.Text;
using Task2.Exceptions;
using Task2.Products;

namespace Task2.Services
{
    public static class ServicesByProduct
    {
        public static Bolt AdditionOfTwoProducts(Bolt leftProduct, Bolt rightProduct)
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

            var obj = new Bolt()
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

        public static Brick AdditionOfTwoProducts(Brick leftProduct, Brick rightProduct)
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

            var obj = new Brick()
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

        public static Screw AdditionOfTwoProducts(Screw leftProduct, Screw rightProduct)
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

        public static Bolt SubtractingUnitsOfProduction(Bolt product, int numberOfUnits)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (product.NumberOfUnits < numberOfUnits)
            {
                throw new ProductQuantityException("Cannot subtract more units than there are in the product.");

            }

            var obj = new Bolt()
            {
                ProductName = product.ProductName,
                PurchaseCost = product.PurchaseCost,
                Margin = product.Margin,
                NumberOfUnits = product.NumberOfUnits - numberOfUnits
            };

            return obj;
        }

        public static Brick SubtractingUnitsOfProduction(Brick product, int numberOfUnits)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            if (product.NumberOfUnits < numberOfUnits)
            {
                throw new ProductQuantityException("Cannot subtract more units than there are in the product.");
            }

            var obj = new Brick()
            {
                ProductName = product.ProductName,
                PurchaseCost = product.PurchaseCost,
                Margin = product.Margin,
                NumberOfUnits = product.NumberOfUnits - numberOfUnits
            };

            return obj;
        }

        public static Screw SubtractingUnitsOfProduction(Screw product, int numberOfUnits)
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
