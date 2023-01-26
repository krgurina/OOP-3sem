using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 задание
            Console.WriteLine("===================== Моя коллекция =====================");
            Computer computer1 = new Computer("MSI Leopard GL65", "Red", 2700);
            Computer computer2 = new Computer("ASUS TUF Gaming F15", "Purple", 2500);
            Computer computer3 = new Computer("Lenova IdeaPad", "Blue", 2700);
            Computer computer4 = new Computer("qqq", "www", 3000);

            SuperHashSet<Computer> computers = new SuperHashSet<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Show();

            //2 задание 
            Console.WriteLine("Количество элементов в коллекции равных заданному:");
            var count = computers.hset.Where(x => x.Price > 2600 && x.Price <= 3000).Count();
            Console.WriteLine(count);

            //вывести найденный элемент 
            Console.WriteLine("Найденный элемент:");
            var element = computers.hset.Where(x => x.Price > 2600 && x.Price <= 3000).Select(x => x);

            foreach (var item in element)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //3 задание
            Button b1 = new Button("Кнопка №1");
            Button b2 = new Button("Кнопка №2");
            User user = new User("Кристина");
            user.Click += b2.OnClick;
            user.Click += b1.OnClick;
            user.CommandClick();
        }
    }
}
