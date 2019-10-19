using System;

namespace HomeWork2
{
    class Person
    {
        private string Name;
        private string Surname;
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public virtual void Display()
        {
            Console.Write($"Name: {Name}, surname: {Surname}");
        }
    }
    class Maria : Person
    {
        private int Age;


        public Maria(String Name, string Surname, int Age) : base(Name, Surname)
        {
            this.Age = Age;
        }
        public override void Display()
        {
            Console.WriteLine();
            base.Display();
            Console.Write($", age: {Age}");
        }
    }
    class Michail : Maria
    {
        private string Hobbie;

        public Michail(string Name, string Surname, int Age, string Hobbie) : base(Name, Surname, Age)
        {
            this.Hobbie = Hobbie;
        }
        public override void Display()
        {
            base.Display();
            Console.Write($", hobbie: {Hobbie}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Cristiano", "Ronaldo");
            Maria maria = new Maria("Maria", "Lisicca", 25);
            Michail michail = new Michail("Michail", "Schumaher", 42, "Formula 1");
            person.Display();
            maria.Display();
            michail.Display();
        }
    }
}
