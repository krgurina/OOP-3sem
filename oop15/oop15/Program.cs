﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

namespace oop15
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            Console.WriteLine();

            //Second();
            Console.WriteLine();

            //Third();
            Console.WriteLine();


            //Forth();
            Console.WriteLine();

            //Fifth();
            Console.WriteLine();

            Sixth();
            Console.WriteLine();

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

        static void Third()
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


        static void Forth()
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


        static void Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;

            Console.WriteLine($"Факториал числа {num} равен {result}");
        }

        static void Fifth()
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


        static void Sixth()
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










    }

}
