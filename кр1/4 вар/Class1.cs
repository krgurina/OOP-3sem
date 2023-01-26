using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Main()
        {
            //а
            string str1 = "ABCDEFG";
            string str2 = "CDE";
            Console.WriteLine(str1.IndexOf(str2));
            Console.WriteLine(str1.IndexOf("HIJK"));
            //б
            string[] strmass = {"abc", "def", "ghi", "jkl"};
            int i = 0;
            string buff;
            while (i < strmass.Length / 2)
            {
                buff = strmass[i];
                strmass[i] = strmass[strmass.Length - 1 - i];
                strmass[strmass.Length - 1 - i] = buff;
                i++;
            }

            for (int j = 0; j < strmass.Length; j++)
                Console.WriteLine(strmass[j]);
        }
    }
}
