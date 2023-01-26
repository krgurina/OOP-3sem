using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    //1 задание

    class SuperHashSet<T> where T: struct
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

    //class Computer
    //{
    //    public string Model { get; set; }
    //    public string Color { get; set; }

    //    public int Price { get; set; }

    //    public Computer(string Model, string Color, int Price)
    //    {
    //        this.Model = Model;
    //        this.Color = Color;
    //        this.Price = Price;
    //    }
    //    public override string ToString()
    //    {
    //        return $"{Model} {Color} {Price}";
    //    }

    //}

    //3 задание
    class Button
    {
        private string nameOfButton;
        public Button(string nameOfButton)
        {
            this.nameOfButton = nameOfButton;
        }

        public void OnClick(object sender, EventArgs e)
        {
            Console.WriteLine($"Кнопку {this.nameOfButton} нажали.");
        }

    }

    class User
    {
        public event EventHandler Click;
        private string name;
        public User(string name)
        {
            this.name = name;
        }

        public void CommandClick()
        {
            Console.WriteLine($" - {this.name} нажала на кнопку");
            Click?.Invoke(this, null);
        }
    }

    struct Computer
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
