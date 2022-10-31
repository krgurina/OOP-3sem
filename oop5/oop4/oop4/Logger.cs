using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace oop4
{
    static class Logger
    {
        public static void WriteLogFileConsole(Exception e, bool fileFlag = false)
        {
            if (fileFlag)
                FileLogger(e);
            else
                ConsoleLogger(e);
        }
        private static void FileLogger(Exception e)
        {
            using var stream = new StreamWriter(@"F:\лабы\ООП\labs\oop5\log.txt", true);
            stream.WriteLine($"------------{DateTime.Now}------------");
            stream.WriteLine($"TYPE: {e.GetType()}");
            stream.WriteLine($"INFO: {e.Message}");
            stream.WriteLine($"INFO: {e.StackTrace}");
        }
        private static void ConsoleLogger(Exception e)
        {
            Console.WriteLine($"------------{DateTime.Now}------------");
            Console.WriteLine($"TYPE: {e.GetType()}");
            Console.WriteLine($"INFO: {e.Message}");
            Console.WriteLine($"INFO: {e.StackTrace}");

        }
    }
}
