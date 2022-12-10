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
            using (StreamWriter sw = new StreamWriter(loGKSth, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("\n===========================================   GKSLog   =========================================\n");
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


        public static void SearchLog()
        {
            string loGKSth = Path.GetFullPath(@"F:\лабы\ООП\labs\oop12\oop12\gkslog.txt");
            string logFile = GKSLog.ReadLog();                                  /// string с самим логом полностью
            FileInfo logFileInfo = new FileInfo(loGKSth);
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
