using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {


            ThisCollectionList<double> fit = new ThisCollectionList<double>();
            double a = 2.3;
            ThisCollectionList<float> fit1 = new ThisCollectionList<float>();
            float b = 2.666f;

            fit.Add(a);
            fit1.Add(b);

            fit.ShowElements();
            fit1.ShowElements();

            Console.WriteLine("-------------------------------");
            string[] arr1 = new string[] { "aaa", "bbb", "ccc" };
            string[] arr2 = new string[] { "xxx", "yyy", "zzz" };
            var itog = arr1.Concat(arr2).Count();
            Console.WriteLine(itog);

            Clown c = new Clown();
            Sobac s = new Sobac();

            c.Try();




        }

    }

}

public class Clown
{
    public string name;
    public delegate void DelMove();
    public event DelMove GAV;
    private Sobac soba;
    public Clown()
    {
        GAV += L;

    }
    public void Try()
    {
        if (GAV != null)
        {
            GAV.Invoke();
            Console.WriteLine("реакция!"); return;
        }

    }


    public void L() => Console.WriteLine("гав");


}
public class Sobac
{



    public Sobac()
    {

    }
}

public class ThisCollectionList<T> : List<T>
{
    public List<T> coll;
    public ThisCollectionList()
    {
        coll = new List<T>();
    }
    public void ShowElements()
    {
        Console.WriteLine($"В моей коллекции");
        foreach (var T in coll)
        {
            Console.WriteLine(T);
        }
    }

    public void Add(T c)
    {

        coll.Add(c);

        coll.Add(c);

    }


    public void Find(T c)
    {

    }

    //public void RemoveElements(int firstIdx, int secondIdx) 
    //{ 

    //    for (int i = firstIdx; i <= secondIdx && i < Count; i++) 
    //    { 
    //        Remove(i); 
    //    } 

    //} 
}