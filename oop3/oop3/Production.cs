using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public class Production
    {
        public readonly int id;
        public readonly string organization;

        public Production(int id, string organization)
        {
            this.id = id;
            this.organization = organization;
        }

        public void PrintProduction(Production owner)
        {
            Console.WriteLine($"Организация:{owner.organization} ");
        }
    }
}
