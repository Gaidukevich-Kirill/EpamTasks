using System;
using System.Collections.Generic;
using System.Text;
using Task3.Colors;

namespace Task3.Figures
{
    public abstract class Figure
    {
        public double Side { get; set; }

        public Color ColorFigure { get; set; }

        public void PaintFigure(int number)
        {
            switch (number)
            {
                case 1: ColorFigure = Color.Red;
                    break;
                case 2: ColorFigure = Color.Green;
                    break;
                case 3: 
                    ColorFigure = Color.Blue;
                    break;
                default: Console.WriteLine("Cannot use this color.");
                    break;
            }

            Console.WriteLine($"Color is {ColorFigure}");
        }

        public abstract double Perimeter
        {
            get;
        }

        public abstract double Area
        {
            get;
        }
    }
}
