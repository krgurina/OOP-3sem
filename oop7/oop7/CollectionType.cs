
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace oop7
{
    public class CollectionType<T>:IGeneric<T>// where T : PrintedEdiction
    {
        public int _count { get; set; }
        public List<T> list { get; set; }
        public int Count => this.list.Count;
        public CollectionType()
        {
            this.list = new List<T>();
            _count = 1;
        }

        public void Add(T element)
        {
            list.Add(element);
            _count++;
        }
        internal void Add()
        {
            throw new NotImplementedException("ИСКЛЮЧЕНИЕ: Метод или операция не реализованы!\n");
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
            if (_count == 0)
                throw new InvalidOperationException();
            this.list.Remove(deleteEl);
            _count--;
        }
        internal void Delete()
        {
            throw new NotImplementedException("ИСКЛЮЧЕНИЕ: Метод или операция не реализованы!\n");
        }

        // перегрузки
        public static bool operator ==(CollectionType<T> t1, CollectionType<T> t2)
        {
            if (t1.list is List<int> || t1.list is List<double>)
            {
                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (!t1.list[i].Equals(t2.list[i]))
                        return false;
                }
                return true;
            }

            if (t1.list is List<string>)
            {
                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (!t1.list[i].Equals(t2.list[i]))
                        return false;
                }
                return true;
            }

            if (t1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList1 = new List<PrintedEdiction>();
                PrintedEdictionList1 = t1.list as List<PrintedEdiction>;
                List<PrintedEdiction> PrintedEdictionList2 = new List<PrintedEdiction>();
                PrintedEdictionList2 = t2.list as List<PrintedEdiction>;

                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (PrintedEdictionList1[i].PublishYear != PrintedEdictionList2[i].PublishYear|| PrintedEdictionList1[i].Title== PrintedEdictionList2[i].Title)
                        return false;
                }

                return true;
            }

            return false;
        }

        public static bool operator !=(CollectionType<T> t1, CollectionType<T> t2)
        {
            if (t1.list is List<int> || t1.list is List<double>)
            {
                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (!t1.list[i].Equals(t2.list[i]))
                        return true;
                }
                return false;
            }

            if (t1.list is List<string>)
            {
                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (!t1.list[i].Equals(t2.list[i]))
                        return true;
                }
                return false;
            }

            if (t1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList1 = new List<PrintedEdiction>();
                PrintedEdictionList1 = t1.list as List<PrintedEdiction>;
                List<PrintedEdiction> PrintedEdictionList2 = new List<PrintedEdiction>();
                PrintedEdictionList2 = t2.list as List<PrintedEdiction>;

                for (int i = 0; i < t1.list.Count; i++)
                {
                    if (PrintedEdictionList1[i].PublishYear == PrintedEdictionList2[i].PublishYear || PrintedEdictionList1[i].Title == PrintedEdictionList2[i].Title)
                        return false;
                }

                return true;
            }

            return false;
        }

        public static bool operator >(CollectionType<T> c1, CollectionType<T> c2)
        {
            if (c1.list is List<int> && c2.list is List<int>)
            {
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if ((dynamic)c1.list[i] < (dynamic)c2.list[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (c1.list is List<string> && c2.list is List<string>)
            {
                List<string> tempList1 = new List<string>();
                tempList1 = c1.list as List<string>;
                List<string> tempList2 = new List<string>();
                tempList2 = c2.list as List<string>;
                {
                    for (int i = 0; i < c1.list.Count; i++)
                    {
                        if (tempList1[i].Length < tempList2[i].Length)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            if (c1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList1 = new List<PrintedEdiction>();
                PrintedEdictionList1 = c1.list as List<PrintedEdiction>;
                List<PrintedEdiction> PrintedEdictionList2 = new List<PrintedEdiction>();
                PrintedEdictionList2 = c2.list as List<PrintedEdiction>;
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if (PrintedEdictionList1[i].PublishYear < PrintedEdictionList2[i].PublishYear)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool operator <(CollectionType<T> c1, CollectionType<T> c2)
        {
            if (c1.list is List<int> && c2.list is List<int>)
            {
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if ((dynamic)c1.list[i] > (dynamic)c2.list[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (c1.list is List<string> && c2.list is List<string>)
            {
                List<string> tempList1 = new List<string>();
                tempList1 = c1.list as List<string>;
                List<string> tempList2 = new List<string>();
                tempList2 = c2.list as List<string>;
                {
                    for (int i = 0; i < c1.list.Count; i++)
                    {
                        if (tempList1[i].Length > tempList2[i].Length)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            if (c1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList1 = new List<PrintedEdiction>();
                PrintedEdictionList1 = c1.list as List<PrintedEdiction>;
                List<PrintedEdiction> PrintedEdictionList2 = new List<PrintedEdiction>();
                PrintedEdictionList2 = c2.list as List<PrintedEdiction>;
                for (int i = 0; i < c1.list.Count; i++)
                {
                    if (PrintedEdictionList1[i].PublishYear > PrintedEdictionList2[i].PublishYear)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool operator true(CollectionType<T> c1)
        {

            if (c1.list is List<int>)
            {
                List<int> intList = new List<int>();
                intList = c1.list as List<int>;
                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList[i] < 0)
                        return false;
                }

            }
            if (c1.list is List<string>)
            {
                List<string> stringList = new List<string>();
                stringList = c1.list as List<string>;
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (stringList[i].Length < 0)
                        return false;
                }
            }

            if (c1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList = new List<PrintedEdiction>();
                PrintedEdictionList = c1.list as List<PrintedEdiction>;
                for (int i = 0; i < PrintedEdictionList.Count; i++)
                {
                    if (PrintedEdictionList[i].PublishYear < 0)
                        return false;
                }
            }
            return true;

        }
        public static bool operator false(CollectionType<T> c1)
        {

            if (c1.list is List<int>)
            {
                List<int> intList = new List<int>();
                intList = c1.list as List<int>;
                for (int i = 0; i < intList.Count; i++)
                {
                    if (intList[i] > 0)
                        return false;
                }

            }
            if (c1.list is List<string>)
            {
                List<string> stringList = new List<string>();
                stringList = c1.list as List<string>;
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (stringList[i].Length > 0)
                        return false;
                }
            }

            if (c1.list is List<PrintedEdiction>)
            {
                List<PrintedEdiction> PrintedEdictionList = new List<PrintedEdiction>();
                PrintedEdictionList = c1.list as List<PrintedEdiction>;
                for (int i = 0; i < PrintedEdictionList.Count; i++)
                {
                    if (PrintedEdictionList[i].PublishYear > 0)
                        return false;
                }
            }
            return true;

        }

        public override int GetHashCode()
        {
            return _count.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            CollectionType<T> collItem = obj as CollectionType<T>;
            //List<T> listItem = obj as List<T>;
            // List<T> listItem = (List<T>)obj;
            //return this.list == collItem.list && this.Count == collItem.Count;

            if (this.list.Count == collItem.list.Count)
                return true;
            else return false;


            //for (int i = 0; i < this.list.Count; i++)
            //{
            //    for (int j = 0; i < collItem.list.Count; j++)
            //    {
            //        if (this.list[i] == collItem.list[j])
            //            continue;
            //        else return false;
            //    }
            //}
            //return true;

        }

        //public void ToFile(CollectionType<T> type)
        //{
        //    int index = type.Count;
        //    string[] text = new string[index];
        //    for (int i = 0; i < index; i++)
        //    {
        //        text[i] = Convert.ToString(type.list[i]);
        //    }
        //    File.WriteAllLines(@"F:\лабы\ООП\labs\oop7\q.txt", text);
        //}
        //public void FromFile()
        //{
        //    Console.WriteLine(File.ReadAllText(@"F:\лабы\ООП\labs\oop7\q.txt"));
        //}
        public static void WriteToFile(CollectionType<T> arr)
        {
            using (StreamWriter file = new StreamWriter(@"F:\лабы\ООП\labs\oop7\q.txt", false))
            {
                
                //file.Write("{");

                for(int i=0; i<arr.list.Count;i++)
                {
                    file.Write($"{arr.list[i]} ");
                }

                //foreach (var i in arr)
                //    file.Write($"{i} ");
                //file.Write("}");
                file.Close();
            }
        }


        public static void LoadFromFile()             // Чтение из файла
        {
            using (FileStream fstream = File.OpenRead(@"F:\лабы\ООП\labs\oop7\q.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }


    }




}
