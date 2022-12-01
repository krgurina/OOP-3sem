using System;

namespace oop11
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishingOffice office = new PublishingOffice("Питер");
            PrintedEdiction book = new PrintedEdiction("Эксмо", "ОНО", 1986);

            Console.WriteLine(new string('=', 107));
            Reflector.ToFile(office, typeof(int));       /// передаем typeof, потому что внутри есть обращение к GetSomeMethods().
                                                      /// внутренние фукнциии ToFile() выводят информацию и в файл, и на консось
            Console.WriteLine(new string('=', 107));
            Reflector.ToFile(office, typeof(int));

            Console.WriteLine(new string('=', 107));
            Reflector.InvokeClass(book, "Lab11Method");


        }
    }
}
