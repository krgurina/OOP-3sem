using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStack
{
    internal class Program
    {

        static void Main(string[] args)
        {


            SuperStack<int> stack1 = new SuperStack<int>();

            stack1.Push(0);
            stack1.Push(1);
            stack1.Push(2);

            //SuperStack<int> stack2 = new SuperStack<int>();
            //bool a = stack1 == stack2;

            //Console.WriteLine(a);


            string[] str = new string[]
            {
    "qwerty","qwert","qwerty","qwertyu","qwertyui"
            };

            var newstr = str.Where(s => s == "qwerty").Count();

            Console.WriteLine(newstr);

            Telephone.Tel tel;
            Telephone telephone = new Telephone();
            User user = new User();



            telephone.Call += user.Pod;

            tel = telephone.Trubka;

            tel();
        }
    }

    public class SuperStack<T> : Stack<T>
    {
        public static bool operator ==(SuperStack<T> stack1, SuperStack<T> stack2)
        {
            if (stack1.Count != 0 && stack2.Count != 0)
            {
                if (stack1.Count == stack2.Count)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                throw new InsufficientExecutionStackException();
            }
        }
        public static bool operator !=(SuperStack<T> stack1, SuperStack<T> stack2)
        {
            if (stack1.Count != 0 && stack2.Count != 0)
            {

                if (stack1.Count != stack2.Count)
                {
                    return false;
                }
                else return true;
            }
            else
            {
                throw new InsufficientExecutionStackException();
            }

        }
    }

    public class Telephone
    {
        public delegate void Tel();
        public event Tel Call;

        public void Trubka()
        {
            Console.WriteLine("Звонит");
            Call();
        }
    }

    public class User
    {
        public void Pod()
        {
            Console.WriteLine("Снял трубку");
        }
    }


}
