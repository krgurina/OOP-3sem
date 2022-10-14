using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Printer
    {
        public static void IAmPrinting(Object obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
}
