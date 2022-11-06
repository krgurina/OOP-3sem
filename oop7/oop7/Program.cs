
using System;
using System.Collections.Generic;
using System.IO;

namespace oop7
{
    class Program
    {
        static void Main(string[] args)
        {

            // try
            //{

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            List<int> myList2 = new List<int>();
            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(6);





            //  Создание коллекций
            CollectionType<int> intCollection = new CollectionType<int>();
            // фукции коллекции
            intCollection.Add(11);
            intCollection.Add(22);
            intCollection.Add(33);
            intCollection.Add(44);
            intCollection.Show();
            intCollection.Delete(11);
            intCollection.Show();

           
            CollectionType<string> strCollection = new CollectionType<string>();
            strCollection.Add("qqq");
            strCollection.Add("wwww");
            strCollection.Add("eee");
            strCollection.Show();
            strCollection.Delete("qqq");
            strCollection.Show();

            CollectionType<List<int>> intListCollection = new CollectionType<List<int>>();
            intListCollection.Add(myList);
            intListCollection.Add(myList2);
            intListCollection.Show();
            myList.GetRange(0, myList.Count);


















































            //}


            //// обработка исключений
            //catch (MyException ex)
            //{
            //    consoleLogger.WriteLog(ex);
            //}
            //finally { }



        }
    }
}
