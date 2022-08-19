using System;
using System.Collections.Generic;
using Task2.Products;
using Task2.Services;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brick1 = new Brick("Brick", 3, 1.23, 5);
            var brick2 = new Brick("Brick", 5, 1.25, 6);
            var brickResult = ServicesByProduct.AdditionOfTwoProducts(brick1, brick2);

            List<Brick> listBricks = new List<Brick>();
            listBricks.Add(brick1);
            listBricks.Add(brick2);
            listBricks.Add(brickResult);

            foreach (var item in listBricks)
            {
                Console.WriteLine($"Purchase Cost: {item.PurchaseCost}, Margin: {item.Margin}, Number of units: {item.NumberOfUnits}" +
                                  $"Cost by one unit: {item.ProductCostByOneUnit}, Total cost: {item.TotalCost}");
            }
        }
    }
}
