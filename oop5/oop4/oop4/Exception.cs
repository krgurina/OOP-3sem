using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    public class NullObject : Exception
    {
        private string message;
        public NullObject()
        {
            message = "Null-объект";
        }
        public void PrintInfo()
        {
            Console.WriteLine("Сообщение: " + message + ", метод, где возникло исключение: " + TargetSite + "\n");
        }
    }

     public class WrongDate : Exception
        {
            private string message;
            public WrongDate(string message)
            {
                this.message = message;
            }
            public void PrintInfo()
            {
                Console.WriteLine("Сообщение: " + message + ", метод, где возникло исключение: " + TargetSite+ "\n");
            }
        }

    public class WrongCost : Exception
    {
        private string message;
        public WrongCost(string message)
        {
            this.message = message;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Сообщение: " + message + ", место, где возникло исключение: " + StackTrace + "\n");
        }
    }
}
