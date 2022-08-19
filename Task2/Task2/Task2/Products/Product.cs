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
            get => Math.Round(PurchaseCost * Margin, 2);
        }

        public double TotalCost
        {
            get => Math.Round(PurchaseCost * Margin * NumberOfUnits, 2);
        }
    }
}
