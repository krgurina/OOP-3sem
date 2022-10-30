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

            PrintedEdiction ediction = new PrintedEdiction("wwwww", "Дюна", 1965, 20);
            Book book = new Book("wwwww", "Дюна", 1965, 22, "фантастика");
            TextBook textBook = new TextBook("wwwww", "Физика", 2020, 17, "учебная", 11);


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
            // класс контейнер
            var firstItem = book;
            var secondItem = new Magazine("Издательство", "Весёлые овощи", 2020, 5, "Огородники");
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

           
            // класс контроллер
            Controller controller = new Controller();
            controller.GetTextBookAmount(library);
            controller.FindBook(library);
            controller.GetPrise(library);

            // читение из файла
            string book1;
            string magazine1;
            string textBook1;

            book1 = controller.ReadBook();
            magazine1 = controller.ReadMagazine();
            textBook1 = controller.ReadTextBook();

            Library library2 = new Library(book1, magazine1, textBook1);

        }
    }
}
