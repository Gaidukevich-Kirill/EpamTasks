using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;
using Task3.Exceptions;

namespace Task3.Services
{
    public abstract class CarveFigures
    {
        //---------------------------------------------------------Carving triangle-------------------------------------------
        public static EquilateralTriangle CarvingEquilateralTriangleFromCircle(ref Circle circle, double side)
        {
            if (side <= circle.Radius * Math.Sqrt(3))
            {
                var newEquilateralTriangle = new EquilateralTriangle(side);
                circle = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static EquilateralTriangle CarvingEquilateralTriangleFromSquare(ref SquareFigure square, double side)
        {
            if (side * Math.Sqrt(3) / 2 <= square.Side * Math.Sqrt(2))
            {
                var newEquilateralTriangle = new EquilateralTriangle(side);
                square = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //---------------------------------------------------------Carving circle-------------------------------------------
        public static Circle CarvingCircleFromEquilateralTriangle(ref EquilateralTriangle triangle, double radius)
        {
            if (radius <= triangle.Side / (2 * Math.Sqrt(3)))
            {
                var newCircle = new Circle(radius);
                triangle = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static Circle CarvingCircleFromSquare(ref SquareFigure square, double radius)
        {
            if (radius <= square.Side / 2)
            {
                var newCircle = new Circle(radius);
                square = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //---------------------------------------------------------Carving square-------------------------------------------
        public static SquareFigure CarvingSquareFromEquilateralTriangle(ref EquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (1 + 2 / Math.Sqrt(3)))
            {
                var newSquare = new SquareFigure(side);
                triangle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static SquareFigure CarvingSquareFromCircle(ref Circle circle, double side)
        {
            if (side * Math.Sqrt(2) <= circle.Radius * 2)
            {
                var newSquare = new SquareFigure(side);
                circle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }
    }
}
