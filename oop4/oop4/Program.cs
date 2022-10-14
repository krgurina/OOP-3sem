using System;

namespace oop4
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishingOffice office = new PublishingOffice("qqqqqq");
            Console.WriteLine(office);
            Console.WriteLine();

            PrintedEdiction ediction = new PrintedEdiction("wwwww", "Дюна", 1965);
            Console.WriteLine(ediction);
            Console.WriteLine();

            Book book = new Book("wwwww", "Дюна", 1965, "фантастика");
            //Console.WriteLine(book);
            //Console.WriteLine();

            TextBook textBook = new TextBook("wwwww", "Физика", 2020, "учебная", 11);
            //Console.WriteLine(textBook);
            //Console.WriteLine();

            Person person = new Person("wwwww", "Кристина", "Гурина");
            //Console.WriteLine(person);
            //Console.WriteLine();

            Author author = new Author("wwwww", "Имя", "Фамилия", "*псевдоним*");
            Author author1 = new Author("wwwww", "qqqq", "www", "*eeeee*");


            // для интерфейса
            author.PrintInfo();
            // метод абстрактного класса
            office.Work();
            office.Virtual();
            ediction.Virtual();

            //одноименные методы
            office.DoClone();

            IPrinter printer = office;
            printer.DoClone();

            ((IPrinter)office).DoClone();

            Person person1 = author;
            Person person2 = author1 as Person;

            Console.WriteLine();
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine();

            Console.WriteLine(office is Person);
            Console.WriteLine(author is Person);
            Console.WriteLine(textBook is Book);

            // переменная ссылка на интерфейс
            IPrinter printer1 = office as IPrinter;


            Object[] objarr = { office, ediction, book, textBook, author };
            
            foreach (var item in objarr)
            {

                Printer.IAmPrinting(item);

            }
        }
    }
}
