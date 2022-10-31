using System;
using System.Diagnostics;

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

            Console.WriteLine("\n\n\n ________________Для лабораторной работы №6_________________\n");

            // Объект класса принимает значение NULL
            try
            {
                object obj = "String";
                Book bk = obj as Book;
                if (bk == null)
                {
                    throw new NullObject();     
                }
            }
            catch (NullObject e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                e.PrintInfo();
            }

            //int a = -10;
            //Debug.Assert(a > 0);

            try
            {
                Book bk2 = new Book("wwwww", "Преступление и наказание", 2023, 22, "русская классика");

                if (bk2.PublishYear > 2022)
                {
                    throw new WrongDate("Неверный год! Книга не напечатана");
                }
            }
            catch (WrongDate e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                e.PrintInfo();
            }


            // множественная обработка исключения
            // неверная стоимость
            try
            {
                try
                {
                    Book bk3 = new Book("wwwww", "Преступление и наказание", 2023, -22, "русская классика");
                    if (bk3.Cost < 0)
                    {
                        throw new WrongCost("Неверная стоимость!");
                    }
                }

                catch (WrongCost e)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    e.PrintInfo();
                    throw;

                }
            }

            catch (WrongCost e)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                e.PrintInfo();
                
            }


            // Деление на 0
            try
            {
                int x = 5, y = 0;
                int c = x / y;
            }
            //общий обработчик исключений
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(e.Message + "\n");
            }



            // Выход за границы массива
            try
            {
                int[] arr = new int[8];
                arr[10] = 10;
            }

            //
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(e.Message + "\n");
            }

            //универсальный обработчик
            catch 
            {
                Console.WriteLine("\nработает универсальный обработчик\n");
            }

            finally     
                        
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tFINALLY > Обязательное выполнение данного кода \n");
            }


            // Тестирование макроса Assert.

            /* Проверяет условие.
             Если условие имеет значение false,
             выдается сообщение и отображается окно сообщения со стеком вызовов */
            //Программа продолжается без каких-либо перерывов, если условие истинно.

            //int a = -10;
            //Debug.Assert(a > 0);

            //Book bk4 = new Book("wwwww", "Преступление и наказание", 2023, 22, "русская классика");
            //Debug.Assert(bk4.PublishYear > 2022, "Год печати не может быть больше 2022");








        }
    }
}
