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

            //1 задание
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

            //2 задание --- Коллекция объектов, сериализация/десирализация, сохранение в файл
            List<Book> books = new List<Book>() { book1, book2, book3, book4 };
            CustomSerializer<Book>.Serialize(books, SERIALIZETYPE.JSON, @"F:\лабы\ООП\labs\oop13");
            CustomSerializer<Book>.Serialize(books, SERIALIZETYPE.XML, @"F:\лабы\ООП\labs\oop13");
            var xmlList = CustomSerializer<Book>.DeserializeToList(
                @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].xml");
            var jsonList = CustomSerializer<Book>.DeserializeToList(
                @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].json");

            //3 задание --- XPath
            XMLSelector.SelectByName("Война и мир", @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].xml");
            XMLSelector.SelectByBook("Book", @"F:\лабы\ООП\labs\oop13\System.Collections.Generic.List`1[oop13.Book].xml");

            //4 задание --- LINQ to XML
            Console.WriteLine("\nLINQ to XML:");
            XDocument xdoc = new XDocument();
            XElement bookstore = new XElement("bookstore"); //первый эл
            XAttribute bs_name_attr = new XAttribute("name", "Анна Каренина");
            XElement bs_author_elem = new XElement("author", "Толстой");
            XElement bs_yaer_elem = new XElement("yaer", "1878");
            bookstore.Add(bs_name_attr);            //заполняем аттрибутом и элем-ми
            bookstore.Add(bs_author_elem);
            bookstore.Add(bs_yaer_elem);

            XElement bookstore2 = new XElement("bookstore");    //второй эл
            XAttribute bs2_name_attr = new XAttribute("name", "Стихотворения и поэмы");
            XElement bs2_author_elem = new XElement("author", "Маяковский");
            XElement bs2_yaer_elem = new XElement("yaer", "1995");
            bookstore2.Add(bs2_name_attr);          //заполняем аттрибутом и элем-ми
            bookstore2.Add(bs2_author_elem);
            bookstore2.Add(bs2_yaer_elem);

            XElement bookstore3 = new XElement("bookstore");    //третий эл
            XAttribute bs3_name_attr = new XAttribute("name", "Война и мир");
            XElement bs3_author_elem = new XElement("author", "Толстой");
            XElement bs3_yaer_elem = new XElement("yaer", "1869");
            bookstore3.Add(bs3_name_attr);          //заполняем аттрибутом и элем-ми
            bookstore3.Add(bs3_author_elem);
            bookstore3.Add(bs3_yaer_elem);

            XElement root = new XElement("root");   //корневой элемент
            root.Add(bookstore);
            root.Add(bookstore2);
            root.Add(bookstore3);
            xdoc.Add(root);
            xdoc.Save(@"F:\лабы\ООП\labs\oop13\Books.xml"); //сохраняем в файл

            //запросы
            Console.WriteLine("Запрос 1: по автору(Толстой)"); 
            var items = xdoc.Element("root").Elements("bookstore")
                .Where(p => p.Element("author").Value == "Толстой")
                .Select(p => p);
            foreach (var item in items)
            {
                Console.WriteLine(item.Attribute("name").Value + " - " + item.Element("author").Value + " - " + item.Element("yaer").Value);
            }

            Console.WriteLine();
            Console.WriteLine("Запрос 2: по названию");
            var coun = xdoc.Element("root").Elements("bookstore")
                .Where(p => p.Attribute("name").Value == "Стихотворения и поэмы")
                .Select(p => p);
            foreach (var c in coun)
            {
                Console.WriteLine(c.Attribute("name").Value + " - " + c.Element("author").Value + " - " + c.Element("yaer").Value);
            }

        }
    }
}







