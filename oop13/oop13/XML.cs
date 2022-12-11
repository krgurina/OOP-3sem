using System;
using System.Xml;
using System.Linq;
using System.Text.RegularExpressions;
namespace oop13
{
    public static class XMLSelector
    {
        public static void SelectByName(string name, string path)
        {
            if (path.Split('.').Last() != "xml")
                throw new Exception("Документ не найден");
            Console.WriteLine("Выбор по имени");
            Regex regex = new Regex($@"<name>(?<N>[\s\w]+)\</name><publishYear>(?<year>\d+)</publishYear><author>(?<author>\d+)</author>");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlElement xRoot = xmlDocument.DocumentElement;
            XmlNodeList xmlNode = xRoot?.SelectNodes("*");
            foreach (XmlNode node in xmlNode)
            {
                if (regex.Match(node.InnerXml).Groups["N"].Value == name)
                    Console.WriteLine($"{regex.Match(node.InnerXml).Groups["N"].Value},{regex.Match(node.InnerXml).Groups["year"].Value},{regex.Match(node.InnerXml).Groups["author"].Value}");
            }
        }
        public static void SelectByBook(string bookName, string path)
        {
            if (path.Split('.').Last() != "xml")
                throw new Exception("Документ не найден");
            Console.WriteLine("Выбор по типу печатного издания");
            Regex regex = new Regex($@"<{bookName}><name>(?<N>[\s\w]+)\</name><publishYear>(?<year>\d+)</publishYear><author>(?<author>\d+)</author></{bookName}>");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlElement xRoot = xmlDocument.DocumentElement;
            XmlNodeList xmlNode = xRoot?.SelectNodes("*");
            foreach (XmlNode node in xmlNode)
            {
                if (regex.IsMatch(node.OuterXml))
                    Console.WriteLine($"{regex.Match(node.OuterXml).Groups["N"].Value},{regex.Match(node.OuterXml).Groups["year"].Value},{regex.Match(node.OuterXml).Groups["author"].Value}");
            }


        }

    }
}