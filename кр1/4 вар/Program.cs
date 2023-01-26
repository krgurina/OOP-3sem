using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Day
    {
        public string[] StrMass = { "Пн", "ВТ", "Ср", "Чт", "Пт", "Сб", "Вс" };

        public Day(int i)
        {
            if (i >= 7)
                throw new Exception("Выход за пределы дней");

            Console.WriteLine(StrMass[i]);
        }
        public Day()
        {
            
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < 6; i++)
                str += StrMass[i] + " ";
            return str;
        } 
    }
    internal class Class1
    {
        public static void Main()
        {
            Day day = new Day();
            Console.WriteLine(day.ToString());
            Day day2 = new Day(2);
            try
            {
                Day day3 = new Day(7);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}