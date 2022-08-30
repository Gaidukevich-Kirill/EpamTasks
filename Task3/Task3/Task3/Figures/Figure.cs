using System;
using System.Collections.Generic;
using System.Text;
using Task3.Colors;

namespace Task3.Figures
{
    public abstract class Figure
    {
        public double Side { get; set; }

        /*public string Color
        {
            get
            {
                return Colors.Color.WithoutColor(string);
            }

            set
            {
                value = Colors.Color.WithoutColor;
            }
        }*/
    }
}
