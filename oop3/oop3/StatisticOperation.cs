using System;
//using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public static class StatisticOperation
    {
        public static void GetSum(List list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine($"Сумма элементов списка равна: {sum}");
        }

        public static int MinItem(List list)
        {
            int minItem = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (minItem > list[i])
                    minItem = list[i];
                //Console.WriteLine($"Min: {minItem}");

            }
            return minItem;
        }


        public static int MaxItem(List list)
        {
            int maxItem = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (maxItem < list[i])
                    maxItem = list[i];
                //Console.WriteLine($"Min: {minItem}");

            }
            return maxItem;
        }

        public static void MinMaxDifference(List list)
        {
            Console.WriteLine($"Разница между max и min: {MaxItem(list)-MinItem(list)}");
        }

        public static void GetCount(List list)
        {
            Console.WriteLine($"Количество элементов списка: {list.Count}");
        }

    }
}
