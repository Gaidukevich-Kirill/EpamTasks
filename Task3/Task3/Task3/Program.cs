using System;
using System.Collections.Generic;
using Task3.Figures;
using Task3.Services;
using Task3.Boxes;
using Task3.Sheets;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new FilmCircle(10);

            //Console.WriteLine(circle1.Perimeter);
            //Console.WriteLine(circle1.Area);

            var triangle1 = CarveFigure.EquilateralTriangleFromCircle(ref circle1, 5);
            var triangle2 = new FilmEquilateralTriangle(2);
            var triangle3 = new FilmEquilateralTriangle(3);
            var triangle4 = new FilmEquilateralTriangle(4);
            var triangle5 = new FilmEquilateralTriangle(6);

            //Console.WriteLine(triangle1.Side);

            var box1 = new Box();

            box1.AddFigure(triangle1);
            box1.AddFigure(triangle2);
            box1.AddFigure(triangle3);
            box1.AddFigure(triangle4);
            box1.AddFigure(triangle5);
            
            box1.CheckFigureByNumber(3);
            box1.RemoveFigure(3);
            box1.AmountFigures();

            var square1 = new PlasticSquare(8);
            box1.ReplaceFigure(square1, 3);
            box1.AmountFigures();

            var triangleCompare = new FilmEquilateralTriangle(2);
            box1.CompareFigures(triangleCompare);

            box1.PerimeterAllFigures();
            box1.AreaAllFigures();

            box1.AmountFigures();
            var circle2 = new FilmCircle(10);
            var circle3 = new FilmCircle(20);
            var circle4 = new FilmCircle(30);
            box1.AddFigure(circle2);
            box1.AddFigure(circle3);
            box1.AddFigure(circle4);
            box1.AmountFigures();
            //box1.TakeOutAllCircles();
            //box1.TakeOutAllFilmFigures();
            box1.AmountFigures();



            /*Console.WriteLine(typeof(IFilm));
            foreach (var c in triangle5.GetType().GetInterfaces())
            {
                Console.WriteLine(c.Name);
            }*/
        }
    }
}
