using System;

namespace var08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1A
                long result;
                uint a = uint.MaxValue;
                int b = int.MinValue;
                result = a + b;
                Console.WriteLine(result);

                //1B
                string[,] xx = { { "faf", "sgsg", "affa" }, { "fwsf", "svgv", "sggdr" } };
                int rows = xx.GetUpperBound(0) + 1;
                int columns = xx.Length / rows;
                for (int rrr = 0; rrr < rows; rrr++)
                {
                    for (int ccc = 0; ccc < columns; ccc++)
                    {
                        Console.Write($"{xx[rrr, ccc]} \t");
                    }
                    Console.WriteLine();
                }

                //2
                Time Object1 = new Time();
                Object1.Print();

                Time Object2 = new Time(10, 32, 48);
                Time Object3 = new Time(04, 32, 50);
                Time Object4 = new Time(03, 32, 50);
                Time Object5 = new Time(03, 32, 50);



                Object2.Print();

                Console.WriteLine($"Результат сравнения объектов: {Object5.Equals(Object4)}");
                Console.WriteLine($"Результат сравнения объектов: {Object1.Equals(Object2)}");
                Console.WriteLine($"Результат сравнения объектов(==): {Object1 == Object2}");
                Console.WriteLine($"Результат сравнения объектов(==): {Object4 == Object2}");

                Time[] TimeArr = new Time[5];
                TimeArr[0] = Object1;
                TimeArr[1] = Object2;
                TimeArr[2] = Object3;
                TimeArr[3] = Object4;
                TimeArr[4] = Object5;

                ((IPossible)Object1).Check(Object1);
                int nights = 0;
                int days = 0;
                for (int i = 0; i < TimeArr.Length; i++)
                {
                    if (((IPossible)TimeArr[i]).Check(TimeArr[i]))
                        nights++;
                    else
                        days++;
                }


                if (nights > days)
                    throw new Exception("Ночей больше, чем дней");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }



        }
    }
}
