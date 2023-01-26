using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace var19
{
    class MyVect:Base,IComparable
    {
        public MyVect(int A, int B)
        {
            X = A;
            Y = B;
        }
        public int X { get; set; }
        public double Y { get; set; }


        public override double Norma(double[] vect) => Math.Sqrt(vect.Sum());
       

        public int CompareTo(object? o)
        {
            if (o is MyVect vect) return X.CompareTo(vect.X);
            else throw new ArgumentException("Некорректное значение параметра");
        }


        //индексатор
        public int this[int index]
        {
            get => this.MyVect[index];

            set => this.MyVect[index] = value;
        }

       
    }
}
