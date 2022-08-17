using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task1.Components
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
