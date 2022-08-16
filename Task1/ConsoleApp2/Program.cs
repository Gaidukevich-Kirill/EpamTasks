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
            var bread = new Bread
            {
                ProductId = 1,
                ProductName = "Bread",
                Compounds =
                {
                    new Flour(50, 100),
                    new Water(0, 0),
                    new Salt(10, 10),
                }
            };

            var whiteBread = new WhiteBread
            {
                ProductId = 2,
                ProductName = "White Bread",
                Compounds =
                {
                    new Flour(40, 40),
                    new Water(0, 0),
                    new Salt(10, 10),
                    new Sugar(20, 20),
                    new Egg(20, 20),
                }
            };

            var baguette = new Baguette
            {
                ProductId = 3,
                ProductName = "Baguette",
                Compounds =
                {
                    new Flour(30, 30),
                    new Water(0, 0),
                    new Sugar(30, 30),
                    new Salt(10, 10),
                    new Egg(30, 30)
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
            List<BakeryProducts> menuProduсtsSortByPrice = new List<BakeryProducts>(menuProductsBase); //copy list
            menuProduсtsSortByPrice.Sort(new BakeryProductPriceComparer(TypeOfSort.Ascending));
            foreach (var item in menuProduсtsSortByPrice)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            Console.WriteLine();
            Console.WriteLine("Sort by calories");
            List<BakeryProducts> menuProduсtsSortByCalories = new List<BakeryProducts>(menuProductsBase); //copy list
            menuProduсtsSortByCalories.Sort(new BakeryProductCaloriesComparer(TypeOfSort.Ascending));
            foreach (var item in menuProduсtsSortByCalories)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            Console.WriteLine();
            Console.WriteLine("Search product by Price & Calories 99/90");
            var searchByCaloriesAndPriceList = BakeryService.SearchByCaloriesAndPrice(menuProductsBase, 99, 90);
            foreach (var item in searchByCaloriesAndPriceList)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

            Console.WriteLine();
            Console.WriteLine("Search product by number of components >= 4");
            var searchByVolumeOfComponentsList = BakeryService.SearchByVolumeOfComponents(menuProductsBase, 4); //4 components
            foreach (var item in searchByVolumeOfComponentsList)
            {
                Console.WriteLine(
                    $"Price/Calories {item.ProductName}:{item.ProductPrice} rub/{item.ProductCalories} cal");
            }

        }

    }
}
