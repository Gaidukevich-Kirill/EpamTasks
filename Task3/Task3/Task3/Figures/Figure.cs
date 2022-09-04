using System;
using System.Collections.Generic;
using System.Text;
using Task3.Colors;
using Task3.Exceptions;

namespace Task3.Figures
{
    public abstract class Figure
    {
        public double Side { get; set; }
        
        public Color ColorFigure { get; set; }

        public void PaintFigure(Color color)
        {
            if (this.GetType() == typeof(FilmCircle) ||
                this.GetType() == typeof(FilmEquilateralTriangle) ||
                this.GetType() == typeof(FilmSquare))
            {
                throw new PaintException("Cannot paint this figure.");
            }

            if (this.GetType() == typeof(PaperCircle) ||
                this.GetType() == typeof(PaperEquilateralTriangle) ||
                this.GetType() == typeof(PaperSquare))
            {
                if (this.ColorFigure != Color.WithoutColor)
                {
                    throw new PaintException("Cannot paint this figure.");
                }
            }

            this.ColorFigure = color;
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
