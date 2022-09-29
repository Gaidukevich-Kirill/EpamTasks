using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Task3.Colors;
using Task3.Exceptions;
using Task3.Figures;
using Task3.FileManagment;
using Task3.Infrastructure;

namespace Task3.Boxes
{
    public class Box
    {
        public List<Figure> BoxOfFigures = new List<Figure>(20);
        
        private readonly IBoxFileWorker _boxFileWorker;

        public Box()
        {

        }

        public Box(IBoxFileWorker boxFileWorker)
        {
            _boxFileWorker = boxFileWorker;
        }

        public void AddFigure(Figure item)
        {
            var alreadyExist = true;

            foreach (var figure in BoxOfFigures)
            {
                if (item.GetType() == figure.GetType() &&
                    item.Side == figure.Side &&
                    item.Area == figure.Area)
                {
                    alreadyExist = false;
                }
            }

            if (alreadyExist == false)
            {
                throw new AddException("This figure is already in the box");
            }
            
            BoxOfFigures.Add(item);
        }

        public void CheckFigureByNumber(int number)
        {
            Console.WriteLine($"{BoxOfFigures[number-1]}, {BoxOfFigures[number-1].Side}");
        }

        public void RemoveFigure(int number)
        {
            BoxOfFigures.Remove(BoxOfFigures[number - 1]);
            Console.WriteLine(
                $"Figure {BoxOfFigures[number - 1]}, {BoxOfFigures[number - 1].Side} " +
                $"with {number} position was deleted");
        }

        public void ReplaceFigure(Figure item, int position)
        {
            BoxOfFigures.Remove(BoxOfFigures[position-1]);
            BoxOfFigures.Insert(position-1, item);
        }

        public void CompareFigures(Figure item)
        {
            var sameExist = false;
            var position = 0;

            foreach (var figure in BoxOfFigures)
            {
                if (item.GetType() == figure.GetType() && 
                    item.Side == figure.Side &&
                    item.Area == figure.Area)
                {
                    sameExist = true;
                    position = BoxOfFigures.IndexOf(figure);
                }
            }

            if (sameExist == false)
            {
                throw new CompareException("Figure isn't found.");
            }

            Console.WriteLine(
                    $"The list has equivalent figure: {BoxOfFigures[position]}, " + 
                    $"with side: {BoxOfFigures[position].Side}");
        }

        public void AmountFigures()
        {
            Console.WriteLine(BoxOfFigures.Count);
        }

        public void PerimeterAllFigures()
        {
            double perimeter = 0;

            foreach (var figure in BoxOfFigures)
            {
                perimeter += figure.Perimeter;
            }

            Console.WriteLine($"Perimeter of all figures in the box: {perimeter}");
        }

        public void AreaAllFigures()
        {
            double area = 0;

            foreach (var figure in BoxOfFigures)
            {
                area += figure.Area;
            }

            Console.WriteLine($"Area of all figures in the box: {area}");
        }

        public void TakeOutAllCircles()
        {
            for (int index = 0; index < BoxOfFigures.Count; index++)
            {
                if (IsTypeCircle.CheckType(BoxOfFigures[index].GetType()))
                {
                    BoxOfFigures.Remove(BoxOfFigures[index]);
                    index--;
                }
            }
        }

        public void TakeOutAllFilmFigures()
        {
            for (int i = 0; i < BoxOfFigures.Count; i++)
            {
                if (IsTypeFilm.CheckType(this.GetType()))
                {
                    BoxOfFigures.Remove(BoxOfFigures[i]);
                    i--;
                }
            }
        }

        public void TakeOutAllPlasticClearFigures()
        {
            for (int i = 0; i < BoxOfFigures.Count; i++)
            {
                if (IsTypePlastic.CheckType(this.GetType()) &&
                    BoxOfFigures[i].ColorFigure == Color.WithoutColor)
                {
                    BoxOfFigures.Remove(BoxOfFigures[i]);
                    i--;
                }
            }
        }
    }
}
