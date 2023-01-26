using System;
using System.Collections.Generic;
using System.Text;

namespace var06
{
    public class Card : ICheck
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
        public int Year {get; set;}

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Card(int _Number, int _Month, int _Year, int _Balance)
        {
            Number = _Number;
            month = _Month;
            Year = _Year;
            balance = _Balance;
        }
         //public static Card operator +(Card par1, Card par2)
         //{
         //   return new Card { balance = par1.balance + par2.balance };
         //}

        public static int operator +(Card card1, int val)
        {
            
            return card1.balance + val;
        }
        public static int operator -(Card card1, int val)
        {
            return card1.balance - val;
        }

        bool ICheck.Check(Card card)
        {
            if (card.balance < 0)
                
                return false;
            else
                return true;
            
        }
    }
}
