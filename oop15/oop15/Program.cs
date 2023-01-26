using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

namespace oop15
{
    class Program
    {
        public static int cus = 1;
        static void Main(string[] args)
        {

            //First();

            //Second();

            //Third();

            //Forth();

            //Fifth();

            //Sixth();

            //Seventh(); 

            //Eighth();

           // Ninth();

            Console.ReadKey();
        }

        static void First()
        {
            for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = new Stopwatch();     // точное измерение затраченного времени
                sw.Start();
                Task task = new Task(() => MulByVector(10000));
                task.Start();
                Console.WriteLine($"ID: {task.Id}, статус: {task.Status}");
                task.Wait();
                Console.WriteLine($"ID: {task.Id}, статус: {task.Status}");
                sw.Stop();
                Console.WriteLine($"Производительность: {sw.ElapsedMilliseconds}ms");
                Console.WriteLine();
            }
        }

        static void MulByVector(int k, object ob = null)
        {
            Random random = new Random();
            List<int> vector = new List<int>();
            for (int i = 0; i < k; i++)
            {
                vector.Add(random.Next(1, 10));
            }
            vector = vector.Select(x => x * 10).ToList();
        }

        static void Second()
        {

            AppDomain domain = AppDomain.CurrentDomain;    // текущий домен с процессами
            Console.WriteLine("\n\n\n\nТекущий домен:         " + domain.FriendlyName);
            Console.WriteLine("Базовый каталог:       " + domain.BaseDirectory);
            Console.WriteLine("Детали конфигурации:   " + domain.SetupInformation);
            Console.WriteLine("Все сборки в домене:\n");
            foreach (Assembly ass in domain.GetAssemblies())
                Console.WriteLine(ass.GetName().Name);


            AppDomain newDomain = AppDomain.CreateDomain("New Domain"); // создание нового домена
            newDomain.Load(Assembly.GetExecutingAssembly().FullName);   // загрузка сборки
            AppDomain.Unload(newDomain);                                // выгрузка домена + всех содержащихся в нём сборок

        }

        static void Third()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            Task task = Task.Run(() => MulByVector(1000, cancellation), cancellation.Token);
            try
            {
                cancellation.Cancel();
                task.Wait();
            }
            catch (Exception)
            {
                if (task.IsCanceled)
                    Console.WriteLine("Задача отменена");
            }

        }


        static void Forth()
        {

            Task<int> first = new Task<int>(() => new Random().Next(1, 9) * 100);
            Task<int> second = new Task<int>(() => new Random().Next(0, 9) * 10);
            Task<int> third = new Task<int>(() => new Random().Next(0, 9));

            first.Start();
            second.Start();
            third.Start();
            first.Wait();
            second.Wait();
            third.Wait();

            Task<int> number = new Task<int>(() => first.Result + second.Result + third.Result);
            number.Start();
            Console.WriteLine($"Number: {number.Result}");

        }


        static void Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;

            Console.WriteLine($"Факториал числа {num} равен {result}");
        }

        static void Fifth()
        {
            Task<int> task4 = new Task<int>(() => 100 + 10 + 1);
            Task show = task4.ContinueWith(sum => Console.WriteLine($"Sum = {sum.Result}"));
            task4.Start();
            show.Wait();

            Task<double> sqrt = new Task<double>(() => Math.Sqrt(49));
            TaskAwaiter<double> awaiter = sqrt.GetAwaiter();
            awaiter.OnCompleted(() => Console.WriteLine($"Result is: {sqrt.Result}"));
            sqrt.Start();
            sqrt.Wait();
            awaiter.GetResult();
            Thread.Sleep(10);
        }


        static void Sixth()
        {
            int[] arr1 = new int[1000000];
            int[] arr2 = new int[1000000];
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Parallel.For(0, arr1.Length, t => arr1[t] = t);
            stopwatch2.Stop();
            Console.WriteLine($"Parallel.For: {stopwatch2.Elapsed}");       // вывод повторяющегося события

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = i + 1;

            stopwatch3.Stop();
            Console.WriteLine("for: " + stopwatch3.Elapsed);            // вывод повторяющегося события
            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch4.Start();
            Parallel.ForEach<int>(new List<int>() { 1, 2, 3, 4 }, Factorial);
            stopwatch4.Stop();
            Console.WriteLine("Parallel.Foreach: " + stopwatch4.Elapsed);   // вывод повторяющегося события

            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch5.Start();
            foreach (var m in new List<int>() { 1, 2, 3, 4 })
            {
                Factorial(m);
            }
            stopwatch5.Stop();
            Console.WriteLine("foreach: " + stopwatch5.Elapsed);              // вывод повторяющегося события
            Console.WriteLine();

        }

        static void Seventh()
        {

            int count = 0;
            int maxCount = 100;
            Parallel.Invoke(() =>      // в качестве параметра принимает массив объектов Action
            {
                while (count < maxCount)        // выполняется на одном ядре целевой машины
                {
                    count++;
                    Console.WriteLine($"1: {count}");
                }
            }, () =>
            {
                while (count < maxCount)         // выполняется на другом ядре целевой машины
                {
                    count++;
                    Console.WriteLine($"2: {count}");
                }
            });

        }

        static void Eighth()
        {
            BlockingCollection<string> blockcoll = new BlockingCollection<string>();
            Task Seller = new Task(
                () =>
                {
                    List<string> Appliances = new List<string> { "Fridge", "Microwave", "Plate", "Washing machine", "Toaster" };
                    int choose = 0;
                    Random rnd = new Random();
                    for (int i = 0; i < 5; i++)
                    {
                        choose = rnd.Next(0, Appliances.Count - 1);
                        Console.WriteLine($"Add {Appliances[choose]}");
                        blockcoll.Add(Appliances[choose]);
                        Appliances.RemoveAt(choose);
                        Thread.Sleep(choose);
                    }
                    blockcoll.CompleteAdding();
                });

            Task Customer = new Task(
                () =>
                {
                    string str;
                    while (blockcoll.IsCompleted == false)
                    {
                        if (blockcoll.TryTake(out str) == true)
                            Console.WriteLine($"Selled: {str} to Customer{cus}");
                        else
                            Console.WriteLine($"Customer{cus} bought nothing and left");
                        cus++;
                    }

                });

            Seller.Start();
            Customer.Start();
            Customer.Wait();
            Seller.Wait();


        }

        static void Ninth()
        {
            void Factorial()
            {
                int result = 1;
                for (int i = 1; i <= 6; i++)
                {
                    result *= i;
                }
                Thread.Sleep(1000);
                Console.WriteLine($"Факториал равен {result}");
            }

            async void FactorialAsync()

            {
                Console.WriteLine("Начало метода FactorialAsync");
                await Task.Run(() => Factorial());                  // выполняется асинхронно
                Console.WriteLine("Конец метода FactorialAsync");
            }
            FactorialAsync();
        }






    }

}
