using System;
using System.Collections.Generic;
using System.Text;

namespace oop9
{
    class Computer//:ISet<T>
    {
        public int Id { get; set; }
        public int Price { get; set; }

        public Computer(int id,int price)
        {
            Id = id;
            Price = price;
        }


    }
}
