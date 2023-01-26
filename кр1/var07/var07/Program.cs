using System;
using System.Collections.Generic;

namespace var07
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a
            string str1 = "123456789101112";
            string str2 = str1.Substring(3, 5);
            Console.WriteLine(str2);

            //1б
            List<string> people = new List<string>() { "Tom", "Bob", "Sam" };
            for(int i=0;i<people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }

        }
    }
}
