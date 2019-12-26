using System;

namespace Try
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "Неизвестно";
            age = 18;
        }

        public Person(string n)
        {
            name = n;
            age = 18;
        }

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public void GetInfo(int age, string name)
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo("Rita", 18);


        }

    }
}
