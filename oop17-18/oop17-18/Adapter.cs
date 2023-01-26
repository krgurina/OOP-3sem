using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
        interface ITransport
    {
        void Drive();
    }
    // класс машины
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Вы едите на машине");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    // интерфейс животного
    interface IAnimal
    {
        void Move();
    }
    // класс верблюда
    class Shark : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Акула плывёт под водой");
        }
    }
    // Адаптер от Shark к ITransport
    class SharkToTransportAdapter : ITransport
    {
        Shark shark;
        public SharkToTransportAdapter(Shark c)
        {
            shark = c;
        }
 
        public void Drive()
        {
             Console.WriteLine("Вы реально плывёте на акуле??");
        }
    }
}
