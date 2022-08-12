using System;
using System.Collections.Generic;
using ConsoleApp2.Components;
using ConsoleApp2.Products;

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

            Console.WriteLine($"Calories/Price {WhiteBread.ProductName}:{WhiteBread.ProductCalories}/{Math.Round(WhiteBread.ProductPrice, 2)} rub");
            Console.WriteLine($"Calories/Price {Bread.ProductName}:{Bread.ProductCalories}/{Math.Round(Bread.ProductPrice, 2)} rub");
            Console.WriteLine($"Calories/Price {Baguette.ProductName}:{Baguette.ProductCalories}/{Math.Round(Baguette.ProductPrice, 2)} rub");
            
            List<BakeryProducts> MenuProductsBase = new List<BakeryProducts>();
            MenuProductsBase.Add(WhiteBread);
            MenuProductsBase.Add(Bread);
            MenuProductsBase.Add(Baguette);

            foreach(var component in MenuProductsBase)
            {
                Console.WriteLine(component.ProductName);
            }

            Console.WriteLine();
            Console.WriteLine("Sort by price");
            
            List<BakeryProducts> MenuProdustsSortByPrice = new List<BakeryProducts>(MenuProductsBase); //copy list

            


            foreach (var component in MenuProdustsSortByPrice)
            {
                Console.WriteLine(component.ProductName);
            }

            
            
            /*for(int i = 0; i < MenuProductsBase.Count; i++)
            {
                
            }*/

            Console.WriteLine("Sort by calories");

        }

        




    }
}
