using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Controller
    {
		public Controller()                                             // конструктор без параметров (по умолчанию)
		{
		}


		//public void NumberOfEachType()                                  // Подсчёт количества каждого вида техники
		//{
		//	Console.WriteLine("\n\tКоличество каждого вида техники: ");
		//	Console.ForegroundColor = ConsoleColor.DarkCyan;
		//	Console.WriteLine(" -> Количество книг: " + Book.amount);
		//	Console.WriteLine(" -> Количество учебников:" + TextBook.amount);
		//	Console.WriteLine(" -> Количество журналов: " + Magazine.amount);
		//	Console.ForegroundColor = ConsoleColor.White;
		//}

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

    }
}
