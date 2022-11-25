using System;
using System.Collections.Generic;
using System.Linq;

namespace oop10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December", };

            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 4;
            var nLengthhMonths = from t in months
                                  where t.Length == n
                                  select t;

            var SummerWinterMonths = from t in months
                                  where Equals(t, "December") || Equals(t, "January") || Equals(t, "February")
                                        || Equals(t, "June") || Equals(t, "July") || Equals(t, "August")
                                  select t;

            var AlfMonths = from t in months
                                  orderby t // упорядочиваем по возрастанию
                                  select t;

            var uMonths = from t in months
                                  where t.Contains("u")
                                  where t.Length >= 4
                                  select t;

            Console.WriteLine("=====================nLengthhMonths=====================");
            foreach (var item in nLengthhMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================SummerWinterMonths=====================");
            foreach (var item in SummerWinterMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================AlfMonths=====================");
            foreach (var item in AlfMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================uMonths=====================");
            foreach (var item in uMonths)
            {
                Console.WriteLine(item);
            }

        }
    }
}
