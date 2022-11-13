using System;

namespace oop8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Game =============");

            Game user1 = new Game("Steve", 300);
            Game zombie = new Game("Зомби", 150);
            Game pig = new Game("Хрюня", 100);

            pig.Attack += Pig_Attack;
            user1.Attack += User1_Attack;
            zombie.Attack += Zombie_Attack;
            pig.ToAtt(zombie);
            pig.ToAtt(zombie);
            zombie.ToAtt(pig);
            user1.ToAtt(zombie);
            user1.ToAtt(zombie);
            user1.ToAtt(zombie);
            user1.Treat += User1_Treat;
            user1.ToTreat(pig);

            Console.WriteLine(); 
            Console.WriteLine();

            Console.WriteLine("============= Работа со строками =============");
            Console.WriteLine();

            Func<string, string> A;

            string str = "УРрр, урурур; кусь-кусь-кусь: мяу?! ";
            Console.WriteLine($"Исходная строка:\t{str}");
            Console.WriteLine();

            A = StringEditor.AddSymbol;
            Console.WriteLine($"С добавлением символа:\t{str = A(str)}");

            A = StringEditor.ToUpper;
            Console.WriteLine($"Верхний регистр:\t{str = A(str)}");

            A = StringEditor.ToLower;
            Console.WriteLine($"Нижний регистр:\t\t{str = A(str)}");

            A = StringEditor.RemoveSpase;
            Console.WriteLine($"Без пробелов:\t\t{str = A(str)}");

            A = StringEditor.RemoveS;
            Console.WriteLine($"Без знаков препинания:\t{str = A(str)}");
            Console.WriteLine();

            Predicate<int> isLong = (int x) => x > 20;
            Console.WriteLine("Строка длиннее 20 символов: " + isLong(str.Length));
        }

        //обработка события
        private static void Pig_Attack(Game obj)
        {
            Console.WriteLine("Атаки Хнюни безвредны((");
            Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");

        }

        private static void User1_Treat(Game obj)
        {
            Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");
        }

        private static void Zombie_Attack(Game obj)
        {
            obj.hp -= 20;
            Console.WriteLine($"{obj.name} заражён, {obj.name} может стать зомби!");
            if (obj.hp <= 0)
            {
                Console.WriteLine($"{obj.name} убит!");
            }
            else
            {
                Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");
            }
        }

        private static void User1_Attack(Game obj)
        {
            obj.hp -= 50;
            if (obj.hp <= 0)
            {
                Console.WriteLine($"{obj.name} убит!");
            }
            else
            {
                Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");
            }
        }
    }
}
