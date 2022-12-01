﻿using System;
using System.Reflection;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace oop11
{
    public static class Reflector
    {

        // Имя сборки, в которой определен класс
        public static Assembly AssName(object obj)
        {
            Type type = obj.GetType();     /// это прописываем всегда, чтобы работать с рефлексией и System.Type
            Assembly ass = Assembly.GetAssembly(type);
            Console.WriteLine("Класс " + type.FullName + " определен в сборке " + ass.FullName);
            return ass;
        }

        // Есть ли публичные конструкторы
        public static ConstructorInfo PublicConstruct(object obj)
        {
            Type type = obj.GetType();
            ConstructorInfo[] constrArray = type.GetConstructors();
            foreach (ConstructorInfo constructor in constrArray)
            {
                if (constrArray.Length > 0)
                {
                    Console.WriteLine("\nКонструктор: " + constructor);
                    return constructor;
                }
                else
                    Console.WriteLine("В данном классе публичных конструкторов нет.");
            }
            return constrArray[0];   
        }

        // Возвращает публичные методы класса
        public static MethodInfo[] Methods(object obj)
        {
            Type type = obj.GetType();
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("\nМетоды класса:");
            foreach (MethodInfo method in methods)
            {
                if (!methods.Equals(null))
                    Console.WriteLine("--> " + method.ReturnType.Name + " \t" + method.Name + "()");
            }
            return methods;
        }

        // Получает поля и свойства
        public static PropertyInfo[] Fields(object obj)
        {
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields();
            Console.WriteLine("\nПоля и свойства класса:");
            foreach (FieldInfo field in fields)
            {
                if (!field.Equals(null))
                    Console.WriteLine("Поле " + field.Name);
                else
                    Console.WriteLine("Поля отсутсвтуют.");
            }
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!properties.Equals(null))
                    Console.WriteLine(property.PropertyType + "\t" + property.Name);
                else
                    Console.WriteLine("Свойства отсутствуют.");
            }
            return properties;
        }

        // Получить интерфейсы
        public static Type[] Interfaces(object obj)
        {
            Type type = obj.GetType();
            Type[] interfaces = type.GetInterfaces();
            Console.WriteLine("\nИнтерфейсы:");
            foreach (Type inter in interfaces)
                Console.WriteLine(inter.Name);
            return interfaces;
        }

        // Получить методы с задаваемым возвращаемым параметром в задаваемом классе
        public static dynamic GetSomeMethods(object obj, Type param) ///тип возвращаемого значения dynamic для возвращения var
        {
            Type type = obj.GetType();
            var methods = type.GetMethods();
            var result = methods.Where(a => a.GetParameters().Where(t => t.ParameterType == param).Count() != 0);
            // здесь с помощью лямбда-выражения выбираем из массива всех методов methods только 
            // те методы, у котороых значение Parameters совпадает с нашим передаваемым в качестве
            // аргумента Type param [т.е. кол-во методов с типом параметра param не равно 0]
            Console.WriteLine($"\nМетоды с параметром {param}:");
            foreach (var resMethod in result)
                Console.WriteLine(resMethod.Name);
            return result;
        }

        // Всё то же самое, что и выше, но записываем в файл, а не в консось
        public static void ToFile(object obj, Type param)
        {
            Type type = obj.GetType();
            string filePath = @"F:\лабы\ООП\labs\oop11\oop11\out.txt";
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.Default))
            {
                /// имя сборки
                sw.WriteLine("Класс " + type.FullName + " определен в сборке " + AssName(obj).FullName);
                /// контрукторы
                sw.WriteLine("\nКонструкторы: " + PublicConstruct(obj));
                /// методы
                sw.WriteLine("\nМетоды: ");
                foreach (MethodInfo method in Methods(obj))
                    sw.WriteLine("--> " + method.ReturnType.Name + "\t\t" + method.Name + "()");
                /// свойства
                sw.WriteLine("\nСвойства:");
                foreach (PropertyInfo property in Fields(obj))
                    sw.WriteLine(property.PropertyType + "\t" + property.Name);
                /// интерфейсы
                sw.WriteLine("\nИнтерфейсы:");
                foreach (Type inter in Interfaces(obj))
                    sw.WriteLine(inter.Name);
                /// определенные методы
                sw.WriteLine($"\nМетоды с параметром {param}:");
                foreach (var res in GetSomeMethods(obj, param))
                    sw.WriteLine(res.Name);
                /// задание 2: записать в файл инфу о параметрах для метода InvokeClass()
                sw.WriteLine("\n\nTask 2:");
                sw.WriteLine("parameters"); /// эта строчка дает функции понять, откуда начинаются параметры
                sw.WriteLine("Supra 680");  /// отсюда можно начинать писать через пробел все параметры
            }
        }





    }
}
