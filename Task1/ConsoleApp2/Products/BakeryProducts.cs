using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Components;

namespace ConsoleApp2.Products
{
    public abstract class BakeryProducts
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public List<Compound> Compounds { get; } = new List<Compound>();

        public double ProductCalories
        {
            get
            {
                double productCalories = 0;
                foreach (var compound in Compounds)
                {
                    productCalories += compound.Calories;
                }

                return productCalories;
            }
        }


    }

}
