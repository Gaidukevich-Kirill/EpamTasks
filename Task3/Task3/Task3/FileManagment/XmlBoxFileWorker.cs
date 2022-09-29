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

        public void SaveFiguresFileXml(string path, Box box, Type type = null)
        {
            var xmlSerializer = new XmlSerializer(typeof(Box));

            if (type == null)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, box);

                    Console.WriteLine("Object has been serialized");
                }
                
                return;
            }

            var boxFiguresForFile = new Box();
            
            foreach (var figure in box.BoxOfFigures)
            {
                if (type == figure.GetType())
                {
                    boxFiguresForFile.AddFigure(figure);
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, boxFiguresForFile);

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
        public void SaveFiguresFileSw(string path, Box box, Type type = null)
        {
            var mySerializer = new XmlSerializer(typeof(Box));
            var myWriter = new StreamWriter(path);

            if (type == null)
            {

                mySerializer.Serialize(myWriter, box);
                myWriter.Close();

                return;
            }

            var boxFilmFigures = new Box();
            foreach (var figure in box.BoxOfFigures)
            {
                if (type == figure.GetType())
                {
                    boxFilmFigures.AddFigure(figure);
                }
            }

            mySerializer.Serialize(myWriter, boxFilmFigures);
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
