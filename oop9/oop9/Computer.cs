using System;
using System.Collections.Generic;
using System.Text;

namespace oop9
{
    class Computer//:ISet<T>
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public int Price { get; set; }

        public Computer(string Model,string Color,int Price)
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
