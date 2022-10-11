using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class PublishingOffice
    {
        private string publishName;
        public string PublishName
        {
            get { return publishName; }
            set { publishName = value; }
        }

        public PublishingOffice(string _PublishName)
        {
            PublishName = _PublishName;
        }

        public override string ToString()
        {
            return "Издательство: " + PublishName;
        }

    }
}
