using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop14
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();///////////
            //Third();

            Fourth();
            Fifth();
        }


        private static void First()
        {
            var allProcesses = Process.GetProcesses();
            Console.WriteLine("Информация о процессах:");
            Console.Write("{0,-10}", "ID:");
            Console.Write("{0,-70}", "Process Name:");
            Console.Write("{0,-20}", "Priority:");
            Console.Write("{0,-10}", "Memory:\n");

            foreach (Process process in allProcesses)
            {
                Console.Write("{0,-10}", $"{process.Id}");
                Console.Write("{0,-70}", $"{process.ProcessName}");
                Console.Write("{0,-20}", $"{process.BasePriority}");
                Console.Write("{0,-10}", $"{process.WorkingSet64}");

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

            //1
            ////Создайте новый домен.
            //AppDomain newDomain = AppDomain.CreateDomain("New domain");
            ////Загрузите туда сборку.
            //newDomain.Load(new AssemblyName("oop14"));
            //Console.WriteLine("Name of the new domain: " + newDomain.FriendlyName + "\nAssamblies of new domain:");
            //foreach (Assembly a in newDomain.GetAssemblies())
            //{
            //    Console.WriteLine(a.GetName().Name);
            //}
            ////Выгрузите домен.
            //AppDomain.Unload(newDomain);
            //Console.WriteLine("\nPress any key\n");
            //Console.ReadKey();

            //2
            //AppDomain newDomain = AppDomain.CreateDomain("New Domain"); // создание нового домена
            //newDomain.Load(Assembly.GetExecutingAssembly().FullName);   // загрузка сборки
            //AppDomain.Unload(newDomain);                                // выгрузка домена + всех содержащихся в нём сборок

            //3
            //Создайте новый домен. Загрузите туда сборку. Выгрузите домен.
            //AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
            //newDomain.Load(Assembly.GetExecutingAssembly().GetName());
            //AppDomain.Unload(newDomain);


        }

        private static void Third()
        {

            Thread NumbersThread = new Thread(new ParameterizedThreadStart(WriteNums));   // создаем новый поток
            Console.Write("Задайте число: "); int numb = Convert.ToInt32(Console.ReadLine());
            NumbersThread.Start(numb);  // запускаем его

            Thread.Sleep(2000);   // приостанавливает выполнение потока, в котором он был вызван

            Console.WriteLine("\n--------------------");
            Console.WriteLine("Приоритет:   " + NumbersThread.Priority);
            Thread.Sleep(100);
            Console.WriteLine("Имя потока:  " + NumbersThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("ID потока:   " + NumbersThread.ManagedThreadId);
            Console.WriteLine("---------------------");
            Thread.Sleep(1000);

            //Thread.Sleep(2000);  // приостанавливает выполнение потока, в котором он был вызван

            void WriteNums(object number)
            {
                int num = (int)number;

                using (StreamWriter sw = new StreamWriter(@"F:\лабы\ООП\labs\oop14\numbers.txt", false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < num; i++)
                    {
                        sw.WriteLine(i);
                        Console.WriteLine(i);
                        Thread.Sleep(500);
                    }
                }
            }

        }


        private static void Fourth()
        {

                Console.WriteLine("\n\n\nПотоки чётных и нечётных чисел:");
                Thread evenThread = new Thread(Methods.EvenNumbers);
                evenThread.Priority = ThreadPriority.AboveNormal;
                evenThread.Start();
                //evenThread.Join();  // сначала чётные потом нечетные                

                Console.WriteLine();
                Thread oddThread = new Thread(Methods.OddNumbers);
                oddThread.Priority = ThreadPriority.BelowNormal;
                oddThread.Start();
                oddThread.Join();   //чередование четных и нечётных
                Console.WriteLine("\n");

        }


        private static void Fifth()
        {
            TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);

            // позволяет запускать определенные действия по истечению некоторого периода времени:
            Timer timer = new Timer(timerCallback, null, 500, 1000);       /* null - параметр, которого нет, 500 - время, через которое запустится процесс с таймером, 
                                                                            * 1000 - периодичность таймера (интервал между вызовами метода делегата). */
            Thread.Sleep(5000);                                             // 500 - ждем и не закрываем поток
            timer.Change(Timeout.Infinite, 2000);                           // уничтожение таймера

            void WhatTimeIsIt(object obj)
            {
                Console.WriteLine($"It's {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }
            Console.ReadLine();
            Console.ReadLine();
        }
        
    }


    class Methods
    {
        public static void OddNumbers()
        {
            using (StreamWriter sw = new StreamWriter(@"F:\лабы\ООП\labs\oop14\numbers2.txt", false, System.Text.Encoding.Default))
            {
                for (int i = 0; i <= 20; i++)
                {
                    if (i % 2 != 0)
                    {

                        sw.WriteLine(i);
                        Console.Write($"{i} ");
                        Thread.Sleep(120);

                    }
                }
            }
        }

        public static void EvenNumbers()
        {
            using (StreamWriter sw = new StreamWriter(@"F:\лабы\ООП\labs\oop14\numbers.txt", true, System.Text.Encoding.Default))
            {
                for (int i = 0; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {

                        sw.WriteLine(i);
                        Console.Write($"{i} ");
                        Thread.Sleep(120);

                    }
                }
            }
        }


    }
}
