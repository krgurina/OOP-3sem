using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public class Owner
    {
        public int id;
        public string name;
        public string organization;

        public Owner(int id, string name, string organization)
        {
            this.id = id;
            this.name = name;
            this.organization = organization;
        }
    }
}
