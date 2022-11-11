
using System;
using System.Collections.Generic;
using System.IO;

namespace oop7
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

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


                CollectionType<int> intCollection2 = new CollectionType<int>();
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

                //исключение
                //strCollection.Add();
                //strCollection.Delete();
            

                CollectionType<string> strCollection2 = new CollectionType<string>();
                strCollection2.Add("qqq");
                strCollection2.Add("wwww");
                strCollection2.Add("eee");

                CollectionType<string> strCollection3 = new CollectionType<string>();
                strCollection2.Add("qqq");
                strCollection2.Add("wwww");
                strCollection2.Add("eee");

                CollectionType<List<int>> intListCollection = new CollectionType<List<int>>();
                intListCollection.Add(myList);
                intListCollection.Add(myList2);

                CollectionType<List<int>> intListCollection2 = new CollectionType<List<int>>();
                intListCollection2.Add(myList);
                intListCollection2.Add(myList2);


                //проверка перегрузок
                Console.WriteLine(strCollection == strCollection2);
                Console.WriteLine(intCollection2 == intCollection);
                Console.WriteLine(strCollection3 == strCollection2);
                Console.WriteLine(intListCollection != intListCollection2);

                PrintedEdiction ediction1 = new PrintedEdiction("qqq", 2022, 20);
                PrintedEdiction ediction2 = new PrintedEdiction("www", 2011, 20);

                //класс в качестве параметра
                CollectionType <PrintedEdiction> editionList1= new CollectionType<PrintedEdiction>();
                editionList1.Add(ediction1);
                editionList1.Add(ediction2);
                editionList1.Show();

                CollectionType<PrintedEdiction> editionList2 = new CollectionType<PrintedEdiction>();
                editionList2.Add(ediction1);
                editionList2.Add(ediction2);
                //editionList2.Show();

                Console.WriteLine();
                Console.WriteLine(editionList1 == editionList2);
                Console.WriteLine(editionList1 != editionList2);


                Console.WriteLine("Тест eqals");
                Console.WriteLine(intListCollection.Equals(intListCollection2));

                //пофиксить
                Console.WriteLine(strCollection.Equals(strCollection2));

                ////чтение из файла
                CollectionType<int>.WriteToFile(intCollection);
                CollectionType<int>.LoadFromFile();

                CollectionType<string>.WriteToFile(strCollection);
                CollectionType<string>.LoadFromFile();


















































            }


            // обработка исключений
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Программа завершена.");
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
