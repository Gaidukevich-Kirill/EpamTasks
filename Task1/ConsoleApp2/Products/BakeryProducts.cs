using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Products
{
    public abstract class BakeryProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public List<Compound> Compounds { get; } = new List<Compound>();

        public int ProductCalories
        {
            get
            {
                int productCalories = 0;
                foreach (var compound in Compounds)
                {
                    productCalories += compound.Calories;
                }

                return productCalories;
            }
        }

        public abstract int ProductPrice
        {
            get;
        }

    }

}
