using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace oop14
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            Second();///////////

        }


        private static void First()
        {
            var allProcesses = Process.GetProcesses();
            Console.WriteLine("Информация о процессах:");
            Console.Write("{0,-20}", "ID:");
            Console.Write("{0,-70}", "Process Name:");
            Console.Write("{0,-20}", "Priority:\n");
            foreach (Process process in allProcesses)
            {
                Console.Write("{0,-20}", $"{process.Id}");
                Console.Write("{0,-70}", $"{process.ProcessName}");
                Console.Write("{0,-20}", $"{process.BasePriority}");
                Console.WriteLine();
            }
        }





        private static void Second()
        {


            AppDomain domain = AppDomain.CurrentDomain;    // текущий домен с процессами
            Console.WriteLine("\n\n\n\nТекущий домен:         " + domain.FriendlyName);
            Console.WriteLine("Базовый каталог:       " + domain.BaseDirectory);
            Console.WriteLine("Детали конфигурации:   " + domain.SetupInformation);
            Console.WriteLine("Все сборки в домене:\n");
            foreach (Assembly ass in domain.GetAssemblies())
                Console.WriteLine(ass.GetName().Name);

            //AppDomain newDomain = AppDomain.CreateDomain("New Domain"); // создание нового домена
            //newDomain.Load(Assembly.GetExecutingAssembly().FullName);   // загрузка сборки
            //AppDomain.Unload(newDomain);                                // выгрузка домена + всех содержащихся в нём сборок











            //AppDomain domain = AppDomain.CurrentDomain;
            //Console.WriteLine("\n\n\n\nТекущий домен:\t" + domain.FriendlyName);
            //Console.WriteLine("Базовый каталог:\t" + domain.BaseDirectory);
            //Console.WriteLine("Детали конфигурации:\t" + domain.SetupInformation);
            //Console.WriteLine("Все сборки в домене:\n");
            //foreach (Assembly ass in domain.GetAssemblies())
            //    Console.WriteLine(ass.GetName().Name);

            //AppDomain newDomain = AppDomain.CreateDomain("New Domain");
            //newDomain.Load(Assembly.GetExecutingAssembly().FullName);
            //AppDomain.Unload(newDomain);
        }



    }
}
