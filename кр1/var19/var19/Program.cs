using System;
using System.Collections.Generic;
using System.Linq;

namespace var19
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a
            (string, int, int) tuple = ("krrr", 11111, 222);
            var (name, num1, num2) = tuple;
            Console.WriteLine(name);

            //1b
            string[] array = new string[3] { "sjncc", "adjscbj", "bghdsc" };
            Array.Sort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //2
            MyComplex myComplex = new MyComplex(1, 2);
        
           

            MyVect myVect = new MyVect(2, 3);
            MyVect myVect2 = new MyVect(5, 3);



            //массив
            Object[] Arr = new object[3];
            Arr[0] = myComplex;
            Arr[1] = myVect;
            Arr[2] = myVect2;



        }
    }
}
