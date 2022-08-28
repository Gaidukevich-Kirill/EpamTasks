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
        public List<object> BoxOfFigures = new List<object>();
        
        public void AddFigure<T>(T item)
        {
            BoxOfFigures.Add(item);

            /*bool alreadyExist = BoxOfFigures.Contains(item);

            if (alreadyExist == false)
            {
                Console.WriteLine(BoxOfFigures.Count);
                //throw new AddException("This figure is already in the box");
            }
            else
            {
                BoxOfFigures.Add(item);
            }*/
        }

        public void CheckFigureByNumber(int number)
        {
            Console.WriteLine(BoxOfFigures[number]);
        }

        public void RemoveFigure()
        {

        }

        public void ReplaceFigure()
        {

        }


        /*
        просмотреть по номеру (при этом фигура остается в коробке)
        извлечь по номеру (при этом фигура удаляется из коробки)
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
            Console.WriteLine(BoxOfFigures.Count);
        }
    }
}
