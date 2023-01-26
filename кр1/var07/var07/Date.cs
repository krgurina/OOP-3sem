using System;
using System.Collections.Generic;
using System.Text;

namespace var07
{
    partial class Date
    {
        //для чтения
        public int Number { get; }

        private int month;
        //проверка корректности
        public int Month
        {
            set
            {
                if (value < 1 || value > 12)
                    Console.WriteLine("Месяц задан неверно");
                else
                    month = value;
            }
            get { return month; }

        }
        //автоматическое свойство
        public int Year { get; set; }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
