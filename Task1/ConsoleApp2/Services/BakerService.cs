using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;
using ConsoleApp2.Products;

namespace ConsoleApp2.Services
{
    public static class BakerService
    {
        public static List<BakeryProducts> SearchByCaloriesAndPrice(List<BakeryProducts> menuProductsBase, int price,
            int calories)
        {
            List<BakeryProducts> result = new List<BakeryProducts>();

            foreach (var item in menuProductsBase)
            {
                if (item.ProductPrice == price && item.ProductCalories == calories)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static List<BakeryProducts> SearchByVolumeOfComponents(List<BakeryProducts> menuProductsBase, int volume)
        {
            List<BakeryProducts> result = new List<BakeryProducts>();

            foreach (var item in menuProductsBase)
            {
                if (item.Compounds.Count >= volume)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
