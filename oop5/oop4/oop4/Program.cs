using System;

namespace oop4
{
    class Program
    {
        // 5 лаба
        // перечисление
        enum Books
        {
            PrintedEdition,
            TextBook,
            Magazine = 4,
            Book

        }

        //структура
        struct Information  
        {
            public string book;
            public string person;
            public string name;
            public void Print()
            {
                Console.WriteLine(book+person+name);
            }
        }
        static void Main(string[] args)
        {
            //создание объекта структуры
            Information information;
            information.book = "book1";
            information.person = "person1";
            information.name = "name1";

            information.Print();


            Books books = Books.Book;
            Console.WriteLine(books);



            PublishingOffice office = new PublishingOffice("qqqqqq");
            Console.WriteLine(office);
            Console.WriteLine();

            PrintedEdiction ediction = new PrintedEdiction("wwwww", "Дюна", 1965);
            Book book = new Book("wwwww", "Дюна", 1965, "фантастика");
            TextBook textBook = new TextBook("wwwww", "Физика", 2020, "учебная", 11);


            Person person = new Person("wwwww", "Кристина", "Гурина");
           
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


            /////////////////////////////////////////////////////////////////////////////////////
            // 5 лаба

            var firstItem = book;
            var secondItem = new Magazine("Издательство", "Весёлые овощи", 2020, "Огородники");
            var thirdItem = textBook;

            Library library = new Library(firstItem, secondItem, thirdItem);

            Console.WriteLine("\nПроверка методов класса-контейнера:");
            library.Add(firstItem);
            library.Add(secondItem);
            library.Add(thirdItem);

            Console.WriteLine("Вывод всех первоначальных объектов:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            library.Printing();

            Console.ForegroundColor = ConsoleColor.White;
            library.Delete(firstItem);
            Console.WriteLine("\nВывод объектов после удаления:");
            library.Printing();

            library.Add(firstItem);
            Console.WriteLine($"\nКоличество книг в библиотеке: {library.amount}");

            library.GetTextBookAmount(library);
            //GetTextBookAmount(library);

            //поиск по году
            library.FindBook(library);

            //Console.WriteLine(thirdItem.GetType());
            //var tt = textBook.GetType();

            //static void GetTextBookAmount(Library library)
            //{
            //    TextBook textBookExample = new TextBook("wwwww", "Физика", 2011, "учебная", 11);
            //    int textBookAmount = 0;
            //    for (int i = 0; i < library.amount; i++)
            //    {

            //        if (library[i].GetType() == textBookExample.GetType())
            //        {
            //            textBookAmount++;
            //        }
            //    }
            //    Console.WriteLine($"\nКоличество учебников: {textBookAmount}");

            //}


        }
    }
}
