using System;

namespace oop12
{
    class Program
    {
        static void Main(string[] args)
        {

            GKSLog.WriteLogInfo();
            GKSDiskInfo.GetDiskInfo();
            GKSFileInfo.GetFileInfo();
            GKSDirInfo.GetDirInfo();
            //GKSFileManager.GKSFiles();
            //GKSFileManager.MakeArchive();
            //GKSFileManager.GKSInspect();



            GKSFileManager.GetList(@"F:\");
            GKSFileManager.CreateDir(@"F:\лабы\ООП\labs\oop12\oop12\GKSInspect");
            GKSFileManager.CreateFile(@"F:\лабы\ООП\labs\oop12\oop12\GKSInspect\gksdirinfo.txt");
            GKSFileManager.CopyFile(@"F:\лабы\ООП\labs\oop12\oop12\GKSInspect\gksdirinfo.txt", @"F:\лабы\ООП\labs\oop12\oop12\GKSInspect\gksdirinfo_copy.txt");
            GKSFileManager.CopyFiles(@"F:\лабы\ООП", @"F:\лабы\ООП\labs\oop12\oop12\GKSFiles", @"F:\лабы\ООП\labs\oop12\oop12\GKSInspect");
            GKSFileManager.ZipFiles(@"F:\лабы\ООП\labs\oop12\oop12\GKSInspect\GKSFiles", @"F:\лабы\ООП\labs\oop12\oop12\GKSInspect\GKSFiles.zip", @"F:\лабы\ООП\labs\oop12\oop12\ForZip");
            //GKSLog.Count();

            GKSLog.ReadLog();
            GKSLog.SearchLog();
        }
    }
}
