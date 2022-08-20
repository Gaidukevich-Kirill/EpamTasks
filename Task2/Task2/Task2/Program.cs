using System;
using System.Collections.Generic;
using Task2.Products;
using Task2.Services;
using Newtonsoft;
using Newtonsoft.Json;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brick1 = new Brick("Brick Red", 3, 1.23, 5);
            var brick2 = new Brick("Brick RED", 5, 1.25, 6);
            var brickResult = ServicesByProduct.AdditionOfTwoProducts(brick1, brick2);

            List<Brick> listBricks = new List<Brick>();
            listBricks.Add(brick1);
            listBricks.Add(brick2);
            listBricks.Add(brickResult);

            foreach (var item in listBricks)
            {
                Console.WriteLine($"Product name: {item.ProductName}, Purchase Cost: {item.PurchaseCost}, " +
                                  $"Margin: {item.Margin}, Number of units: {item.NumberOfUnits}, " +
                                  $"Cost by one unit: {item.ProductCostByOneUnit}, Total cost: {item.TotalCost}");
            }

            var brickResultMinusUnits = ServicesByProduct.SubtractingUnitsOfProduction(brickResult, 3);
            listBricks.Add(brickResultMinusUnits);

            Console.WriteLine();
            foreach (var item in listBricks)
            {
                Console.WriteLine($"Product name: {item.ProductName}, Purchase Cost: {item.PurchaseCost}, " +
                                  $"Margin: {item.Margin}, Number of units: {item.NumberOfUnits}, " +
                                  $"Cost by one unit: {item.ProductCostByOneUnit}, Total cost: {item.TotalCost}");
            }
        }

        Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
    }
}
