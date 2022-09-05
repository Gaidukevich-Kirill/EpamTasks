using System;
using System.Collections.Generic;
using System.Text;
using Task3.Boxes;

namespace Task3.FileManagment
{
    public interface IBoxFileWorker
    {
        void SaveFileXml(string path, Box box);
        void SaveFileSw(string path, Box box);
        Box LoadFileXml(string filename);
        Box LoadFileSw(string filename);
    }
}
