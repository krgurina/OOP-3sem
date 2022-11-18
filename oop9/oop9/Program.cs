using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
namespace oop9
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer("MSI Leopard GL65", "Red", 2700);
            Computer computer2 = new Computer("ASUS TUF Gaming F15", "Purple", 2500);
            Computer computer3 = new Computer("Lenova IdeaPad", "Blue", 2000);
            Computer computer4 = new Computer("qqq", "www", 3000);

            MyCollection<Computer> computers = new MyCollection<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Show();

            computers.Remove(computer4);
            computers.Show();

           
            Computer found = computers.Find(item => item.Price == 1);

        }
    }
}
