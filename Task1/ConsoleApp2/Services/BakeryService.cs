using System;
using System.Collections.Generic;
using System.Text;
using Task1.Components;
using Task1.Products;

namespace Task1.Services
{
    public static class BakeryService
    {
        public static List<BakeryProducts> SearchByCaloriesAndPrice(
            List<BakeryProducts> menuProductsBase, 
            int price,
            int calories)
        {
            var result = new List<BakeryProducts>();

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
            var result = new List<BakeryProducts>();

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
