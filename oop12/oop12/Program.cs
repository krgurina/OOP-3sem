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
            //GKSDirInfo.GetDirInfo();
            //GKSFileManager.GKSFiles();
            //GKSFileManager.MakeArchive();
            //GKSFileManager.GKSInspect();

            GKSLog.ReadLog();
            GKSLog.SearchLog();
        }
    }
}
