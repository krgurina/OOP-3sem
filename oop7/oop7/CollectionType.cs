
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop7
{
    public class CollectionType<T>:IGeneric<T>// where T : class
    {
        //private int _count;




        public List<T> list { get; set; }
        public int Count => this.list.Count;
        public CollectionType()
        {
            this.list = new List<T>();
            //_count = 1;
        }

        public void Add(T element)
        {
            list.Add(element);
            //_count++;
        }
        public void Show()
        {
            foreach (T element in this.list)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\n");
        }
        public void Delete(T deleteEl)
        {
            this.list.Remove(deleteEl);
            //_count--;


        }










        //public CollectionType<T> this[int index]
        //{
        //    get
        //    {
        //        if (index > list.Count)
        //        {
        //            Console.WriteLine("Превышен максимальный индекс списка печатных изданий");
        //            return null;
        //        }
        //        return list[index];
        //    }
        //    set
        //    {
        //        if (index > list.Count)
        //            Console.WriteLine("Элемента с таким индексом не существует");
        //        else
        //            list[index] = value;
        //    }
        //}











        //public override string ToString()
        //{
        //    return "ID: " + this.list.GetRange(0, list.Count);
        //}

        //public override string ToString()
        //{
        //    return base.ToString() + this.list.GetRange(0,list.Count);
        //}

        //public int this[int index]
        //{
        //    get => this.list[index];

        //    set => this.list[index] = value;
        //}



        //public override string ToString()
        //{
        //    return base.ToString() + ": " + value.ToString();
        //}



































        public static bool operator ==(CollectionType<T> c1, CollectionType<T> c2)
        {
            if (c1.list is List<int> || c1.list is List<string>)
            {
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if (c1.list[i].Equals(c2.list[i]))
                        return true;
                }

            }
            //if (c1.list is List<Magazine>)
            //{
            //    List<Magazine> MagazineList1 = new List<Magazine>();
            //    MagazineList1 = c1.list as List<Magazine>;
            //    List<Magazine> MagazineList2 = new List<Magazine>();
            //    MagazineList2 = c2.list as List<Magazine>;
            //    for (int i = 0; i < c1.list.Count; i++)
            //    {
            //        if (MagazineList1[i].Power == MagazineList2[i].Power)//разобрать
            //            return true;
            //    }
            //}
            return false;
        }

        public static bool operator !=(CollectionType<T> c1, CollectionType<T> c2)
        {
            if (c1.list is List<int> || c1.list is List<string>)
            {
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if (!c1.list[i].Equals(c2.list[i]))
                        return true;
                }

            }
            //if (c1.list is List<Magazine>)
            //{
            //    List<Magazine> MagazineList1 = new List<Magazine>();
            //    MagazineList1 = c1.list as List<Magazine>;
            //    List<Magazine> MagazineList2 = new List<Magazine>();
            //    MagazineList2 = c2.list as List<Magazine>;
            //    for (int i = 0; i < c1.list.Count; i++)
            //    {
            //        if (MagazineList1[i].Power != MagazineList2[i].Power)
            //            return true;
            //    }
            //}
            return false;
        }














        // перегрузка
        // >> - удалить элемент в заданной позиции
        //public static List<T> operator >>(List<T> list, int position)
        //{
        //    list.RemoveAt(position);
        //    return list;
        //}

        //// + - добавить элемент
        //public static List<T> operator +(List<T> list, List<T> list2)
        //{
        //    list.Add(list2);
        //    return list;
        //}

        //public static bool operator !=(List<T> list1, List<T> list2)
        //{
        //    return !list1.Equals(list2);
        //}

        //public static bool operator ==(List<T> list1, List<T> list2)
        //{
        //    return list1.Equals(list2);
        //}


        public override int GetHashCode()
        {
            return Count.GetHashCode();
        }



        //public override bool Equals(object obj)
        //{

        //    if (obj == null) return false;
        //    if (obj.GetType() != this.GetType()) return false;
        //    List<T> listItem = obj as List<T>;
        //    // List<T> listItem = (List<T>)obj;
        //    return this.list == listItem.list && this.Count == listItem.Count;

        //    for (int i = 0; i < this.list.Count; i++)
        //    {
        //        for (int j = 0; i < listItem.list.Count; j++)
        //        {
        //            if (this.list[i] == listItem.list[j])
        //                continue;
        //            else return false;
        //        }
        //    }
        //    return true;

        //}















    }
}
