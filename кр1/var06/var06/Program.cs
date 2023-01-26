using System;

namespace var06
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 a
            Console.WriteLine(ushort.MaxValue);
            //1 б
            string[] strArr = {"Поледельник","Вторник", "Среда", "Четверг", "Пятница","Суббота", "Воскресенье" };

            //2
            Card card1 = new Card(4444, 11, 27, 115);

            Console.WriteLine($"Баланс: {card1.Balance}");
            card1.Balance = card1.Balance + 100;
            Console.WriteLine($"Баланс: {card1.Balance}");
            card1.Balance = card1.Balance - 100;
            Console.WriteLine($"Баланс: {card1.Balance}");

            CardWithHistory card2 = new CardWithHistory(2222, 11, 27, 1154);
            string[] history;
            card2.Balance = card2.Balance + 100;
            




        }
    }
}
