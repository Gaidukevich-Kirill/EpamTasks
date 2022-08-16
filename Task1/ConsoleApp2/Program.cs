using System;
using System.Collections.Generic;
using ConsoleApp2.Components;
using ConsoleApp2.Products;
using ConsoleApp2.Comparers;
using ConsoleApp2.Services;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread
            {
                ProductId = 1,
                ProductName = "Bread",
                Compounds =
                {
                    new Flour(50, 100, 5),
                    new Water(0, 0, 3),
                    new Salt(10, 10, 1),
                }
            };

            WhiteBread whiteBread = new WhiteBread
            {
                ProductId = 2,
                ProductName = "White Bread",
                Compounds =
                {
                    new Flour(40, 40, 4),
                    new Water(0, 0, 2),
                    new Salt(10, 10, 1),
                    new Sugar(20, 20, 2),
                    new Egg(20, 20, 2),
                }
            };

            Baguette baguette = new Baguette
            {
                ProductId = 3,
                ProductName = "Baguette",
                Compounds =
                {
                    new Flour(30, 30, 3),
                    new Water(0, 0, 1),
                    new Sugar(30, 30, 3),
                    new Salt(10, 10, 1),
                    new Egg(30, 30, 3)
                }
            };

            List<BakeryProducts> menuProductsBase = new List<BakeryProducts>
            {
                bread,
                whiteBread,
                baguette
            };

            Console.WriteLine("Default list");
            foreach (var item in menuProductsBase)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            Console.WriteLine();
            Console.WriteLine("Sort by price");
            List<BakeryProducts> menuProdustsSortByPrice = new List<BakeryProducts>(menuProductsBase); //copy list
            
            menuProdustsSortByPrice.Sort(new BakeryProductPriceComparer(TypeOfSort.Ascending));
            foreach (var item in menuProdustsSortByPrice)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            Console.WriteLine();
            Console.WriteLine("Sort by calories");
            List<BakeryProducts> menuProdustsSortByCalories = new List<BakeryProducts>(menuProductsBase); //copy list
            
            menuProdustsSortByCalories.Sort(new BakeryProductCaloriesComparer(TypeOfSort.Ascending));
            foreach (var item in menuProdustsSortByCalories)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }
            
            Console.WriteLine();
            Console.WriteLine("Search product by Price & Calories 99/90");
            var searchByCaloriesAndPriceList = BakerService.SearchByCaloriesAndPrice(menuProductsBase, 99, 90);
            foreach (var item in searchByCaloriesAndPriceList)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }



            Console.WriteLine();
            Console.WriteLine("Search product by number of components");
            var searchByVolumeOfComponentsList = BakerService.SearchByVolumeOfComponents(menuProductsBase, 4); //4 components
            foreach (var item in searchByVolumeOfComponentsList)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            

            
        }






    }
}
