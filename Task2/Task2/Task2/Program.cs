using System;
using System.Collections.Generic;
using System.IO;
using Task2.Products;
using Task2.Services;
using Newtonsoft;
using Newtonsoft.Json;
using Task2.Infrastructure;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var brick1 = new Brick(
                "Brick Red", 
                3, 
                1.23, 
                5);
            var brick2 = new Brick(
                "Brick RED", 
                5, 
                1.25, 
                6);
            
            var brickResult1 = ServicesByProduct.AdditionOfTwoProducts(brick1, brick2);
            var brickResult2 = brick1 + brick2;

            var listBricks = new List<Brick>
            {
                brick1,
                brick2,
                brickResult1,
                brickResult2
            };

            foreach (var brick in listBricks)
            {
                Console.WriteLine($"Product name: {brick.ProductName}, Purchase Cost: {brick.PurchaseCost}, " +
                                  $"Margin: {brick.Margin}, Number of units: {brick.NumberOfUnits}, " +
                                  $"Cost by one unit: {brick.ProductCostByOneUnit}, Total cost: {brick.TotalCost}");
            }

            var brickResultMinusUnits1 = ServicesByProduct.SubtractingUnitsOfProduction(brickResult1, 3);
            listBricks.Add(brickResultMinusUnits1);
            var brickResultMinusUnits2 = brickResult2 - 2;
            listBricks.Add(brickResultMinusUnits2);

            Console.WriteLine();
            foreach (var brick in listBricks)
            {
                Console.WriteLine($"Product name: {brick.ProductName}, Purchase Cost: {brick.PurchaseCost}, " +
                                  $"Margin: {brick.Margin}, Number of units: {brick.NumberOfUnits}, " +
                                  $"Cost by one unit: {brick.ProductCostByOneUnit}, Total cost: {brick.TotalCost}");
            }

            var allCost = (int)brick1;
            var allCost2 = (float)brick1;
            Console.WriteLine($"brick1 in int: {allCost}, brick1 in float: {allCost2}");

            var path = "E:/prg/Task2/Task2/Test.txt";
            Infrastructure.JsonWriter<List<Brick>>.WriterInFile(listBricks, path);
            
            var newListBricks = Infrastructure.JsonReader<List<Brick>>.ReadFromFile(path);
            Console.WriteLine();
            Console.WriteLine("After reading from file");
            foreach (var brick in newListBricks)
            {
                Console.WriteLine($"Product name: {brick.ProductName}, Purchase Cost: {brick.PurchaseCost}, " +
                                  $"Margin: {brick.Margin}, Number of units: {brick.NumberOfUnits}, " +
                                  $"Cost by one unit: {brick.ProductCostByOneUnit}, Total cost: {brick.TotalCost}");
            }
        }
    }
}
