using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace oop12
{
    public static class GKSFileInfo
    {
        public static void GetFileInfo()
        {
            string path = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string classLogInfo = "\n=========================================   GKSFileInfo   =========================================\n";
            string fileInfoLog = "";

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
                fileInfoLog = classLogInfo +
                              "\nПолный путь:              " + path +
                              "\nИмя файла:                " + fileInfo.Name +
                              "\nРазмер файла:             " + fileInfo.Length + " KB" +
                              "\nРасширение:               " + fileInfo.Extension +
                              "\nДата изменения:           " + fileInfo.LastWriteTime +
                              "\nВремя создания:           " + fileInfo.CreationTime;


            GKSLog.WriteInLog(fileInfoLog);
        }
    }
}
