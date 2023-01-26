using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto audi = new Auto(Auto.Marka.Audi, 2017);
            Auto bmv = new Auto(Auto.Marka.BMW, 2020);
            Auto porhe = new Auto(Auto.Marka.Porche, 2019);

            MyColl first = new MyColl();
            first.Add(audi);
            first.ShowElements();
            first.Add(bmv);
            first.ShowElements();

            Console.WriteLine("________________________________________________________________");
            MyDictionary<Auto> second = new MyDictionary<Auto>();
            second.Add(0, porhe);
            second.Add(1, new Auto(Auto.Marka.Lamborgini, 2022));
            second.Add(2, new Auto(Auto.Marka.Audi, 2021));  
            second.ShowElements();
            second.RemoveElements(1, 1);
            Console.WriteLine("________________________________________________________________");

            Console.WriteLine("После удаления: ");
            second.ShowElements();
            Console.WriteLine("После добавления: ");
            second.Add(3, new Auto(Auto.Marka.Lamborgini, 2021));
            second.Add(5, new Auto(Auto.Marka.BMW, 2023));
            second.ShowElements();
            Console.WriteLine("________________________________________________________________");

            SortedList<int, Auto> list = new SortedList<int, Auto>();
            foreach (var val in second)
            {
                list.Add(val.Key, val.Value);
            }

            foreach (var val in list)
            {
                Console.WriteLine(val);
            }
            FindValue(list, porhe);

            Console.WriteLine("________________________________________________________________");

            ObservableCollection<Auto> collection = new ObservableCollection<Auto>()
            {
                new Auto(Auto.Marka.Lamborgini, 2022),
                new Auto(Auto.Marka.Audi, 2021),
                porhe
            };
            collection.CollectionChanged += Auto_CollectionChanged;
            collection.Add(new Auto(Auto.Marka.Audi, 2022));
            collection.Remove(porhe);
            


        }

        private static void Auto_CollectionChanged(object obj, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Auto newCar = e.NewItems[0] as Auto;
                    Console.WriteLine($"добавлен новый объект {newCar}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Auto oldCar = e.OldItems[0] as Auto;
                    Console.WriteLine($"удален объект {oldCar}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Auto replacedCar = e.OldItems[0] as Auto;
                    Auto replacingCar = e.NewItems[0] as Auto;
                    Console.WriteLine($"объект {replacedCar} заменен {replacingCar} ");
                    break;
            }
        }

        public static void FindValue<T>(SortedList<int, T> list, T value)
        {
            if (list.ContainsValue(value))
            {
                Console.WriteLine(value);
            }

        }



    }
    }

