using System;
using System.Collections.Generic;
using System.Text;

namespace var19
{
    class MyComplex:Base
    {
        //public int a; //целая часть
        //public int b; //мнимая 
        public MyComplex(int A, int B)
        {
            X = A;
            Y = B;
        }
        public int X { get; set; }
        public double Y { get; set; }
        public override double Norma((double, double) complex) =>
            Math.Sqrt(complex.Item1 * complex.Item1 + complex.Item2 * complex.Item2);
       




        public static int operator +(MyComplex compl1, int val)
        {

            return compl1.X + val;
        }



      







    }
}
