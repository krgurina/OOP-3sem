using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Author : Person, IPrinter
    {
        private string pseudonym;
        public string Pseudonym
        {
            get { return pseudonym; }
            set { pseudonym = value; }
        }
        public Author(string _PublishName, string _FirstName, string _LastName, string _Pseudonym)
           : base(_PublishName, _FirstName, _LastName)
        {
            Pseudonym = _Pseudonym;
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());

        }
        public override string ToString()
        {
            return base.ToString() + "\nПсевдоним: " + pseudonym;
        }
    }
}
