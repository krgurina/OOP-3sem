using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab11
{
    //используя делегаты и мобытия реализуйте следующий сценарий взаимодействия объектов: есть объект типа User (пользовательский тип) и два объекта типа Button. Если пользователь нажимает(Click) обе кнопки срабатывают и выводятт текстКнопка 1 нажата
    //Кнопка 2 нажата
    delegate void Message();
    class User
    {
        public event Message Click;

        public void ButtonClick()
        {
            Click?.Invoke();
        }
    }
    class Button
    {
        public Button(User user)
        {
            user.Click += Button1;
            user.Click += Button2;
        }
        private void Button1()
        {
            Console.WriteLine("Кнопка 1 нажата");
        }
        private void Button2()
        {
            Console.WriteLine("Кнопка 2 нажата");
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User user = new User();
    //        Button button = new Button(user);
    //        user.ButtonClick();
    //    }
    //}

}