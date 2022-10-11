using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Person : PublishingOffice
    {
        private string firstName;
        public string  FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Person(string _PublishName, string _FirstName, string _LastName)
           : base(_PublishName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
        }

        public override string ToString()
        {
            return base.ToString() + "\nИмя: " + firstName + "\nФамилия: " + lastName;
        }
    }
}
