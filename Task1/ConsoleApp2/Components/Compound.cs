using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Components
{
    public abstract class Compound
    {
        public int Cost { get; set; }
        public int Calories { get; set; }
        public Compound(int cost, int calories)
        {
            Cost = cost;
            Calories = calories;
        }
    }
}
