using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace oop12
{
    public static class GKSLog
    {
        // методs записи в текстовый файл
        public static void WriteLogInfo()               /// запись в файл лога инфы о работе самого логгера
        {
            string loGKSth = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            using (StreamWriter sw = new StreamWriter(loGKSth, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("\n================================================================================================\n");
                sw.WriteLine("\n===========================================   GKSLog   =========================================\n");
                sw.WriteLine("\n================================================================================================\n");
                sw.WriteLine("Имя файла лога:           " + Path.GetFileName(loGKSth));
                sw.WriteLine("Полный путь лога:         " + loGKSth);
                sw.WriteLine("Время записи лога:        " + DateTime.Now);
            }

        }

        public static void WriteInLog(string message)   /// запись в файл лога инфы из остальных классов
        {
            string loGKSth = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            using (StreamWriter sw = new StreamWriter(loGKSth, true, System.Text.Encoding.Default))
                sw.WriteLine(message);
        }


        //метод чтения
        public static string ReadLog()
        {
            string loGKSth = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            StreamReader sr = new StreamReader(loGKSth);
            return sr.ReadToEnd();
        }

        //Найдите и выведите сохраненную информацию в файле xxxlogfile.txt о действиях пользователя за определенный день/ диапазон времени/по ключевому слову.

        // за определенный день 
        public static void FindLogInfoDay(DateTime date)
        {
            string GKS = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logInfo = ReadLog();
            string[] logInfoArray = logInfo.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] logInfoArray2 = new string[logInfoArray.Length];
            int count = 0;

            for (int i = 0; i < logInfoArray.Length; i++)
            {
                if (logInfoArray[i].Contains(date.ToString()))
                {
                    logInfoArray2[count] = logInfoArray[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(logInfoArray2[i]);
        }

        // по определенному слову
        public static void FindLogInfo(string keyWord)
        {
            string GKS = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logInfo = ReadLog();
            string[] logInfoArray = logInfo.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] keyWordArray = keyWord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] logInfoArray2 = new string[logInfoArray.Length];
            int count = 0;

            for (int i = 0; i < logInfoArray.Length; i++)
            {
                for (int j = 0; j < keyWordArray.Length; j++)
                {
                    if (logInfoArray[i].Contains(keyWordArray[j]))
                    {
                        logInfoArray2[count] = logInfoArray[i];
                        count++;
                    }
                }
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(logInfoArray2[i]);

           
        }

        // за определенный диапазон 
        public static void FindLogInfoTime(DateTime date1, DateTime date2)
        {
            string GKS = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logInfo = ReadLog();
            string[] logInfoArray = logInfo.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] logInfoArray2 = new string[logInfoArray.Length];
            int count = 0;

            for (int i = 0; i < logInfoArray.Length; i++)
            {
                if (logInfoArray[i].Contains(date1.ToString()) && logInfoArray[i].Contains(date2.ToString()))
                {
                    logInfoArray2[count] = logInfoArray[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(logInfoArray2[i]);
        }
       
        //Удалите часть информации, оставьте только записи за текущий час.
        public static void DeleteLogInfo()
        {
            string GKS = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logInfo = ReadLog();
            string[] logInfoArray = logInfo.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] logInfoArray2 = new string[logInfoArray.Length];
            int count = 0;
            DateTime date = DateTime.Now;
            date.AddHours(-1);
            for (int i = 0; i < logInfoArray.Length; i++)
            {
                if (logInfoArray[i].Contains(date.ToString()))
                {
                    logInfoArray2[count] = logInfoArray[i];
                    count++;
                }
            }
            string logInfo2 = "";
            for (int i = 0; i < count; i++)
                logInfo2 += logInfoArray2[i] + "\n";
            File.WriteAllText(GKS, logInfo2);
        }



        public static void SearchLog()
        {
            string GKS = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logFile = GKSLog.ReadLog();                                  /// string с самим логом полностью
            FileInfo logFileInfo = new FileInfo(GKS);
            DateTime lastHour = DateTime.Now;
            lastHour.AddHours(-1);                                              /// записи за последний час

            if (logFileInfo.LastWriteTime < lastHour)                           /// выводим только записи за час
            {
                string writes = "\n=";                                          /// подстрока, считающая кол-во записей
                int i = 0, j = -1, count = -1;
                while (i != -1)                                                 /// механизм подсчета вхождений подстроки
                {
                    i = logFile.IndexOf(writes, j + 1);
                    j = i;
                    count++;
                }

                Console.WriteLine("Записей за текущий час: " + (count - 1));    /// -1 т.к. в конце есть еще одна "\n="
                Console.WriteLine("Вывод этих записей: ");
                Console.WriteLine(logFile);
            }
        }
    }
}
