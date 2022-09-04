using System;
using System.Collections.Generic;
using System.Text;
using Task3.Boxes;
using Task3.Figures;

namespace Task3.FileManagment
{
    public class XmlBoxFileWorker : IBoxFileWorker
    {
        public Box LoadFile(string filename)
        {
            throw new NotImplementedException();
        }

        public void SaveFile(string path, Box box)
        {
            /*using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLineAsync("qwe");
            }*/

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Box));

            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, box);
            file.Close();
        }
    }
}
