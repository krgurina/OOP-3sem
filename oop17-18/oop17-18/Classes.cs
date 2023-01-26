using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop17_18
{
    // Strategy 
    interface IMovable //интерфейс, общий для всех вариаций алгоритма
    {
        void Move();
    }
    class TourHunting : IMovable    //Конкретные стратегии
    {
        public void Move() => Console.WriteLine("Я ищу где бы отдохнуть ");
    }

    class GoodTour : IMovable
    {
        public void Move() => Console.WriteLine("Я нашел отличный тур. Я лечу в Австралию");
    }
    class Client : WrapperOverIMovementTour, IMovable
    {
        //Контекст 
        public IMovable Movable { private get; set; }

        public Client(string Name, IMovable Movable)
        {
            Console.WriteLine("Клиент взял отпуск и ищет тур");
            this.Movable = Movable;
            this.Name = Name;
        }
        public void Move() => Movable.Move();




        //Singleton
        private static Client instance; //Поле для хранения объекта-одиночки
        public string Name { get; set; }

        List<Tour> Tours = new List<Tour>();
        private Client(string Name) => this.Name = Name;
        public static Client getInstance(string name)   // возвращает единственный экземпляр своего класса
        {
            if (instance == null)
                instance = new Client(name);
            return instance;
        }





        // State
        public enum States   
        {
            REGISTRATION,
            CHOSEE,
            FINISH
        }
        public States State { get; set; }
        public Client(States ws) => State = ws;


        public void Go()
        {
            if (State == States.REGISTRATION)
            {
                Console.WriteLine($"Клиент {this.Name} зарегистрировался");
                State = States.CHOSEE;
            }
            else if (State == States.CHOSEE)
            {
                Console.WriteLine($"Клиеент {this.Name} выбирает тур");
                State = States.FINISH;
            }
            else if (State == States.FINISH)
            {
                Console.WriteLine($"Клиент {this.Name} оплачивает тур");
            }
        }
        public void Stop()
        {
            if (State == States.CHOSEE)
            {
                Console.WriteLine($"Клиент {this.Name} закончил оформление тура");
                State = States.REGISTRATION;
            }
            else if (State == States.FINISH)
            {
                Console.WriteLine($"Клиент {this.Name} выходит из системы");
                State = States.CHOSEE;
            }
        }
    }


    internal class TourAgent
    {
        public void TC(Tour c)
        {
            c.tourstatus = "Горящий";
            Console.WriteLine("Турагент изменил статус тура на: " + c.tourstatus);
        }
        public void Pay(Tour c)
        {
            Console.WriteLine(":::::::::::::::::::::Оплата тура::::::::::::::::::::::::");
            Console.WriteLine("Стоимость тура " + c.tourtype + " равна " + c.price);
            Console.WriteLine("Вы успешно оплатили тур!");
        }
        public int GetSale(Client s, Tour c)
        {
            Console.WriteLine(":::::::::::::::::::::Система скидок постоянным клиентам::::::::::::::::::::::::");
            string[] constClient = { "Kristina", "Kot" };
            for (int i = 0; i < constClient.Length; i++)
            {
                if (s.Name == constClient[i])
                {
                    Console.WriteLine($"{s.Name} является постоянным клиентом!");
                    Console.WriteLine("Скидка для постоянных клиентов 50%!");
                    c.price = c.price / 2;
                    return c.price;
                }
                else
                {
                    Console.WriteLine($"{s.Name} не является постоянным клиентом!");
                    return c.price;
                }
            }
            return c.price;
        }

    }






    internal interface IMovementClient
    {
        Tour ToTour(List<Tour> list);
    }

    class WrapperOverIMovementTour : IMovementClient
    {
        public Tour ToTour(List<Tour> list)
        {
            Console.WriteLine("Список туров: ");
            foreach (Tour item in list)
            {
                Console.WriteLine(item.tourtype + " " + item.price);
            }
            Console.WriteLine("Введите название выбранного тура и его стоимость: ");
            string name = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            Tour nkur = new Tour(name, price);
            Console.WriteLine($"Клиент выбрал тур " + nkur.tourtype);

            return nkur;
        }
    }
}
