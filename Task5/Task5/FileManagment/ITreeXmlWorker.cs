using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.FileManagment
{
    public interface ITreeXmlWorker
    {
        void SaveTreeFileXml(string path, Tree<Student> tree);
    }
}
