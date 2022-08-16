using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp2.Components
{
    public abstract class Compound
    {
        public int Cost { get; set; }
        public int Calories { get; set; }
        public int Volume { get; set; }

        public Compound(int cost, int calories, int volume)
        {
            Cost = cost;
            Calories = calories;
            Volume = volume;
        }

    }
}
