using System;
using System.Runtime.InteropServices.ComTypes;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace oop13
{
    [Serializable]
    public abstract class PrintedEdiction
    {
        public string name;
        public int publishYear;
        [NonSerialized]
        public string author;
        public PrintedEdiction(string name, int publishYear, string author)
        {
            this.name = name;
            this.publishYear = publishYear;
            this.author = author;

        }
        public PrintedEdiction() { }

        public override string ToString() => GetType().Name;
        public override bool Equals(object obj) => GetType().Name == obj.ToString();

    }

    [Serializable]
    public class Book : PrintedEdiction
    {
        public Book(string name, int publishYear, string author) : base(name, publishYear, author)
        {
            this.name = name;
            this.publishYear = publishYear;
            this.author = author;
        }
        public Book() { }

    }
}




