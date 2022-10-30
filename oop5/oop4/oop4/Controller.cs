using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop4
{
    class Controller
    {
        public Controller()                                             // конструктор без параметров (по умолчанию)
        {
        }


        public void FindBook(Library library)
        {
            Console.WriteLine("Введите год: ");
            int findYear = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < library.amount; i++)
            {
                if (findYear < library[i].PublishYear)
                {
                    Console.WriteLine(library[i].Title);
                }

            }

        }

        public void GetTextBookAmount(Library library)
        {
            TextBook textBookExample = new TextBook("wwwww", "Физика", 2011, 17, "учебная", 11);
            int textBookAmount = 0;
            for (int i = 0; i < library.amount; i++)
            {

                if (library[i].GetType() == textBookExample.GetType())
                {
                    textBookAmount++;
                }
            }
            Console.WriteLine($"\nКоличество учебников: {textBookAmount}\n");

        }

        public void GetPrise(Library library)
        {
            int sum = 0;
            for (int i = 0; i < library.amount; i++)
            {
                sum += library[i].Cost;

            }
            Console.WriteLine($"Стоимость всех книг: {sum}");
        }



        // чтение из файла
        String line;
        public string ReadBook()
        {
            StreamReader sr = new StreamReader("F:/лабы/ООП/labs/oop5/t.txt");
            line = sr.ReadLine();
            sr.Close();
            return line;
        }
        public string ReadMagazine()
        {
            StreamReader sr = new StreamReader("F:/лабы/ООП/labs/oop5/t.txt");
            line = sr.ReadLine();
            line = sr.ReadLine();
            sr.Close();
            return line;
        }

        public string ReadTextBook()
        {
            StreamReader sr = new StreamReader("F:/лабы/ООП/labs/oop5/t.txt");
            line = sr.ReadLine();
            line = sr.ReadLine();
            line = sr.ReadLine();
            sr.Close();
            return line;
        }

        



    }
}
