using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Products
{
    public abstract class Product
    {
        public string ProductName { get; set; }

        public double PurchaseCost { get; set; }

        public double Margin { get; set; }

        public int NumberOfUnits { get; set; }

        public Product(string productName, double purchaseCost, double margin, int numberOfUnits)
        {
            ProductName = productName;
            PurchaseCost = purchaseCost;
            Margin = margin;
            NumberOfUnits = numberOfUnits;
        }

        public double ProductCostByOneUnit
        {
            get
            {
                return Math.Round(PurchaseCost * Margin, 2);
            }
        }

        public double TotalCost
        {
            get
            {
                return Math.Round(PurchaseCost * Margin * NumberOfUnits, 2);
            } 
        }

        public static explicit operator int(Product product)
        {
            return (int)(product.PurchaseCost * 100);
        }

        public static explicit operator float(Product product)
        {
            return (float)(product.PurchaseCost);
        }
    }
}
