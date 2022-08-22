using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Figures
{
    public class Rectangle : Figure
    {
        private double Height { get; set; }

        private double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Perimeter
        {
            get
            {
                return Height * 2 + Width * 2;
            }
        }

        public double Square
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
