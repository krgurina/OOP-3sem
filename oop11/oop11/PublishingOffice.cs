using System;
using System.Collections.Generic;
using System.Text;

namespace oop11
{
    class PublishingOffice : Actions, IPrinter
    {
        private string publishName;
        public string PublishName
        {
            get { return publishName; }
            set { publishName = value; }
        }

        public PublishingOffice(string _PublishName)
        {
            PublishName = _PublishName;
        }


        public override string ToString()
        {
            return "Издательство: " + PublishName;
        }

        void IPrinter.PrintInfo()
        {
            Console.WriteLine("Печать");
        }

        //переопредление абстрактного класса
        public override void Work()
        {
            Console.WriteLine("Я печатаю книги и журналы");
        }

        // перегрузка виртуалного метода
        public override void Virtual()
        {
            Console.WriteLine("Работает переопределенный виртуалный метод");
        }

        //для одноименных методов
        void IPrinter.DoClone()
        {
            Console.WriteLine("Одноименный метод интерфейса");
        }
        public override void DoClone()
        {
            Console.WriteLine("Одноименный метод абстрактного класса");

        }




    }
}
