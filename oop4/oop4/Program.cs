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

            Author author = new Author("wwwww", "Кристина", "Гурина", "*псевдоним*");
            //Console.WriteLine(author);
            //Console.WriteLine();

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

        }
    }
}
