using System;


namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {

            List myList1 = new List();
            List myList2 = new List();
            List myList3 = new List();

            myList1 = myList1 + 1;
            myList1 = myList1 + 19;
            myList1 = myList1 + 27;
            myList1 = myList1 + 0;

            myList1.PrintList();

            myList1 = myList1 >> 1;
            myList1.PrintList();

            myList2 = myList2 + 17;
            myList2 = myList2 + 178;
            myList2 = myList2 + 21;

            myList3=myList2;

            Console.WriteLine("\nList1 != List2 : " + (myList1 != myList2));    //проверка на неравенство множеств
            Console.WriteLine("List3 != List2 : " + (myList3 != myList2));
            Console.WriteLine("List2 = List3 : " + (myList2 == myList3));   //проверка на равенство множеств
            Console.WriteLine("List1 = List3 : " + (myList1 == myList3));
            Console.WriteLine();

            List.Date date = new List.Date(28, 9, 2003);
            myList1.owner = new Owner(183748,"Kris","BSTU");

            StatisticOperation.GetSum(myList2);
            StatisticOperation.MinMaxDifference(myList2);
            StatisticOperation.GetCount(myList2);

            string[] srtArr = { "aaa", "bbbbb", "ccccccc" };            
            Console.WriteLine($"Самое длинное слово: { srtArr.MaxLength()}");

            myList2.PrintList();
            Console.WriteLine($"Удаление последнего элемента: ");
            myList2.Del();
            myList2.PrintList();
        }
    }
}
