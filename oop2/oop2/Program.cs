using System;

/*Создать класс Student: id, Фамилия, Имя, Отчество, 
Дата рождения, Адрес, Телефон, Факультет, Курс, 
Группа. Свойства и конструкторы должны обеспечивать 
проверку корректности. Добавить метод расчет возраста 
студента

 Создать массив объектов. Вывести:
a) список студентов заданного факультета;
d) список учебной группы*/
namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // статический конструктор
            // 2 задание
            Student student1 = new Student();
            Console.WriteLine("\n  Объект, созданный конструктором по умолчанию:");
            Student.PrintInfo(student1);

            Student student2 = new Student("Иванов", "Иван", "Иванович", 277923777, "ХТИТ");
            Console.WriteLine("\n  Объект, созданный вторым конструктором:");
            Student.PrintInfo(student2);

            Student student3 = new Student("Авдеева", "Вера", "Дмитриевна", "23.09.2003", "Белорусская 21", 297923877, "ФИТ", 4, 6);
            Console.WriteLine("\n  Объект, созданный третьим конструктором:");
            Student.PrintInfo(student3);
            student3.getAge(student3.DateOfBirth);

            Student student4 = new Student("Гурина", "Кристина", "Сергеевна", "28.09.2003", "Белорусская 21", 297923877);
            Console.WriteLine("\n  Объект, созданный конструктором с параметрами по умолчанию:");
            Student.PrintInfo(student4);
            student4.getAge(student4.DateOfBirth);

            Student student5 = new Student("Гурина", "Кристина", "Сергеевна", "28.09.2003", "Белорусская 21", 297923877);
            Console.WriteLine("\n  Объект, созданный конструктором с параметрами по умолчанию:");
            Student.PrintInfo(student5);

            Student student6 = new Student("Ковалёва", "Анна", "Юрьевна", "14.04.2004", "Белорусская 21", 297927777);
            Console.WriteLine("\n  Объект, созданный конструктором с параметрами по умолчанию:");
            Student.PrintInfo(student6);


            //  ref - и out-параметры
            string sname = student3.Surname;
            Console.WriteLine("\nref-параметры: ");
            student3.GetSurname(ref sname);

            string university;
            student3.GetUniversity(out university);
            Console.WriteLine($"\nout-параметры: {university}");


            Console.WriteLine($"\nСравнение двух объектов: {student3.Equals(student4)}");
            Console.WriteLine($"Сравнение двух объектов: {student5.Equals(student4)}");
            Console.WriteLine($"\nТип 1 студента - {student1.GetType()}");
            Console.WriteLine($"\nToStrin для 2 студента - {student2.ToString()}");

            // 3 задание 
            Student[] StudentArr = new Student[6];
            StudentArr[0] = student1;
            StudentArr[1] = student2;
            StudentArr[2] = student3;
            StudentArr[3] = student4;
            StudentArr[4] = student5;
            StudentArr[5] = student6;

            Console.WriteLine();
            for (int i = 0; i < StudentArr.Length; i++)
            {
                Console.WriteLine(StudentArr[i]);
            }

            // метод для вызова поиска по факультету
            FindStudentsOfFaculty(StudentArr);
            // метод для вызова поиска по группе
            FindStudentsOfGroup(StudentArr);

            // статический метод для количества студентов
            Student.PrintNumberOfStudent();

            // анонимный тип
            var user = new { Name = "Евгения", Surname = "Коктыш" };
            Console.WriteLine($"Имя: {user.Name}\nФамилия: {user.Surname}\n");

            // поиск студента заданного факультета 
            static void FindStudentsOfFaculty(Student[] StudentArr)
            {
                Console.WriteLine("Введите название факультета(например ФИТ)");
                string findFaculty = Console.ReadLine();
                bool isOrNot = false;
                for (int i = 0; i < StudentArr.Length; i++)
                {
                    if (findFaculty == StudentArr[i].Faculty)
                    {
                        Console.WriteLine(StudentArr[i]);
                        isOrNot = true;
                    }
                }

                if (!isOrNot)
                {
                    Console.WriteLine("Нет студентов заданного факультета");
                }
            }

            // поиск студента заданной группы
            static void FindStudentsOfGroup(Student[] StudentArr)
            {
                Console.WriteLine("Введите номер учебной группы");
                int findGroup = Convert.ToInt32(Console.ReadLine());

                if (findGroup < 1 || findGroup > 10)
                {
                    Console.WriteLine("Неверный номер группы, попробуйте ещё раз");
                    FindStudentsOfGroup(StudentArr);
                }

                bool isOrNot = false;
                for (int i = 0; i < StudentArr.Length; i++)
                {
                    if (findGroup == StudentArr[i].Group)
                    {
                        Console.WriteLine(StudentArr[i]);
                        isOrNot = true;
                    }
                }

                if (!isOrNot)
                {
                    Console.WriteLine("Нет студентов заданной группы");
                }
            }


        }
    }
}
