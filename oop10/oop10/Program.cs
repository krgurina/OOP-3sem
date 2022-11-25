using System;
using System.Collections.Generic;
using System.Linq;

namespace oop10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] months = {"January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December", };

            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());

            var nLengthhMonths = from t in months
                                  where t.Length == n
                                  select t;

            var SummerWinterMonths = from t in months
                                  where Equals(t, "December") || Equals(t, "January") || Equals(t, "February")
                                        || Equals(t, "June") || Equals(t, "July") || Equals(t, "August")
                                  select t;

            var AlfMonths = from t in months
                                  orderby t // упорядочиваем по возрастанию
                                  select t;

            var uMonths = from t in months
                                  where t.Contains("u")
                                  where t.Length >= 4
                                  select t;

            Console.WriteLine("=====================nLengthhMonths=====================");
            foreach (var item in nLengthhMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================SummerWinterMonths=====================");
            foreach (var item in SummerWinterMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================AlfMonths=====================");
            foreach (var item in AlfMonths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================uMonths=====================");
            foreach (var item in uMonths)
            {
                Console.WriteLine(item);
            }

            //2
            Book book1 = new Book("Война и мир", "Толстой", 1869, 1200, 40);
            Book book2 = new Book("Бородино","Лермонтов", 1977, 120, 30);
            Book book3 = new Book("Мастер и Маргарита","Булгаков", 1987, 452, 20);
            Book book4 = new Book("", "Маяковский", 1995, 180, 150);
            Book book5 = new Book("","Толстой", 1945, 190, 17);
            Book book6 = new Book("", "Есенин", 1998, 900, 19);
            Book book7 = new Book("", "Ахматова", 1988, 160, 14);
            Book book8 = new Book("", "Пришвин", 1936, 500, 11);
            Book book9 = new Book("", "Чехов", 1925, 320, 31);
            Book book10 = new Book("", "Бродский", 1967, 7550, 56);
            
            List<Book> list = new List<Book>();
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);
            list.Add(book5);
            list.Add(book6);
            list.Add(book7);
            list.Add(book8);
            list.Add(book9);
            list.Add(book10);

            //Console.WriteLine("Введите фамилию автора(Например, Толстой: ");
            //string author = Console.ReadLine();
            string author = "Толстой";
            int year = 1869;
            //Console.WriteLine("Введите год(Например, 1869: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            var AuthorBooks = from t in list
                                where t.Author == author
                                where t.PublishYear == year
                                select t;

            var AfretYaerBooks = from t in list
                                 where t.PublishYear > year
                                 select t;

            var ThinBooks = from t in list
                                 orderby t.PageNumber
                                 select t;
            var TheThinestBook = ThinBooks.First();

            var BigChipdBooks = from t in list
                                 orderby t.Price
                                 orderby t.PageNumber
                                 select t;
            var SelectedBooks = BigChipdBooks.TakeLast(5);

            //var PriseList = from t in list
            //                     orderby t.Price
            //                     select t;

            // метод расширения
            var PriseList = list.OrderBy(t => t.Price).Select(t => t);


            Console.WriteLine("=====================AuthorBooks=====================");
            foreach (var item in AuthorBooks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("=====================AfretYaerBooks=====================");
            foreach (var item in AfretYaerBooks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("=====================TheThinestBook=====================");
            Console.WriteLine(TheThinestBook);
            Console.WriteLine();
            Console.WriteLine("=====================SelectedBooks=====================");
            foreach (var item in SelectedBooks)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("=====================PriseList=====================");
            foreach (var item in PriseList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("===================== Мой запрос =====================");

            // мой запрос
            var Selected = list

                                .OrderBy(n => n.PublishYear)
                                .Where(n => n.PageNumber >= 100)
                                .Take(5)
                                .GroupBy(n => n.PageNumber)
                                .Last();

            Console.WriteLine(Selected.Key);
            foreach (var item in Selected)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================== Join =====================");

            List<int> Col1 = new List<int>()
            {
                1,2,3,4,3,6
            };
            List<int> Col2 = new List<int>()
            {
                5,6,3,4,9,6
            };
            var Col3 = Col1.Join(Col2, p => p, t => t, (t, p) => t + p);
            foreach (var item in Col3)
            {
                Console.WriteLine(item);
            }












        }

    }
}
