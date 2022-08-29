using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figures;
using Task3.Exceptions;

namespace Task3.Services
{
    public abstract class CarveFigure
    {
        //---------------------------------------------------------Carving triangle-------------------------------------------
        //-------------Film
        public static FilmEquilateralTriangle EquilateralTriangleFromCircle(ref FilmCircle circle, double side)
        {
            if (side <= circle.Side * Math.Sqrt(3))
            {
                var newEquilateralTriangle = new FilmEquilateralTriangle(side);
                circle = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static FilmEquilateralTriangle EquilateralTriangleFromSquare(ref FilmSquare square, double side)
        {
            if (side * Math.Sqrt(3) / 2 <= square.Side * Math.Sqrt(2))
            {
                var newEquilateralTriangle = new FilmEquilateralTriangle(side);
                square = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Paper
        public static PaperEquilateralTriangle EquilateralTriangleFromCircle(ref PaperCircle circle, double side)
        {
            if (side <= circle.Side * Math.Sqrt(3))
            {
                var newEquilateralTriangle = new PaperEquilateralTriangle(side);
                circle = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PaperEquilateralTriangle EquilateralTriangleFromSquare(ref PaperSquare square, double side)
        {
            if (side * Math.Sqrt(3) / 2 <= square.Side * Math.Sqrt(2))
            {
                var newEquilateralTriangle = new PaperEquilateralTriangle(side);
                square = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Plastic
        public static PlasticEquilateralTriangle EquilateralTriangleFromCircle(ref PlasticCircle circle, double side)
        {
            if (side <= circle.Side * Math.Sqrt(3))
            {
                var newEquilateralTriangle = new PlasticEquilateralTriangle(side);
                circle = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PlasticEquilateralTriangle EquilateralTriangleFromSquare(ref PlasticSquare square, double side)
        {
            if (side * Math.Sqrt(3) / 2 <= square.Side * Math.Sqrt(2))
            {
                var newEquilateralTriangle = new PlasticEquilateralTriangle(side);
                square = null;
                return newEquilateralTriangle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //---------------------------------------------------------Carving circle-------------------------------------------
        //-------------Film
        public static FilmCircle CircleFromEquilateralTriangle(ref FilmEquilateralTriangle triangle, double radius)
        {
            if (radius <= triangle.Side / (2 * Math.Sqrt(3)))
            {
                var newCircle = new FilmCircle(radius);
                triangle = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static FilmCircle CircleFromSquare(ref FilmSquare square, double radius)
        {
            if (radius <= square.Side / 2)
            {
                var newCircle = new FilmCircle(radius);
                square = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Paper
        public static PaperCircle CircleFromEquilateralTriangle(ref PaperEquilateralTriangle triangle, double radius)
        {
            if (radius <= triangle.Side / (2 * Math.Sqrt(3)))
            {
                var newCircle = new PaperCircle(radius);
                triangle = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PaperCircle CircleFromSquare(ref PaperSquare square, double radius)
        {
            if (radius <= square.Side / 2)
            {
                var newCircle = new PaperCircle(radius);
                square = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Plastic
        public static PlasticCircle CircleFromEquilateralTriangle(ref PlasticEquilateralTriangle triangle, double radius)
        {
            if (radius <= triangle.Side / (2 * Math.Sqrt(3)))
            {
                var newCircle = new PlasticCircle(radius);
                triangle = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PlasticCircle CircleFromSquare(ref PlasticSquare square, double radius)
        {
            if (radius <= square.Side / 2)
            {
                var newCircle = new PlasticCircle(radius);
                square = null;
                return newCircle;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //---------------------------------------------------------Carving square-------------------------------------------
        //-------------Film
        public static FilmSquare SquareFromEquilateralTriangle(ref FilmEquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (1 + 2 / Math.Sqrt(3)))
            {
                var newSquare = new FilmSquare(side);
                triangle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static FilmSquare SquareFromCircle(ref FilmCircle circle, double side)
        {
            if (side * Math.Sqrt(2) <= circle.Side * 2)
            {
                var newSquare = new FilmSquare(side);
                circle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Paper
        public static PaperSquare SquareFromEquilateralTriangle(ref PaperEquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (1 + 2 / Math.Sqrt(3)))
            {
                var newSquare = new PaperSquare(side);
                triangle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PaperSquare SquareFromCircle(ref PaperCircle circle, double side)
        {
            if (side * Math.Sqrt(2) <= circle.Side * 2)
            {
                var newSquare = new PaperSquare(side);
                circle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        //-------------Plastic
        public static PlasticSquare SquareFromEquilateralTriangle(ref PlasticEquilateralTriangle triangle, double side)
        {
            if (side <= triangle.Side / (1 + 2 / Math.Sqrt(3)))
            {
                var newSquare = new PlasticSquare(side);
                triangle = null;
                return newSquare;
            }
            else
            {
                throw new CarveException("It is impossible to carve this figure.");
            }
        }

        public static PlasticSquare SquareFromCircle(ref PlasticCircle circle, double side)
        {
            if (side * Math.Sqrt(2) <= circle.Side * 2)
            {
                var newSquare = new PlasticSquare(side);
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
