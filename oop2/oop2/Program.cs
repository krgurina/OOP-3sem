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
            // 2 задание
            Student student1 = new Student();    
            Console.WriteLine("\n  Объект, созданный конструктором по умолчанию:");
            Student.PrintInfo(student1);

            Student student2 = new Student("Иванов","Иван","Иванович", 277923777, "ФИТ");    
            Console.WriteLine("\n  Объект, созданный вторым конструктором:");
            Student.PrintInfo(student2);

            Student student3 = new Student("Авдеева", "Вера", "Дмитриевна", "23.09.2003", "Белорусская 21",297923877, "ФИТ", 4, 6);   
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

            // вызов закрытого класса
            //Student student5 = new Student("Иванов", "Иван", "Иванович");    // без параметров
            //Console.WriteLine("\n  Объект, созданный вторым конструктором:");
            //student2.PrintInfo();



            string sname = student3.Surname;
            Console.WriteLine("\nref-параметры: ");
            student3.GetSurname(ref sname);

            // переменная статического конструктора
            Console.WriteLine(Student.numberOfStudents);

      

            Console.WriteLine($"\nСравнение двух объектов: {student3.Equals(student4)}");
            Console.WriteLine($"Сравнение двух объектов: {student5.Equals(student4)}");

            Console.WriteLine($"\nТип 1 студента - {student1.GetType()}");

            Console.WriteLine($"\nToStrin для 2 студента - {student2.ToString()}");





        }
    }
}
