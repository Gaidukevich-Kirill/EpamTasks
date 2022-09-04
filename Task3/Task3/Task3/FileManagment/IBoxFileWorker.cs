using System;
using System.Collections.Generic;
using System.Text;
using Task3.Boxes;

namespace Task3.FileManagment
{
    public interface IBoxFileWorker
    {
        void SaveFile(string path, Box box);

        Box LoadFile(string filename);
    }
}
