using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop10
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public int PageNumber { get; set; }
        public int Price { get; set; }

        public Book(string Title, string Author, int PublishYear, int PageNumber, int Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.PublishYear = PublishYear;
            this.PageNumber = PageNumber;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"{Title}, {Author}, {PublishYear} год, {PageNumber} страниц, ЦЕНА:{Price}";
        }
    }
}