using System;

/*Определить класс Children, который содержит такие поля(члены класса): закрытые – имя ребенка, фамилию и возраст,
публичные – методы ввода данных и отображения их на экран.Объявить
два объекта класса, внести данные и показать их.*/

namespace _12_2
{
    class Children
    {
        private string Name;
        private string secondName;
        private int Age;

        public string childSecond
        {
            set
            {
                secondName = value;
            }
            get
            {
                return secondName;
            }
        }

        public string childName
        {
            set
            {
                Name = value;
            }          
            get
            {
                return Name;
            }
        }

        public int childAge
        {
            set
            {
                Age = value;
            }
            get
            {
                return Age;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Children child1 = new Children();

            child1.childName = "Denis";
            child1.childSecond = "Denisov";
            child1.childAge = 15;

            Console.WriteLine("Full name: " +child1.childSecond + " " + child1.childName + ", Age: " + child1.childAge);


            Children child2 = new Children();

            child2.childName = "Ivan";
            child2.childSecond = "Ivanov";
            child2.childAge = 7;

            Console.WriteLine("Full name: " + child2.childSecond + " " + child2.childName + ", Age: " + child2.childAge);

        }
    }
}
