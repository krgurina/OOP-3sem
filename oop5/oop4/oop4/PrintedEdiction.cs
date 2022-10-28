using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
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

        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public PrintedEdiction(string _PublishName, string _title, int _PublishYear, int _Cost)
            : base(_PublishName)
        {
            title = _title;
            PublishYear = _PublishYear;
            cost = _Cost;
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
