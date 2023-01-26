using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab11
{
    //Создать обощенный класс SuperHashSet<T> который содержит стандратную коллекию HashSet<T>и методы для добавления и удаления элементов.
    //Реализовать интерфейс IEnumerable<T> для этого класса.
    class SuperHashSet<T> where T:Computer
    {
        public HashSet<T> hset { get; set; }
        public int count = 0;
        public SuperHashSet()
        {
            hset = new HashSet<T>();
        }

        public bool Add(T item)
        {
            return this.hset.Add(item);
        }


        public void Show()
        {
            foreach (T element in this.hset)
            {
                Console.Write(element + "\n");
            }
            Console.WriteLine("\n");
        }
    }
    class Computer//:ISet<T>
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public int Price { get; set; }

        public Computer(string Model, string Color, int Price)
        {
            this.Model = Model;
            this.Color = Color;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"{Model} {Color} {Price}";
        }

    }
}
    

