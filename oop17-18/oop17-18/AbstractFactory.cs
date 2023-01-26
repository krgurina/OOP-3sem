using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
    namespace Абстрактная_Фабрика
    {

        public interface IPizza     
        {
            string Name { get; set; }

            string Dough { get; set; }

            string Sauce { get; set; }

            void Prepare();

            void Bake();

            void Cut();

            void Box();
        }

        public class ItaliaStylePizza : IPizza
        {
            public ItaliaStylePizza()
            {
                Name = "Итальянская пицца с соусом и сыром";
                Dough = "Тесто на тонкой основе";
                Sauce = "Специальный соус";
                Console.WriteLine("Итальянская пицца с сыром");
            }

            public string Name { get; set; }
            public string Dough { get; set; }
            public string Sauce { get; set; }

            public void Bake() => Console.WriteLine("Печем пиццу 25 минут");

            public void Box() => Console.WriteLine("Упаковываем пиццу в коробку");

            public void Cut() => Console.WriteLine("Нарезаем пиццу по диагонали");

            public void Prepare()
            {
                Console.WriteLine("Готовим пиццу");
                Console.WriteLine("Готовим: " + Name);
                Console.WriteLine("Подбрасываем тесто: " + Dough);
                Console.WriteLine("Добавляем соус");
            }
        }
        public class AmericanoStylePizza : IPizza
        {
            public AmericanoStylePizza()
            {
                Name = "Американская пицца с соусом и сыром";
                Dough = "Тесто на тонкой основе";
                Sauce = "Специальный соус";
                Console.WriteLine("Американская пицца с сыром");
            }

            public string Name { get; set; }
            public string Dough { get; set; }
            public string Sauce { get; set; }

            public void Bake() => Console.WriteLine("Печем пиццу 25 минут");

            public void Box() => Console.WriteLine("Упаковываем пиццу в коробку");

            public void Cut() => Console.WriteLine("Нарезаем пиццу по диагонали");

            public void Prepare()
            {
                Console.WriteLine("Готовим пиццу");
                Console.WriteLine("Готовим: " + Name);
                Console.WriteLine("Подбрасываем тесто: " + Dough);
                Console.WriteLine("Добавляем соус");
            }
        }


        interface IPizzaFactory
        {
            IPizza CreateAmericanoStylePizza();
            IPizza CreateItaliaStylePizza();
        }

        class ConcreteFactoryPizza : IPizzaFactory
        {
            public IPizza CreateAmericanoStylePizza()
            {
                return new AmericanoStylePizza();
            }

            public IPizza CreateItaliaStylePizza()
            {
                return new ItaliaStylePizza();
            }
        }


    }
}
