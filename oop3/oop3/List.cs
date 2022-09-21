using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace oop3
{
    class List
    {
        public class Developer
        {
            public int id;
            public string DevName;
            public string department;

            public Developer(int id, string DevName, string department)
            {
                this.id = id;
                this.DevName = DevName;
                this.department = department;

            }
        }

        public List()
        {
            this.MyList = new List<int>();
        }

        public List<int> MyList { get; set; }
        public int Count => this.MyList.Count;  //количество
        public void AddItem(int element) => this.MyList.Add(element);  //добавление элемента
        public int RemoveItem()    //удаление элемента
        {
            int lastElementIndex = this.MyList.Count - 1;
            int lastElement = this.MyList[lastElementIndex];
            this.MyList.RemoveAt(lastElementIndex);
            return lastElement;
        }

        public void RemoveAtPos(int pos) //удаление элемента в заданной позиции
        {
            this.MyList.RemoveAt(pos);
        }

        public void PrintList()
        {
            Console.WriteLine("Список: ");
            for (int i = 0; i < MyList.Count; i++)
            {
                Console.WriteLine(MyList[i]);
            }
        }
        //индексатор
        public int this[int index]
        {
            get => this.MyList[index];

            set => this.MyList[index] = value;
        }






    }
}
