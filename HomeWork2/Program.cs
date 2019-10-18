using System;

namespace HomeWork2
{
    class Person
    {
        private string Name;
        private string Surname;
        public string name {
            get
            {
                return Name;
            }
            set
            {
                Name = name;
            }
        }
        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = surname;
            }
        }
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {name}, surname: {surname}.");
        }
    }
    class Maria : Person
    {
        private int Age;
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = age;
            }
        }

        public Maria(String Name, string Surname, int Age) : base(Name, Surname)
        {
            this.Age = Age;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}.");
        }
    }
    class Michail : Maria
    {
        private string Hobbie;
        public string hobbie
        {
            get
            {
                return Hobbie;
            }
            set
            {
                Hobbie = hobbie;
            }
        }
        public Michail(string Name, string Surname, int Age, string Hobbie) : base(Name, Surname, Age)
        {
            this.Hobbie = Hobbie;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}, hobbie:{hobbie}.");
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
