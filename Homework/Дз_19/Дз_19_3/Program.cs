using System;
/*3. Построить три класса (базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой 
 * (один из потомков) и фиксированной оплатой (второй потомок).
а) Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.
Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 
= 20.8 * 8 * почасовую ставку»,для работников с фиксированной оплатой «среднемесячная 
заработная плата = фиксированной месячной оплате».
б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
в) Реализовать интерфейсы для возможности сортировки массива используя Array.Sort().
г) Реализовать возможность вывода данных с использованием foreach*/
namespace Дз_19_3
{
    //СОРТИРОВАЛА ПО ИМЕНИ
    public abstract class Worker : IComparable
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object obj)
        {
            Worker w = (Worker)obj;
            return this.Name.CompareTo(w.Name);
        }
        public abstract void Pay();
    }

    public class FixedPayment : Worker
    {
        public FixedPayment(string name, string company, double salary)
        {
            Name = name;
            Company = company;
            Salary = salary;
        }
        public override void Pay()
        {
            Console.WriteLine($"{Name} ({Company}) {Salary}");
        }
    }

    public class HourlyPayment : Worker
    {
        public HourlyPayment(string name, string company, double salary)
        {
            Name = name;
            Company = company;
            Salary = salary;
        }
        public override void Pay()
        {
            Console.WriteLine($"{Name} ({Company}) {20.8 * 8 * Salary}");
            Salary = 20.8 * 8 * Salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {           
            HourlyPayment h1 = new HourlyPayment("Марк", "Apple", 1000);
            Worker w1 = h1;
            HourlyPayment h2 = new HourlyPayment("Василий", "АТБ", 30);
            Worker w2 = h2;

            FixedPayment f1 = new FixedPayment("Петя", "Google", 20000);
            Worker w3 = f1;
            FixedPayment f2 = new FixedPayment("Андрей", "Windows", 75000);
            Worker w4 = f2;

            Worker[] workers = { w1, w2, w3, w4 };
            Array.Sort(workers);

            foreach (Worker worker in workers)
                worker.Pay();
        }
    }
}
