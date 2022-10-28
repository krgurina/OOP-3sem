using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    partial class Book : PrintedEdiction
    {
        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public Book(string _PublishName, string _title, int _PublishYear, string _Genre)
           : base(_PublishName, _title, _PublishYear)
        {
            Genre = _Genre;
        }

       
    }
}
