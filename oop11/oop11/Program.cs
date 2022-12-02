using System;

namespace oop11
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishingOffice office = new PublishingOffice("Питер");
            PrintedEdiction book = new PrintedEdiction("Эксмо", "ОНО", 1986);
            PrintedEdiction book2 = new PrintedEdiction();

            Console.WriteLine(new string('=', 107));
            Reflector.ToFile(office, typeof(int));       // передаем typeof, потому что внутри есть обращение к GetSomeMethods().

            Console.WriteLine(new string('=', 107));
            Reflector.ToFile(book, typeof(int));

            Console.WriteLine(new string('=', 107));
            //Reflector.InvokeClass(oop11.PrintedEdiction, );
            Reflector.Invoke("oop11.PrintedEdiction", "Toconsole");

            Console.WriteLine(new string('=', 107));
            Reflector.Create("oop11.PublishingOffice", "Kristina");
            Console.ReadKey();
        }
    }
}
