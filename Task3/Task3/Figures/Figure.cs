using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Task3.Colors;
using Task3.Exceptions;
using Task3.Infrastructure;

namespace Task3.Figures
{
    [XmlInclude(typeof(FilmCircle)), 
     XmlInclude(typeof(FilmEquilateralTriangle)),
     XmlInclude(typeof(FilmSquare)),
     XmlInclude(typeof(PaperCircle)),
     XmlInclude(typeof(PaperEquilateralTriangle)),
     XmlInclude(typeof(PaperSquare)),
     XmlInclude(typeof(PlasticCircle)),
     XmlInclude(typeof(PlasticEquilateralTriangle)),
     XmlInclude(typeof(PlasticSquare))]
    public abstract class Figure
    {
        public double Side { get; set; }
        
        public Color ColorFigure { get; set; }

        public Figure()
        {

        }

        public void PaintFigure(Color color)
        {
            if (IsTypeFilm.CheckType(this.GetType()))
            {
                throw new PaintException("Cannot paint this figure.");
            }

            if (IsTypePaper.CheckType(this.GetType()) && this.ColorFigure != Color.WithoutColor)
            {
                throw new PaintException("Cannot paint this figure.");
            }

            this.ColorFigure = color;
        }

        public abstract double Perimeter { get; }

        public abstract double Area { get; }
    }
}
