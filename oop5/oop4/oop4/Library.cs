using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Library
    {
        public int price = 0;
        public int amount = 0;
        public List<PrintedEdiction> list = new List<PrintedEdiction>();
        public Library(Book firstItem, Magazine secondItem, TextBook thirdItem)
        {

        }
        public Library(string firstItem, string secondItem, string thirdItem)
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

    }
}
