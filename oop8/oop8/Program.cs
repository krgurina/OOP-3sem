using System;

namespace oop8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Game ==========");

            Game user1 = new Game("Steve", 300);
            Game zombie = new Game("Зомби", 150);
            Game pig = new Game("Хрюня", 100);

            user1.Attack += User1_Attack;
            zombie.Attack += Zombie_Attack;
            zombie.ToAtt(pig);
            user1.ToAtt(zombie);
            user1.ToAtt(zombie);
            user1.ToAtt(zombie);
            user1.Treat += User1_Treat;
            user1.ToTreat(pig);








        }

        //обработка события
        private static void User1_Treat(Game obj)
        {
            Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");

            
            
        }

        private static void Zombie_Attack(Game obj)
        {
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
            if (obj.hp <= 0)
            {
                Console.WriteLine($"{obj.name} убит!");
            }
            else
            {
                Console.WriteLine($"{obj.name}\t[XP:{obj.hp}/{obj.fullHP}]");
            }
            //throw new NotImplementedException();
        }
    }
}
