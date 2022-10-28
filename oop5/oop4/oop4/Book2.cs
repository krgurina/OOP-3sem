using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    partial class Book
    {
        public override string ToString()
        {
            return base.ToString() + "\nЖанр: " + genre;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            Book book = obj as Book;
            if (book == null)
                return false;
            return this.PublishName == book.PublishName && this.PublishYear == book.PublishYear && this.Title == book.Title
                && this.Genre == book.Genre;
        }

        public override int GetHashCode()
        {
            int hash = 269;
            hash = string.IsNullOrEmpty(PublishName) ? 0 : PublishName.GetHashCode();
            hash = (hash * 47) + Title.GetHashCode();
            return hash;
        }
    }
}
