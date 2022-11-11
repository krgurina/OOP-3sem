using System;
using System.Collections.Generic;
using System.Text;

namespace oop7
{
    public class PrintedEdiction
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
        public PrintedEdiction(string _title, int _PublishYear, int _Cost)
            
        {
            title = _title;
            PublishYear = _PublishYear;
            cost = _Cost;
        }

        public override string ToString()
        {
            return "\nНазвание: " + title + "\nГод печати: " + publishYear;
        }

        
    }
}
