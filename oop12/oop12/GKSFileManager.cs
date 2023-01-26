using System;
using System.IO;
using System.Threading;
using System.IO.Compression;
using System.Linq;

namespace oop12
{
    public static class GKSFileManager
    {

        //Прочитать список файлов и папок заданного диска.
        public static void GetList(string path)
        {
            string classLogInfo = "\n========================================   GKSFileManager   ========================================\n";
            string FileList = "";

            DriveInfo[] drives = DriveInfo.GetDrives();
            string[] dirs = System.IO.Directory.GetDirectories(path);
            string[] files = System.IO.Directory.GetFiles(path);

            FileList = "\nПапки:\n";
            foreach (string dir in dirs)
            {
                FileList += dir + "\n";
            }

            FileList += "\nФайлы:\n";
            foreach (string file in files)
            {
                FileList += file + "\n";
            }

            string FileListLog = classLogInfo + FileList;

            GKSLog.WriteInLog(FileListLog);
        }

        //Создать директорий XXXInspect
        public static void CreateDir(string path)
        {
            string classLogInfo = "\n=========================================   GKSFileManager - 2   =========================================\n";
            string CreateDirLog = "";

            try
            {
                Directory.CreateDirectory(path);
                CreateDirLog = classLogInfo + "\nДиректорий создан";
            }
            catch (Exception e)
            {
                CreateDirLog = classLogInfo + "\nОшибка создания директория: " + e.Message;
            }

            GKSLog.WriteInLog(CreateDirLog);
        }

        //создать текстовый файл xxxdirinfo.txt и сохранить туда информацию.
        public static void CreateFile(string path)
        {
            string classLogInfo = "\n=========================================   GKSFileManager - 3   =========================================\n";
            string CreateFileLog = "";

            FileInfo fileInfo = new FileInfo(path);
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Файл создан");
                sw.Close();
            }
            CreateFileLog = classLogInfo + "\nФайл создан";
            GKSLog.WriteInLog(CreateFileLog);
        }

        //Создать копию файла и переименовать его. Удалить первоначальный файл.
        public static void CopyFile(string path, string path2)
        {
            string classLogInfo = "\n=========================================   GKSFileManager - 4   =========================================\n";
            string CopyFileLog = "";

            try
            {
                File.Copy(path, path2);

                CopyFileLog = classLogInfo + "\nФайл скопирован";
            }
            catch (Exception e)
            {
                CopyFileLog = classLogInfo + "\nОшибка копирования файла: " + e.Message;
            }
            //удалить файл
            FileInfo delete = new FileInfo(path);
            delete.Delete();
            GKSLog.WriteInLog(CopyFileLog);
        }

        //Создать еще один директорий XXXFiles. Скопировать в него все файлы с заданным расширением из заданного пользователем директория. Переместить XXXFiles в XXXInspect.
        public static void CopyFiles(string path, string path2, string path3)
        {
            string classLogInfo = "\n=========================================   GKSFileManager - 5   =========================================\n";
            string CopyFilesLog = "";

            try
            {
                Directory.CreateDirectory(path2);

                string[] files = Directory.GetFiles(path, "*.docx");
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(path2, fileName);
                    File.Copy(file, destFile, true);
                }
                CopyFilesLog = classLogInfo + "\nФайлы скопированы";
            }
            catch (Exception e)
            {
                CopyFilesLog = classLogInfo + "\nОшибка копирования файлов: " + e.Message;
            }

            //переместить XXXFiles в XXXInspect
            try
            {
                string path4 = path3 + @"\GKSFiles";


                DirectoryInfo destDir = new DirectoryInfo(path4);
                if (destDir.Exists)
                    destDir.Delete(true);
                Directory.Move(path2, path4);
                CopyFilesLog = classLogInfo + "\nФайлы перемещены";
            }
            catch (Exception e)
            {
                CopyFilesLog = classLogInfo + "\nОшибка перемещения файлов: " + e.Message;
            }
            GKSLog.WriteInLog(CopyFilesLog);
        }

        //Сделайте архив из файлов директория XXXFiles. 
        public static void ZipFiles(string path, string path2, string path3)
        {
            string classLogInfo = "\n=========================================   GKSFileManager - 6   =========================================\n";
            string ZipFileLog = "";

            try
            {
                ZipFile.CreateFromDirectory(path, path2);
                ZipFileLog = classLogInfo + "\nАрхив создан";
            }
            catch (Exception e)
            {
                ZipFileLog = classLogInfo + "\nОшибка создания архива: " + e.Message;
            }

            //Разархивируйте его в другой директорий.
            try
            {
                ZipFile.ExtractToDirectory(path2, path3);
                ZipFileLog = classLogInfo + "\nАрхив разархивирован";
            }
            catch (Exception e)
            {
                ZipFileLog = classLogInfo + "\nОшибка разархивирования архива: " + e.Message;
            }
            GKSLog.WriteInLog(ZipFileLog);
        }











































        //// Создать директорий XXXInspect
        //public static void GKSInspect()
        //{
        //    string classLogInfo = "\n=======================================   GKSFileManager   ===============================================\n";            /// инфа для логгера
        //    string inspectLog = "";

        //    DriveInfo[] drives = DriveInfo.GetDrives();                 /// получили инфу о всех дисках
        //    string inspectPath = drives[1].Name;                        /// путь диска F:\ полученный от DriveInfo.GetDrives()
        //    DirectoryInfo directory = new DirectoryInfo(@"F:\Lab12");   /// тот же путь, только типа данных DirectoryInfo

        //    directory.Create();                                         /// создаем субдерикторий D:\Lab13\GKSInspect
        //    directory.CreateSubdirectory(@"GKSInspect");

        //    DirectoryInfo GKSInspectFiles = new DirectoryInfo(Path.GetFullPath(@"F:\Lab12\GKSInspect\GKSFiles"));
        //    if (GKSInspectFiles.Exists)
        //        GKSInspectFiles.Delete(true);

        //    string filePath = Path.GetFullPath(@"F:\Lab12\GKSInspect\GKSdirinfo.txt");
        //    FileInfo fileInfo = new FileInfo(filePath);                 /// fileInfo шобы всё работало
        //    using (StreamWriter sw = fileInfo.CreateText())             /// создаем файл и сразу пишем поток
        //    {
        //        sw.WriteLine("Записываем что-то в поток");
        //        sw.Close();
        //    }

        //    // Переименовать, скопировать и удалить первоначальный файл
        //    string renamePath = Path.GetFullPath(@"F:\Lab12\GKSInspect\GKSdirinfoRENAMED.txt");
        //    FileInfo renameBuf = new FileInfo(renamePath);              /// буфер чтобы удалить созданный ранее RENAMED
        //    renameBuf.Delete();

        //    fileInfo.CopyTo(renamePath);
        //    fileInfo.Delete();


        //    DirectoryInfo inspectDirInfo = new DirectoryInfo(Path.GetFullPath(@"F:\Lab12\GKSInspect"));
        //    string files = "";
        //    for (int i = 0; i < inspectDirInfo.GetFiles().Length; i++)
        //        files += inspectDirInfo.GetFiles()[i].Name + "; ";          /// имена всех файлов записываем в строку

        //    string directories = "";
        //    for (int i = 0; i < inspectDirInfo.GetDirectories().Length; i++)
        //        directories += inspectDirInfo.GetDirectories()[i];          /// имена всех директориев

        //    if (inspectDirInfo.Exists)
        //        inspectLog = classLogInfo +
        //                     "\nФайлы:                    " + files +
        //                     "\nПоддиректории:            " + directories +
        //                     "\nРодительский директорий:  " + inspectDirInfo.Parent.Name +
        //                     "\n\n==========================================================================================================";


        //    GKSLog.WriteInLog(inspectLog);
        //}

        //public static void GKSFiles()
        //{
        //    string rootDrivePath = Path.GetFullPath(@"F:\");
        //    string GKSFilesPath = Path.GetFullPath(rootDrivePath + @"Lab12\GKSFiles");
        //    string GKSInspectFilesPath = Path.GetFullPath(rootDrivePath + @"Lab12\GKSInspect\GKSFiles");
        //    string GKSUnzipPath = Path.GetFullPath(rootDrivePath + @"Lab23\GKSInspect\GKSUnzip");
        //    //////////////////////////////////////////////////////
        //    string musicPath = Path.GetFullPath(rootDrivePath + @"Music");
        //    ////////////////////////////////////////////
        //    string ZIPPath = Path.GetFullPath(rootDrivePath + @"Lab12\GKSInspect\GKSFiles.zip");


        //    DirectoryInfo GKSFiles = new DirectoryInfo(GKSFilesPath);                        /// создать GKSFIles
        //    DirectoryInfo GKSInspectFiles = new DirectoryInfo(GKSInspectFilesPath);          /// создать Inspect\Files
        //    DirectoryInfo GKSUnzip = new DirectoryInfo(GKSUnzipPath);

        //    if (!GKSFiles.Exists)                                                            /// если нет папки Files,
        //        GKSFiles.Create();                                                           /// то создаем ее, а хуле

        //    if (GKSUnzip.Exists)
        //        GKSUnzip.Delete(true);

        //    if (File.Exists(ZIPPath))
        //        File.Delete(ZIPPath);


        //    DirectoryInfo musicDirInfo = new DirectoryInfo(musicPath);                       /// путь к Music 
        //    FileInfo[] filesMusic = musicDirInfo.GetFiles();                                 /// получить все файлы из Music
        //    foreach (FileInfo file in filesMusic)
        //        if (file.Extension == ".mp3")
        //            file.CopyTo(Path.Combine(GKSFilesPath.ToString(), file.Name), true);     /// скопировать все .mp3 в GKSFiles

        //    if (GKSInspectFiles.Exists)                                                      /// если есть Inspect\Files,
        //        GKSInspectFiles.Delete(true);                                                /// то он нам нахуй не нужен
        //    if (GKSFiles.Exists)
        //        GKSFiles.MoveTo(GKSInspectFilesPath);                                        /// перемещаем в Inspect\Files
        //}

        //public static void MakeArchive()
        //{
        //    string lab13Path = Path.GetFullPath(@"F:\Lab12\");
        //    string GKSFilesPath = Path.GetFullPath(lab13Path + @"GKSFiles");
        //    string GKSInspectFilesPath = Path.GetFullPath(lab13Path + @"GKSInspect\GKSFiles");
        //    string GKSInspectUnzipPath = Path.GetFullPath(lab13Path + @"GKSInspect\GKSUnzip");
        //    string ZIPPath = Path.GetFullPath(lab13Path + @"GKSInspect\GKSFiles.zip");


        //    DirectoryInfo GKSFiles = new DirectoryInfo(GKSFilesPath);
        //    ZipFile.CreateFromDirectory(GKSInspectFilesPath, ZIPPath);                      /// архивируем

        //    DirectoryInfo GKSInspectFiles = new DirectoryInfo(GKSInspectFilesPath);         /// если остался Inspect\Files,
        //    if (GKSInspectFiles.Exists)                                                     /// то удаляем его
        //        GKSInspectFiles.Delete(true);

        //    DirectoryInfo GKSInspectUnzip = new DirectoryInfo(GKSInspectUnzipPath);         /// создаем папку для разархивации,
        //    if (GKSInspectUnzip.Exists)                                                     /// а если на существует,
        //        GKSInspectUnzip.Delete(true);                                               /// то удаляем ее нахуй
        //    GKSInspectUnzip.Create();

        //    using (ZipArchive archive = ZipFile.OpenRead(ZIPPath))                          /// спизженный код со stackoverflow
        //    {                                                                               /// для разархивации в папку Unzip
        //        var result = from currEntry in archive.Entries
        //                     where !String.IsNullOrEmpty(currEntry.Name)
        //                     select currEntry;
        //        foreach (ZipArchiveEntry entry in result)
        //            entry.ExtractToFile(Path.Combine(GKSInspectUnzipPath, entry.Name));     /// я эту лабу в рот ебал 
        //    }
        //}
    }
}
