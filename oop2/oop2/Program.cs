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
    public partial class Student
    {
       

        // удалить
        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Student tom = new Student();    // без параметров
            tom.Print();
        }
    }
}
