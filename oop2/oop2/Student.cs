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


            dateOfBirth = "Неизвестно";
            address = "Неизвестно";
            phoneNumber = 0;
            faculty = "Неизвестно";
            course = 0;
            group = 0;
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
        public Student(string aSurname, string aName, string aFathername, string aDateOfBirth, string aAddress, ulong aPhoneNumber, string aFaculty = "ФИТ", int aCourse = 2, int aGroup = 4)
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
        private Student(string aSurname, string aName, string aFathername)
        {
            surname = aSurname;
            name = aName;
            fathername = aFathername;
            numberOfStudents++;
            id = this.GetHashCode();
        }


        // cтатический конструктор 
        static Student()
        {
            Console.WriteLine($" Количество студентов: {numberOfStudents} ");
        }


        // метод расчет возраста 
        public void getAge(string dateOfBirth)
        {
            var date = DateTime.ParseExact(dateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var age = DateTime.Now.Year - date.Year;

            if (DateTime.Now.Month < date.Month ||
               (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) age--;
            Console.WriteLine($"Возраст: {age} ");

        }


        // статический метод для вывода информации
        public static void PrintInfo(Student student)
        {
            Console.WriteLine();
            Console.WriteLine("Фамилия: " + student.Surname + "\nИмя: " + student.Name + "\nОтчество: " + student.Fathername);
            Console.WriteLine("Год рождения: " + student.DateOfBirth + "\nАдрес: " + student.Address + "\nТелефон: " + student.PhoneNumber);
            Console.WriteLine("Факультет: " + student.Faculty + "\nКурс: " + student.Course + "\nГруппа: " + student.Group);
            Console.WriteLine("Униальный номер (ID)" + student.id);
        }

        //ref-параметры
        public void GetSurname(ref string sname)
        {
            Console.WriteLine($"Фамилия: {sname}");
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
            return Surname.GetHashCode()+ PhoneNumber.GetHashCode();
        }


        public override string ToString()
        {
            return $"{Surname} {Name} {Fathername}";
        }






    }
}
