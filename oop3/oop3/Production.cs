using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public class Production
    {
        private int id;
        public string organization;
        public Production(string organization)
        {
            id = 666;
            this.organization = organization;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Production – ID: {id}, Организация: {organization}.");
        }
    }
}
