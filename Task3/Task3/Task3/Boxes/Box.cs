using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task3.Exceptions;
using Task3.Figures;

namespace Task3.Boxes
{
    public class Box
    {
        private readonly List<Figure> _boxOfFigures = new List<Figure>(20); //readonly?
        
        public void AddFigure(Figure item)
        {
            bool alreadyExist = true;

            foreach (var figure in _boxOfFigures)
            {
                if (item.GetType() == figure.GetType() && item.Side == figure.Side)
                {
                    alreadyExist = _boxOfFigures.Contains(item);
                }
            }

            if (alreadyExist == false)
            {
                throw new AddException("This figure is already in the box");
            }
            else
            {
                _boxOfFigures.Add(item);
            }
        }

        public void CheckFigureByNumber(int number)
        {
            Console.WriteLine($"{_boxOfFigures[number-1]}, {_boxOfFigures[number-1].Side}");
        }

        public void RemoveFigure(int number)
        {
            _boxOfFigures.Remove(_boxOfFigures[number-1]);
        }

        public void ReplaceFigure()
        {

        }


        /*
        заменить по номеру 
        //найти фигуру по образцу (эквивалентную по своим характеристикам)
        //показать наличное количество фигур
        суммарную площадь
        суммарный периметр
        достать все Круги
        достать все Пленочные фигуры
        достать все Пластиковые фигуры, которые ни разу не красились
        сохранить все фигуры / только бумажные / только пластиковые / только плёночные из коробки в XML-файл, используя StreamWriter
        сохранить все фигуры / только бумажные / только пластиковые / только плёночные из коробки в XML-файл, используя XmlWriter
         загрузить все фигуры в коробку из XML-файла, используя StreamReader
         загрузить все фигуры в коробку из XML-файла, используя XmlReader
        */

        public void ShowItems()
        {
            Console.WriteLine(_boxOfFigures.Count);
        }
    }
}
