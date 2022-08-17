using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Task1.Components;

namespace Task1.Products
{
    public abstract class BakeryProducts
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public abstract int ProductPrice { get; }

        public List<Compound> Compounds { get; } = new List<Compound>();

        public int ProductCalories
        {
            get
            {
                var productCalories = 0;
                foreach (var compound in Compounds)
                {
                    productCalories += compound.Calories;
                }

                return productCalories;
            }
        }
    }
}
