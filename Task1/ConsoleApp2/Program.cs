using System;
using System.Collections.Generic;
using ConsoleApp2.Components;
using ConsoleApp2.Products;

namespace ConsoleApp2
{
    public class Program
    {
        //private static int index = 0;

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

            Console.WriteLine($"Calories {WhiteBread.ProductName}:{WhiteBread.ProductCalories}");
            Console.WriteLine($"Price {WhiteBread.ProductName}:{Math.Round(WhiteBread.ProductPrice, 2)} rub");

            Console.WriteLine($"Calories {Bread.ProductName}:{Bread.ProductCalories}");
            Console.WriteLine($"Price {Bread.ProductName}:{Math.Round(Bread.ProductPrice, 2)} rub");

            Console.WriteLine($"Calories {Baguette.ProductName}:{Baguette.ProductCalories}");
            Console.WriteLine($"Price {Baguette.ProductName}:{Math.Round(Baguette.ProductPrice, 2)} rub");























            /*    List<string> menuItems = new List<string>(){
                "one",
                "two",
                "Exit"
                };

                Console.CursorVisible = false;

                while (true)
                {
                    string selectedMenuItem = drawMenu(menuItems);
                    if (selectedMenuItem == "one")
                    {
                        Console.Clear();
                        Console.WriteLine("Hello");
                        Console.Read();
                        Console.Clear();
                    }
                    else if (selectedMenuItem == "Exit")
                    {
                        Environment.Exit(0);
                    }
                }

                static string drawMenu(List<string> items)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (i == index)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine(items[i]);
                        }
                        else
                        {
                            Console.WriteLine(items[i]);
                        }
                        Console.ResetColor();
                    }

                    ConsoleKeyInfo ckey = Console.ReadKey();

                    if (ckey.Key == ConsoleKey.DownArrow)
                    {
                        if (index == items.Count - 1)
                        {
                            //index = 0;
                        }
                        else { index++; }
                    }
                    else if (ckey.Key == ConsoleKey.UpArrow)
                    {
                        if (index <= 0)
                        {
                            //index = menuItem.Count - 1;
                        }
                        else { index--; }
                    }
                    else if (ckey.Key == ConsoleKey.Enter)
                    {
                        return items[index];
                    }
                    else
                    {
                        return "";
                    }

                    Console.Clear();
                    return "";
                }*/
        }
    }
}
