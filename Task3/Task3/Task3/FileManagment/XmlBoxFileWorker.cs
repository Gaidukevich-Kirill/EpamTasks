using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Task3.Boxes;
using Task3.Figures;

namespace Task3.FileManagment
{
    public class XmlBoxFileWorker : IBoxFileWorker
    {
        public void SaveFileXml(string path, Box box)
        {
            var xmlSerializer = new XmlSerializer(typeof(Box));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, box);

                Console.WriteLine("Object has been serialized");
            }
        }

        public void SaveFileSw(string path, Box box)
        {
            throw new NotImplementedException();
        }

        public Box LoadFileXml(string filename)
        {
            throw new NotImplementedException();
        }

        public Box LoadFileSw(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
