using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    sealed class TextBook : Book
    {
        private int grade;
        public int Grade
        {
            set
            {
                if (value < 1 || value > 11)
                {
                    Console.WriteLine("Класс задан неверно");
                }
                else
                {
                    grade = value;
                }
            }
            get { return grade; }
        }
        public TextBook(string _PublishName, string _title, int _PublishYear, string _Genre, int _Grade)
           : base(_PublishName, _title, _PublishYear, _Genre)
        {
            Grade = _Grade;
        }

        public override string ToString()
        {
            return base.ToString() + "\nКласс: " + grade;
        }
    }
}
