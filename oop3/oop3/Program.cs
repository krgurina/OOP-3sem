using System;

namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {

            List myList = new List();

            myList.AddItem(9);
            myList.AddItem(17);
            myList.AddItem(19);
            myList.AddItem(21);
            myList.AddItem(145);
            myList.AddItem(25);

            myList.PrintList();

            myList.RemoveItem();
            myList.PrintList();

            myList.RemoveAtPos(3);
            myList.PrintList();
            
            myList.AddItem(1111);
            myList.PrintList();


        }
    }
}
