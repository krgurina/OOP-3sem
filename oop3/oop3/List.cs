using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace oop3
{
    class List
    {
        

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

        // перегрузка
        // >> - удалить элемент в заданной позиции
        public static List operator >>(List list, int position)
        {
            list.RemoveAtPos(position);
            return list;
        }

        // + - добавить элемент
        public static List operator +(List list, int element)
        {
            list.AddItem(element);
            return list;
        }

        public static bool operator !=(List list1, List list2)
        {
            return !list1.Equals(list2);
        }

        public static bool operator ==(List list1, List list2)
        {
            return list1.Equals(list2);
        }

        /////////////////////////////////////////////
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            List listItem = (List)obj;
            return this.MyList == listItem.MyList && this.Count == listItem.Count;
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    if (obj.GetType() != this.GetType()) return false;

        //    if (obj is List)
        //    {
        //        List tmp = (List)obj;

        //        foreach (int item1 in this.MyList)
        //        {
        //            foreach (int item2 in tmp.MyList)
        //            {
        //                if (item1 != item2)
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //        return true;
        //    }
        //    return false;
        //}
        /////////////////////////////////////
        public override int GetHashCode()
        {
            return Count.GetHashCode();
        }

       







        }
}
