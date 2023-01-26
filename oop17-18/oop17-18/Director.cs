using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
    class Director
    {
        Builder builder;
        public Director(Builder builder) => this.builder = builder;
        public void Construct(string PartA = "", int PartB = 0, string PartC = "")
        {
            builder.BuildPartA(PartA);
            builder.BuildPartB(PartB);
            builder.BuildPartC(PartC);
        }
    }
    abstract class Builder
    {
        public abstract void BuildPartA(string item);
        public abstract void BuildPartB(int item);
        public abstract void BuildPartC(string item);
        public abstract Tour GetResult();
    }
    class ConcreteBuilder : Builder
    {
        private static Tour temp = new Tour();
        public override void BuildPartA(string item) => temp.tourtype = item;
        public override void BuildPartB(int item) => temp.NumberOfTickets = item;
        public override void BuildPartC(string item) => temp.NameOfTheTour = item;
        public override Tour GetResult()
        {
            Tour.tours.Add(temp);
            Console.WriteLine($"Название тура: {temp.tourtype}\n" +
                                  $"Город: {temp.NameOfTheTour}\n" +
                                      $"Количество путевок: {temp.NumberOfTickets}");
            return temp;
        }
    }
}
