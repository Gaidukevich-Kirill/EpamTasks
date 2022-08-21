using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Task2.Products;

namespace Task2.Infrastructure
{
    public static class JsonWriter<T>
    {
        public static void JsonWriterInFile(List<T> listBricks, string path)
        {
            var sw = new StreamWriter(path);

            var informationOfObject = JsonConvert.SerializeObject(listBricks);
            sw.WriteLine(informationOfObject);
            sw.Close();
        }
    }
}
