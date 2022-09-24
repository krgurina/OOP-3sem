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
            myList1 = myList1 + 52;

            myList1.PrintList();

            myList1 = myList1 >> 1;
            myList1.PrintList();

            myList2 = myList2 + 17;
            myList2 = myList2 + 178;
            myList2 = myList2 + 21;

            myList3 = myList3 + 17;
            myList3 = myList3 + 178;
            myList3 = myList3 + 21;


            Console.WriteLine("\nmyList1[0] != myList2[0] : " + (myList1[0] != myList2[0]));    //проверка на неравенство множеств
            Console.WriteLine("myList2[0] = myList3[0] : " + (myList2[0] == myList3[0]));   //проверка на равенство множеств

            //пофиксить
            Console.WriteLine("\nList1 != List2 : " + (myList1 != myList2));    //проверка на неравенство множеств
            //Console.WriteLine("List2 = List3 : " + (myList1 == myList3));   //проверка на равенство множеств

          

        }
    }
}
