using System;
using System.Collections.Generic;
using System.Text;

namespace oop11
{
    abstract class Actions
    {
        public abstract void Work();

        public virtual void Virtual()
        {
            Console.WriteLine("Работает виртуалный метод");
        }

        public abstract void DoClone();

    }
}
