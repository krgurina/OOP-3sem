using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace oop2
{
    public partial class Student
    {
        private readonly int id;

        private string surname;
        public string Surname 
        {
            get { return surname; }
            set { surname = value; }
        }
       

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string fathername;
        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }
        

        private string dateOfBirth;
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        private ulong phoneNumber;
        public ulong PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        private string faculty;
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }


        private int course;
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    Console.WriteLine("Ошибка! Неверный номер курса.");
                }

                else course = value;
            }
        }


        private int group;
        public int Group        // ограничение по set
        {
            get
            {
                return group;
            }
            protected set
            {
                if (value < 1 || value > 10)
                {
                    Console.WriteLine("Ошибка! Неверный номер группы.");
                }

                else group = value;
            }
        }


        public static short numberOfStudents = 0;

        // поле-констанста 
        public const string city = "Minsk";


        //конструкторы 
        public Student()    //без параметров
        { 
            surname = "Неизвестно";
            name = "Неизвестно";
            fathername = "Неизвестно";
            address = "Неизвестно"; 
            faculty = "Неизвестно";
            numberOfStudents++;
            id = this.GetHashCode();
        }

        // неполный конструктор 
        public Student(string aSurname, string aName, string aFathername, ulong aPhoneNumber, string aFaculty)
        {
            surname = aSurname;
            name = aName;
            fathername = aFathername;
            phoneNumber = aPhoneNumber;
            faculty = aFaculty;
            numberOfStudents++;
            id = this.GetHashCode();
        }

        // полный конструктор с параметрами по умолчанию 
        public Student(string aSurname, string aName, string aFathername, string aDateOfBirth, string aAddress, ulong aPhoneNumber, string aFaculty = "FIT", int aCourse = 2, int aGroup = 4)
        {
            surname = aSurname;
            name = aName;
            fathername = aFathername;
            dateOfBirth = aDateOfBirth;
            address = aAddress; 
            phoneNumber = aPhoneNumber;
            faculty = aFaculty;
            course = aCourse;
            group = aGroup;
            numberOfStudents++;
            id = this.GetHashCode();
        }

        // закрытый конструктор
        private Student(string aSurname, string aName, string aFathername, ulong aPhoneNumber)
        {
            surname = aSurname;
            name = aName;
            fathername = aFathername;
            phoneNumber = aPhoneNumber;
            numberOfStudents++;
            id = this.GetHashCode();
        }

        // cтатический конструктор 
        static Student()
        {
            Console.WriteLine($" Количество студентов: {numberOfStudents} ");
        }


        // метод расчет возраста 
        public int getAge(string dateOfBirth)
        {
            var date = DateTime.ParseExact(dateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var age = DateTime.Now.Year - date.Year;

            if (DateTime.Now.Month < date.Month ||
               (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) age--;
            return age;
        }


        // метод для вывода инфы
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Фамилия: " + Surname + "\nИмя: " + Name + "\nОтчество: " + Fathername);
            Console.WriteLine("Год рождения: " + DateOfBirth + "\nАдрес: " + Address + "\nТелефон: " + PhoneNumber);
            Console.WriteLine("Факультет: " + Faculty + "\nКурс: " + Course + "\nГруппа: " + Group);
            Console.WriteLine("Униальный номер (ID)" + id);
        }

        // использование ref-параметра
        public static void AllStudents(ref int all)
        {
            Console.WriteLine($"Всего студентов: {all}");
        }


        // переопределение методов класса Object
        public override bool Equals(object obj)  
        {
            if (obj == null)
                return false;
            Student stud = obj as Student;
            if (stud == null)
                return false;
            return this.Surname == stud.Surname && this.Name == stud.Name && this.Fathername == stud.Fathername
                && this.DateOfBirth == stud.DateOfBirth && this.Address == stud.Address && this.PhoneNumber == stud.PhoneNumber
                && this.Faculty == stud.Faculty && this.Course == stud.Course && this.Group == stud.Group;
        }

        public override int GetHashCode()          
        {
            return PhoneNumber.GetHashCode();
        }


        public override string ToString()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Fathername} ";
        }






    }
}
