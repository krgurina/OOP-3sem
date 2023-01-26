using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Button button = new Button(user);
            user.ButtonClick();


            Console.WriteLine("===================== Моя коллекция =====================");
            Computer computer1 = new Computer("MSI Leopard GL65", "Red", 2700);
            Computer computer2 = new Computer("ASUS TUF Gaming F15", "Purple", 2500);
            Computer computer3 = new Computer("Lenova IdeaPad", "Blue", 3000);
            Computer computer4 = new Computer("qqq", "www", 3000);

            SuperHashSet<Computer> computers = new SuperHashSet<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Show();

            //на основе LINQ подсчитать количество элементов в коллекции равных заданному и вывести их на экран
            
            Console.WriteLine("Количество элементов в коллекции равных заданному:");
            var count = computers.hset.Where(x => x.Price == 3000).Count();
            Console.WriteLine(count);

            //вывести найденный элемент 
            Console.WriteLine("Найденный элемент:");
            var element = computers.hset.Where(x => x.Price == 3000).FirstOrDefault();
            foreach (var item in computers.hset)
            {
                if (item.Price == 3000)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}