using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Task5.FileManagment
{
    public class XmlTreeWorker : ITreeXmlWorker
    {
        public void SaveTreeFileXml(string path, Tree<Student> tree)
        {
            var xmlSerializer = new XmlSerializer(typeof(Tree<Student>));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, tree);

                Console.WriteLine("Object has been serialized");
            }
        }
    }
}
