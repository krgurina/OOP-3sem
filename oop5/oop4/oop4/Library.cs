using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Library
    {
        public int amount = 0;
        public List<PrintedEdiction> list = new List<PrintedEdiction>();
        public Library(Book firstItem, Magazine secondItem, TextBook thirdItem)
        {

        }

        public void Add(PrintedEdiction obj)   
        {
            list.Add(obj);
            amount++;
        }

        public void Delete(PrintedEdiction obj)   
        {
            
            list.Remove(obj);
            amount--;
        }
        public void Printing()             
        {
            foreach (var i in list)
            {
                
                Console.WriteLine(i.ToString());
                Console.WriteLine();
            }

        }




        //индексатор
        public PrintedEdiction this[int index]
        {
            get
            {
                if (index > list.Count)
                {
                    Console.WriteLine("Превышен максимальный индекс списка печатных изданий");
                    return null;
                }
                return list[index];
            }
            set
            {
                if (index > list.Count)
                    Console.WriteLine("Элемента с таким индексом не существует");
                else
                    list[index] = value;
            }
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
            TextBook textBookExample = new TextBook("wwwww", "Физика", 2011, "учебная", 11);
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

    }
}
