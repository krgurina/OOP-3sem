
using oop17_18.Абстрактная_Фабрика;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static oop17_18.Client;

namespace oop17_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::::::::::::::::::Abstract Factory::::::::::::::::::::::::");
            IPizzaFactory factory = new ConcreteFactoryPizza();

            IPizza pizzaAmericano = factory.CreateAmericanoStylePizza();
            pizzaAmericano.Prepare();

            Console.WriteLine(new string('-', 50));

            IPizza pizzaItalio = factory.CreateItaliaStylePizza();
            pizzaItalio.Prepare();


            Console.WriteLine(":::::::::::::::::::::Турагентство::::::::::::::::::::::::");

            Tour c1 = new Tour("Экскурсия", 120);
            Tour c2 = new Tour("Шоппинг", 600);
            Tour c3 = new Tour("Отдых", 450);

            List<Tour> kur = new List<Tour>()
            {
                c1,
                c2,
                c3
            };

            //  Singleton
            //Client test = Client.getInstance("Женя"); 
            Client Kristina = Client.getInstance("Kristina");

            var cur = Kristina.ToTour(kur);

            TourAgent kukusik = new TourAgent();
            kukusik.TC(cur);

            kukusik.GetSale(Kristina, cur);
            kukusik.Pay(cur);




            /// Prototype
            Console.WriteLine(":::::::::::::::::::::Prototype::::::::::::::::::::::::");
            IPrototype TourOld = new Tour();
            TourOld.GetTypeTour("xixixixi");

            IPrototype TourNew = TourOld.Clone();

            Console.WriteLine(TourOld.TypeTour());
            Console.WriteLine(TourNew.TypeTour());

            Console.WriteLine(":::::::::::::::::::::Builder::::::::::::::::::::::::");

            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct("Счастливого путешествия! :)", 3, "В Казахстан");
            Tour product = builder.GetResult();

            Console.WriteLine("::::::::::::::::::::: Adapter :::::::::::::::::::::");
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Shark shark = new Shark();
                shark.Move();
            // используем адаптер
            ITransport sharkTransport = new SharkToTransportAdapter(shark);
            driver.Travel(sharkTransport);

            Console.WriteLine("::::::::::::::::::::: Decorator ::::::::::::::::::::::::");

            Collegue colegue = new University();
            colegue = new Magistr(colegue);
            Console.WriteLine("Образования: {0}", colegue.Education);
            Console.WriteLine("Возраст: {0}", colegue.GetAge());

            Console.WriteLine("::::::::::::::::::::: Facade ::::::::::::::::::::::::");

            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.WriteLine("::::::::::::::::::::: Strategy ::::::::::::::::::::::::");

            Client student1 = new Client("Анатолий", new TourHunting());
            student1.Move();
            student1.Movable = new GoodTour();
            student1.Move();

            Console.WriteLine("::::::::::::::::::::: State ::::::::::::::::::::::::");

            Client clietn1 = new Client(States.REGISTRATION);
            clietn1.Name = "Васек";
            clietn1.Go();
            clietn1.Go();
            clietn1.Stop();

            Console.WriteLine("::::::::::::::::::::: Command ::::::::::::::::::::::::");

            Voditel pult = new Voditel();
            Bus bus = new Bus();
            pult.SetCommand(new BusEdetCommand(bus));
            pult.PressGas();
            pult.PressStop();
        }
    }
}
