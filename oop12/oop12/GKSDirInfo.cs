using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace oop12
{
    class GKSDirInfo
    {
        public static void GetDirInfo()
        {
            string path = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12");
            string DirInfoLog = "";

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (dirInfo.Exists)
                DirInfoLog = "\n=========================================   GKSDirInfo   =========================================\n" +
                             "\nКоличество файлов:        " + dirInfo.GetFiles().Length +
                             "\nВремя создания:           " + dirInfo.LastWriteTime +
                             "\nКол-во поддиректориев:    " + dirInfo.GetDirectories().Length +
                             "\nРодительский директорий:  " + dirInfo.Parent.Name;

            GKSLog.WriteInLog(DirInfoLog);
        }
    }
}

