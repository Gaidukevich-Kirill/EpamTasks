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
                throw new Exception("Products have different Product Name");
            }
        }

        public static Brick AdditionOfTwoProducts(Brick leftProduct, Brick rightProduct)
        {
            if (leftProduct.ProductName.Equals(rightProduct.ProductName, StringComparison.InvariantCultureIgnoreCase))
            {
                var obj = new Brick("", 0, 0, 0)
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
                throw new Exception("Products have different Product Name");
            }
        }

        public static Screw AdditionOfTwoProducts(Screw leftProduct, Screw rightProduct)
        {
            if (leftProduct.ProductName.Equals(rightProduct.ProductName, StringComparison.InvariantCultureIgnoreCase))
            {
                var obj = new Screw("", 0, 0, 0)
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
                throw new Exception("Products have different Product Name");
            }
        }

        public static Bolt SubtractingUnitsOfProduction(Bolt product, int numberOfUnits)
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
                throw new Exception("Cannot subtract more units than there are in the product.");
            }
            
            return obj;
        }

        public static Brick SubtractingUnitsOfProduction(Brick product, int numberOfUnits)
        {
            var obj = new Brick("", 0, 0, 0)
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
                throw new Exception("Cannot subtract more units than there are in the product.");
            }

            return obj;
        }

        public static Screw SubtractingUnitsOfProduction(Screw product, int numberOfUnits)
        {
            var obj = new Screw("", 0, 0, 0)
            {
                ProductName = product.ProductName,
                PurchaseCost = product.PurchaseCost,
                Margin = product.Margin,
            };

            if (product.NumberOfUnits >= numberOfUnits)
            {
                obj.NumberOfUnits = product.NumberOfUnits - numberOfUnits;
            }
            else
            {
                throw new Exception("Cannot subtract more units than there are in the product.");
            }

            return obj;
        }
    }
}
