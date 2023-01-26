using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Получатель
    class Bus
    {
        public void Edet()
        {
            Console.WriteLine("Автобус с туристами поехал");
        }

        public void Stand()
        {
            Console.WriteLine("Автобус с туристами остановился");
        }
    }

    class BusEdetCommand : ICommand
    {
        Bus bus;
        public BusEdetCommand(Bus busSet)
        {
            bus = busSet;
        }
        public void Execute()
        {
            bus.Edet();
        }
        public void Undo()
        {
            bus.Stand();
        }
    }

    // Invoker - инициатор
    class Voditel
    {
        ICommand command;

        public Voditel() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressGas()
        {
            command.Execute();
        }
        public void PressStop()
        {
            command.Undo();
        }
    }
}
