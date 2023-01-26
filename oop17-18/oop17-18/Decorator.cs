using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
    abstract class Collegue //абстрактный класс, который определяет интерфейс для наследуемых объектов
    {
        public Collegue(string Education) => this.Education = Education;
        public string NameWorker { get; set; }
        public string Education { get; set; }
        public abstract int GetAge();
    }
    class School : Collegue
    {
        public School() : base("Закончил школу") { }
        public override int GetAge() => 18;
    }
    class University : Collegue     //конкретная реализация компонента, в которую с помощью декоратора добавляется новая функциональность
    {
        public University() : base("Закончил университет") { }
        public override int GetAge() => 22;
    }
    abstract class CollegueDecorator : Collegue
    {
        protected Collegue pizza;
        public CollegueDecorator(string n, Collegue pizza) : base(n) => this.pizza = pizza;
    }
    class Magistr : CollegueDecorator
    {
        public Magistr(Collegue Col) : base(Col.Education + ", степень магистра", Col) { }
        public override int GetAge() => pizza.GetAge() + 3;
    }
    class Bacalavr : CollegueDecorator
    {
        public Bacalavr(Collegue Col) : base(Col.Education + ", бакалавр", Col) { }
        public override int GetAge() => pizza.GetAge() + 3;
    }
}
