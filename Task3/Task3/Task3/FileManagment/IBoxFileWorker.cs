using System;
using System.Collections.Generic;
using System.Text;
using Task3.Boxes;

namespace Task3.FileManagment
{
    public interface IBoxFileWorker
    {
        void SaveAllFiguresFileXml(string path, Box box);

        void SaveFilmFiguresFileXml(string path, Box box);

        void SavePaperFigureFileXml(string path, Box box);

        void SavePlasticFigureFileXml(string path, Box box);

        Box LoadFiguresFileXml(string path);

        void SaveAllFiguresFileSw(string path, Box box);

        void SaveFilmFiguresFileSw(string path, Box box);

        void SavePaperFigureFileSw(string path, Box box);

        void SavePlasticFigureFileSw(string path, Box box);

        Box LoadFiguresFileSw(string path);
    }
}
