using System;
using System.Collections.Generic;
using System.Text;
using Task3.Colors;
using Task3.Exceptions;
using Task3.Infrastructure;

namespace Task3.Figures
{
    public abstract class Figure
    {
        public double Side { get; set; }
        
        public Color ColorFigure { get; set; }

        public Figure()
        {

        }

        private bool IsTypeFilm()
        {
            foreach (var type in FilmConsts.ValidFilmTypes)
            {
                if (GetType() == type)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsTypePaper()
        {
            foreach (var type in PaperConsts.ValidFilmTypes)
            {
                if (GetType() == type)
                {
                    return true;
                }
            }

            return false;
        }

        public void PaintFigure(Color color)
        {
            if (IsTypeFilm())
            {
                throw new PaintException("Cannot paint this figure.");
            }

            if (IsTypePaper())
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
