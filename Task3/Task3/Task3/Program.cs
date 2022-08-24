using System;
using Task3.Figures;
using Task3.Services;
using Task3.Boxes;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle(10);

            Console.WriteLine(circle1.Perimeter);
            Console.WriteLine(circle1.Square);

            var triangle1 = CarveFigures.CarvingEquilateralTriangleFromCircle(ref circle1, 5);

            Console.WriteLine(triangle1.Side);

            var box1 = new Box();
            
            box1.BoxFigures
            

        }
    }
}
