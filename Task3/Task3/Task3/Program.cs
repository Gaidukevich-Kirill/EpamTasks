using System;
using System.Collections.Generic;
using Task3.Figures;
using Task3.Services;
using Task3.Boxes;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new FilmCircle(10);

            //Console.WriteLine(circle1.Perimeter);
            //Console.WriteLine(circle1.Square);

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
            box1.RemoveFigure(5);
            box1.ShowItems();
            

        }
    }
}
