using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Imove
    {
        public void Move();
    }
    public abstract class Transport
    {
        public void Move()
        {
            Console.WriteLine("Едем");
        }
    }
    public class Car : Transport, Imove
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }
        public void Move(int i)
        {
            base.Move();
        }
    }
    internal class Class1
    {
        public static void Main()
        {
            Car car = new Car();
            car.Move();
            car.Move(1);
        }
    }
}