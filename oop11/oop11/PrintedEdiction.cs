using System;
using System.Collections.Generic;
using System.Text;

namespace oop11
{
    class PrintedEdiction : PublishingOffice
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int publishYear;
        public int PublishYear
        {
            get { return publishYear; }
            set { publishYear = value; }
        }

        public PrintedEdiction(string _PublishName, string _title, int _PublishYear)
            : base(_PublishName)
        {
            title = _title;
            PublishYear = _PublishYear;
        }

        public override string ToString()
        {
            return base.ToString() + "\nНазвание: " + title + "\nГод печати: " + publishYear;
        }

        public override void Virtual()
        {
            Console.WriteLine("Работает 2 виртуалный метод");
        }
    }
}
