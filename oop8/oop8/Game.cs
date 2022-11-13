using System;
using System.Collections.Generic;
using System.Text;

namespace oop8
{
    class Game
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int fullHP { get; set; }

        public Game(string Name, int Health)
        {
            name = Name;
            hp = Health;
            fullHP = Health;
        }

        public delegate void Actions(Game obj);
        public event Actions? Attack;
        public event Actions? Treat;

        //метод, инициирующий событие
        public void ToAtt(Game obj)   
        {
            Console.WriteLine();
            //obj.hp -= 50;
            Console.WriteLine(this.name + " атаковал "+ obj.name);
            Attack?.Invoke(obj);//вызов события, если не null

        }
        public void ToTreat(Game obj)
        {
            Console.WriteLine();
            if (obj.hp < obj.fullHP)
                obj.hp += 20;
            Console.WriteLine(this.name + " вылечил " + obj.name);
            Treat?.Invoke(obj);//вызов события, если не null
        }











    }
}
