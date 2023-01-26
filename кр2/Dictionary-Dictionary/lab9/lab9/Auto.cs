using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Auto 
    {
        public enum Marka
        {
            Audi,
            BMW,
            Lamborgini,
            Porche
        }

        public Marka marka;
        public int year;



        public Auto(Marka m, int y)
        {
            marka = m;
            year = y;
        }

        public override string ToString() => $"Марка данного авто: {Convert.ToString(marka)} \nГод выпуска даного авто: {year} ";
    }

    public class MyColl : IList<Auto>
    {
        private readonly IList<Auto> myautos;

        public MyColl()
        {
            myautos = new List<Auto>();
        }

        public void Add(Auto car) => myautos.Add(car);
        public void Clear() => myautos.Clear();
        public bool Remove(Auto car) => myautos.Remove(car);
        public bool Contains(Auto car) => myautos.Contains(car);
        public void RemoveAt(int index) => myautos.RemoveAt(index);
        public void CopyTo(Auto[] array, int arrayIndex) => myautos.CopyTo(array, arrayIndex);
        public void Insert(int index, Auto car) => myautos.Insert(index, car);
        public int IndexOf(Auto car) => myautos.IndexOf(car);
        public IEnumerator<Auto> GetEnumerator() => myautos.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public void ShowElements()
        {
            Console.WriteLine($"В моей коллекции {Count} автомобилей");
            foreach (var T in this)
            {
                Console.WriteLine(T);
            }
        }
        public bool IsReadOnly => myautos.IsReadOnly;
        public int Count => myautos.Count;
        public Auto this[int index]
        {
            get { return myautos[index]; }
            set { myautos[index] = value; }
        }
    }

    public class MyDictionary<T> : Dictionary<int, T>
    {

        public void ShowElements()
        {
            Console.WriteLine($"В моей коллекции {Count} автомобилей");
            foreach (var T in this)
            {
                Console.WriteLine(T);
            }
        }

        public void RemoveElements(int firstIdx, int secondIdx)
        {

            for (int i = firstIdx; i <= secondIdx && i < Count; i++)
            {
                Remove(i);
            }

        }
    }
}
