using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Task3.Boxes;
using Task3.Figures;
using Task3.Infrastructure;

namespace Task3.FileManagment
{
    public class XmlBoxFileWorker : IBoxFileWorker
    {
        //----------------------------------xml
        public void SaveAllFiguresFileXml(string path, Box box)
        {
            var xmlSerializer = new XmlSerializer(typeof(Box));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, box);

                Console.WriteLine("Object has been serialized");
            }
        }

        public void SaveFilmFiguresFileXml(string path, Box box)
        {
            var boxFilmFigures = new Box();
            var xmlSerializer = new XmlSerializer(typeof(Box));

            foreach (var  figure in box.BoxOfFigures)
            {
                if (IsTypeFilm.CheckType(figure.GetType()))
                {
                    boxFilmFigures.AddFigure(figure);
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, boxFilmFigures);

                Console.WriteLine("Object has been serialized");
            }
        }

        public void SavePaperFigureFileXml(string path, Box box)
        {
            var boxPaperFigures = new Box();
            var xmlSerializer = new XmlSerializer(typeof(Box));

            foreach (var figure in box.BoxOfFigures)
            {
                if (IsTypePaper.CheckType(figure.GetType()))
                {
                    boxPaperFigures.AddFigure(figure);
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, boxPaperFigures);

                Console.WriteLine("Object has been serialized");
            }
        }

        public void SavePlasticFigureFileXml(string path, Box box)
        {
            var boxPlasticBox = new Box();
            var xmlSerializer = new XmlSerializer(typeof(Box));

            foreach (var figure in box.BoxOfFigures)
            {
                if (IsTypePlastic.CheckType(figure.GetType()))
                {
                    boxPlasticBox.AddFigure(figure);
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, boxPlasticBox);

                Console.WriteLine("Object has been serialized");
            }
        }

        public Box LoadFiguresFileXml(string path)
        {
            Box box;
            var xmlSerializer = new XmlSerializer(typeof(Box));

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                box = xmlSerializer.Deserialize(fs) as Box;

                Console.WriteLine("Object has been deserialized");
            }

            return box;
        }

        //---------------------------------------StreamWriter

        public void SaveAllFiguresFileSw(string path, Box box)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Box));
            
            StreamWriter myWriter = new StreamWriter(path);
            mySerializer.Serialize(myWriter, box);
            myWriter.Close();
        }

        public void SaveFilmFiguresFileSw(string path, Box box)
        {
            var boxFilmFigures = new Box();
            var mySerializer = new XmlSerializer(typeof(Box));

            foreach (var figure in box.BoxOfFigures)
            {
                if (IsTypeFilm.CheckType(figure.GetType()))
                {
                    boxFilmFigures.AddFigure(figure);
                }
            }

            StreamWriter myWriter = new StreamWriter(path);
            mySerializer.Serialize(myWriter, boxFilmFigures);
            myWriter.Close();
        }

        public void SavePaperFigureFileSw(string path, Box box)
        {
            var boxPaperFigures = new Box();
            var mySerializer = new XmlSerializer(typeof(Box));

            foreach (var figure in box.BoxOfFigures)
            {
                if (IsTypePaper.CheckType(figure.GetType()))
                {
                    boxPaperFigures.AddFigure(figure);
                }
            }

            StreamWriter myWriter = new StreamWriter(path);
            mySerializer.Serialize(myWriter, boxPaperFigures);
            myWriter.Close();
        }

        public void SavePlasticFigureFileSw(string path, Box box)
        {
            var boxPlasticFigures = new Box();
            var mySerializer = new XmlSerializer(typeof(Box));

            foreach (var figure in box.BoxOfFigures)
            {
                if (IsTypePlastic.CheckType(figure.GetType()))
                {
                    boxPlasticFigures.AddFigure(figure);
                }
            }

            StreamWriter myWriter = new StreamWriter(path);
            mySerializer.Serialize(myWriter, boxPlasticFigures);
            myWriter.Close();
        }

        public Box LoadFiguresFileSw(string path)
        {
            Box box;
            var xmlSerializer = new XmlSerializer(typeof(Box));

            StreamReader myReader = new StreamReader(path);
            box = xmlSerializer.Deserialize(myReader) as Box;
            Console.WriteLine("Object has been deserialized");
            myReader.Close();

            return box;
        }
    }
}
