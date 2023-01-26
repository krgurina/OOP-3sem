using System;
using System.Text;
using System.Linq;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------ТИПЫ---------------- -
            //1a
            bool testBool = true;
            Console.WriteLine("bool = " + testBool);

            Console.Write("byte = ");
            byte testByte = Convert.ToByte(Console.ReadLine());

            Console.Write("sbyte = ");
            sbyte testSbyte = Convert.ToSByte(Console.ReadLine());

            Console.Write("char = ");
            char testChar = Convert.ToChar(Console.ReadLine()); ;

            Console.Write("decimal = ");
            decimal testDecimal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("double = ");
            double testDouble = Convert.ToDouble(Console.ReadLine());

            Console.Write("float = ");
            float testFloat = Convert.ToByte(Console.ReadLine());

            Console.Write("int = ");
            int testInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("uint = ");
            uint testUint = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("long = ");
            long testLong = Convert.ToInt64(Console.ReadLine());

            Console.Write("ulong = ");
            ulong testUlong = Convert.ToUInt64(Console.ReadLine());

            Console.Write("short = ");
            short testShort = Convert.ToInt16(Console.ReadLine());

            Console.Write("ushort = ");
            ushort testUshort = Convert.ToUInt16(Console.ReadLine());
            //nint q = 1;


            //1b
            // явные
            float b1 = 7.592f;
            float b2 = 1.616f;
            byte b3 = (byte)(b1 + b2);
            sbyte b4 = (sbyte)(b1 + b2);
            short b5 = (short)(b1 + b2);
            int b6 = (int)(b1 + b2);
            long b7 = (long)(b1 + b2);
            Console.WriteLine("float-->byte: " + b3);
            Console.WriteLine("float-->sbyte: " + b4);
            Console.WriteLine("float-->short: " + b5);
            Console.WriteLine("float-->int: " + b6);
            Console.WriteLine("float-->long: " + b7);

            // неявные
            byte bnum = 8;
            short snum = bnum;
            int inum = snum;
            long lnum = inum;
            float fnum = lnum;
            Console.WriteLine("byte->short->int->long->float: " + fnum);

            Console.Write("Введите число: ");
            int b8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число: " + b8);

            //1c
            int c1 = 5;
            object c2 = c1;
            int c3 = (int)c2;

            double c4 = 7.7777777;
            object c5 = c4;
            double c6 = (double)c5;

            //1d
            var d1 = "Неявно типизированная переменная";
            Console.WriteLine(d1);
            var d2 = 5;
            var d3 = 7.74;
            var d4 = d2 + d3;

            //1e
            int? e1 = null;

            if (e1 == null) Console.WriteLine("null");
            else Console.WriteLine("Число");

            //1f
            var f1 = 5;
            //f1 = 0.4444;

            //--------------Строки-----------------
            //2a

            string str1 = "nnn";
            string str2 = "nnn";
            string str3 = "ppp";
            string str4 = "\\ryffh\\";
            Console.WriteLine($"Сравнение 1 и 2 строки: {str1 == str2}");
            Console.WriteLine($"Сравнение 2 и 3 строки: {String.Compare(str2,str3)}");

            //2b

            string str11 = "Это первая строка";
            string str22 = "Это вторая строка";
            string str33 = "Это третья строка";

            Console.WriteLine($"Сцепление строк: {String.Concat(str11, str22)}");
            Console.WriteLine($"Копирование строки: {String.Copy(str22)}");
            string substr = str33.Substring(11);
            Console.WriteLine($"Выделение подстроки: {substr}");
            Console.WriteLine($"Разделение строки на слова: ");
            string[] strArr = str11.Split();

            for (int ind = 0; ind < strArr.Length; ind++)
            {
                Console.WriteLine(strArr[ind]);
            }
            Console.WriteLine($"Вставка подстроки в заданную позицию: {str22.Insert(4, substr)}");
            Console.WriteLine($"Удаление заданной подстроки: {str33.Remove(4)}");

            //2c
            string emtstr = "";
            string nullstr = null;
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(emtstr)}");
            Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(nullstr)}");
           
            Console.WriteLine($"Вывод пустой строки: {emtstr}");
            Console.WriteLine($"Вывод нулевой строки: {nullstr}");
            Console.WriteLine($"Сравнение 1 и 2 строки: {emtstr == nullstr}");
            Console.WriteLine($"Сцепление: {String.Concat(emtstr, nullstr)}");

            //2d
            StringBuilder testStr = new StringBuilder("rrkkkkrrrr", 7);
            testStr.Remove(2, 4);
            testStr.Insert(0, str33.Substring(11));
            testStr.Append("end");
            Console.WriteLine($"StringBuilder: {testStr}");

            //--------------МАССИВЫ-----------------
            //3a
            int[,] matrix = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            //3b
            string[] srtArr = { "aaa", "bbbbb", "ccccccc" };
            Console.WriteLine($"Длина массива: {srtArr.Length}");

            foreach (string str in srtArr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Введите позицию: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите строку: ");
            string strpos = Convert.ToString(Console.ReadLine());

            srtArr[pos] = strpos;
            Console.WriteLine("--------");

            foreach (string str in srtArr)
            {
                Console.WriteLine(str);
            }

            //3c
            double[][] jaggedArr = new double[3][];
            jaggedArr[0] = new double[2];
            jaggedArr[1] = new double[3];
            jaggedArr[2] = new double[4];

            Console.WriteLine("Заполните ступенчатый массив: ");
            for (int i = 0; i < 2; i++)
            {
                jaggedArr[0][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                jaggedArr[1][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                jaggedArr[2][i] = Convert.ToDouble(Console.ReadLine());
            }



            foreach (double[] row in jaggedArr)
            {
                foreach (double number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            //3d

            var vArr = new object[0];
            var vstr = "";

            //--------------Кортежи-----------------

            //4a
            (int, string, char, string, ulong) tuple = (12, "krrr", 'r', "black", 11111);

            //4b
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item5);

            //4c
            // (int age, string name, char letter, string color, ulong userNumber) = tuple;
            //(var age, var name, var letter, var color, var userNumber) = tuple;
            var (age, name, letter, color, userNumber) = tuple;

            (int age2, string name2, _, string color2, ulong userNumber2) = tuple;


            Console.WriteLine($"items: {age} {name}");

            //4d
            var tuple1ToCompare = (7, 27, 4, 85, 6, 7, 5);
            var tuple2ToCompare = (7, 27, 4, 85, 5, 7, 5);
            if (tuple1ToCompare == tuple2ToCompare)
            {
                Console.WriteLine("true");
            }
            else
            { Console.WriteLine("false"); }


            //--------------Функции-----------------

            (int, int, int, char) LocalFunction(int[] numbers, string str1)
            {
                int maxNumber = numbers.Max();
                int minNumber = numbers.Min();
                int sumNumber = numbers.Sum();

                char frstSimbol = str1[0];

                var tupleToFunc = (maxNumber, minNumber, sumNumber, frstSimbol);
                return tupleToFunc;
            }

            int[] arrToFunc = new int[] { 18, 27, 3, 54 };
            string srtToFunc = "мяу";

            Console.WriteLine(LocalFunction(arrToFunc, srtToFunc));


            //--------------Работа с checked/ unchecked:-----------------

            int add = 100;
            int localfunction2()
            {
                int maxInt = Int32.MaxValue;
                unchecked
                {
                    maxInt = maxInt + add;
                    Console.WriteLine(maxInt);
                }
                return maxInt;
            }
            int localfunction1()
            {
                int maxInt = Int32.MaxValue;
                checked
                {
                    maxInt = maxInt + add;
                    Console.WriteLine(maxInt);
                }
                return maxInt;
            }
            localfunction2();//выведется это
            localfunction1();

        }
    }
}





