using System;
using System.Collections.Generic;
using ConsoleApp2.Components;
using ConsoleApp2.Products;
using ConsoleApp2.Comparers;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            WhiteBread WhiteBread = new WhiteBread();
            WhiteBread.ProductID = 1;
            WhiteBread.ProductName = "White Bread";

            Bread Bread = new Bread();
            Bread.ProductID = 2;
            Bread.ProductName = "Bread";
            
            Baguette Baguette = new Baguette();
            Baguette.ProductID = 3;
            Baguette.ProductName = "Baget";

            List<BakeryProducts> MenuProductsBase = new List<BakeryProducts>();
            MenuProductsBase.Add(WhiteBread);
            MenuProductsBase.Add(Bread);
            MenuProductsBase.Add(Baguette);

            foreach (var item in MenuProductsBase)
            {
                Console.WriteLine(
                    $"Calories/Price {item.ProductName}:{item.ProductCalories}/{item.ProductPrice, 2} rub");
            }

            Console.WriteLine();
            Console.WriteLine("Default list");
            foreach (var component in MenuProductsBase)
            {
                Console.WriteLine(component.ProductName);
            }

            Console.WriteLine();
            Console.WriteLine("Sort by price");
            List<BakeryProducts> MenuProdustsSortByPrice = new List<BakeryProducts>(MenuProductsBase); //copy list
            MenuProdustsSortByPrice.Sort(new BakeryProductPriceComparer(TypeOfSort.Ascending));
            foreach (var component in MenuProdustsSortByPrice)
            {
                Console.WriteLine(component.ProductName);
            }

            Console.WriteLine();
            Console.WriteLine("Sort by calories");
            List<BakeryProducts> MenuProdustsSortByCalories = new List<BakeryProducts>(MenuProductsBase); //copy list
            MenuProdustsSortByCalories.Sort(new BakeryProductCaloriesComparer(TypeOfSort.Ascending));
            foreach (var component in MenuProdustsSortByCalories)
            {
                Console.WriteLine(component.ProductName);
            }

            Console.WriteLine();
            Console.WriteLine("Search product by Calories & Price 116/150");
            
            List<BakeryProducts> SearchByCaloriesAndPriceList = new List<BakeryProducts>();
            SearchByCaloriesAndPriceMethod(116, 150);

            foreach (var product in SearchByCaloriesAndPriceList)
            {
                Console.WriteLine(product.ProductName);
            }
            





            void SearchByCaloriesAndPriceMethod(int calories, int price)
            {
                foreach (var product in MenuProductsBase)
                {
                    if (product.ProductCalories == calories && product.ProductPrice == price)
                    {
                        SearchByCaloriesAndPriceList.Add(product);
                    }
                }
            }
        }






    }
}
