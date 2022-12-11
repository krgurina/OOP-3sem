using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace oop13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();


            Book book1 = new Book("Война и мир", 1869, "Толстой");
            Book book2 = new Book("Бородино", 1977, "Лермонтов");
            Book book3 = new Book("Мастер и Маргарита", 1987, "Булгаков");
            Book book4 = new Book("Стихотворения и поэмы", 1995, "Маяковский");
            Book book5 = new Book("Анна Каренина", 1878, "Толстой");

            //сериализация
            CustomSerializer<Book>.Serialize(book1, SERIALIZETYPE.JSON, @"F:\лабы\ООП\labs\oop13");
            CustomSerializer<Book>.Serialize(book1, SERIALIZETYPE.XML, @"F:\лабы\ООП\labs\oop13");
            CustomSerializer<Book>.Serialize(book1, SERIALIZETYPE.SOAP, @"F:\лабы\ООП\labs\oop13");
            CustomSerializer<Book>.Serialize(book1, SERIALIZETYPE.Binary, @"F:\лабы\ООП\labs\oop13");

            //десериализация
            var binBook1 = CustomSerializer<Book>.Deserialize(@"F:\лабы\ООП\labs\oop13\oop13.Book.bin");
            var xmlBook1 = CustomSerializer<Book>.Deserialize(@"F:\лабы\ООП\labs\oop13\oop13.Book.xml");
            var soapBook1 = CustomSerializer<Book>.Deserialize(@"F:\лабы\ООП\labs\oop13\oop13.Book.soap");
            var jsonBook1 = CustomSerializer<Book>.Deserialize(@"F:\лабы\ООП\labs\oop13\oop13.Book.json");

            //2
            List<Book> books = new List<Book>() { book1, book2, book3, book4 };
            CustomSerializer<Book>.Serialize(books, SERIALIZETYPE.JSON, @"F:\лабы\ООП\labs\oop13");
            CustomSerializer<Book>.Serialize(books, SERIALIZETYPE.XML, @"F:\лабы\ООП\labs\oop13");
            var xmlList = CustomSerializer<Book>.DeserializeToList(
                @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].xml");
            var jsonList = CustomSerializer<Book>.DeserializeToList(
                @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].json");
        }
    }
}







