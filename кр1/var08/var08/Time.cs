using System;
using System.Collections.Generic;
using System.Text;

namespace var08
{
        partial class Time : IPossible, IComparable
    {
            public int hour;
            public int minute;
            public int second;

            public Time(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
                proverka();
            }
            public Time()
            {

            }

            void proverka()
            {
            
                        if (hour > 24 || minute > 60 || second > 60) ;

                    Console.WriteLine("Данные введены неверно!");

            }

            public void Print()
            {
                Console.WriteLine($"Часы: {hour}\nМинуты: {minute}\nСекунды: {second}\n");
            }

            bool IPossible.Check(Time time)
            {
            if (time.hour > 0 && time.hour < 5)
                return true;//если ночь
            else
                return false;
            }
            public int CompareTo(object? o)
            {
                if (o is Time time) return hour.CompareTo(time.hour);
                else throw new ArgumentException("Некорректное значение параметра");
            }

    }
    
}
