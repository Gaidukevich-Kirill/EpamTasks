using System;
using System.Collections.Generic;
using System.Text;
using Task3.Boxes;

namespace Task3.FileManagment
{
    public interface IBoxFileWorker
    {
        void SaveFiguresFileXml(string path, Box box, Type type = null);
        
        Box LoadFiguresFileXml(string path);

        void SaveFiguresFileSw(string path, Box box, Type type = null);

        Box LoadFiguresFileSw(string path);
    }
}
