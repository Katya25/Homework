using System;
/*Создать статический класс Calculatot, с методами для выполнения основных арифметических операций. 
Написать программу, которая выводит на экран основные арифметические операции.*/
namespace _1
{
    class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };

        }

        public static Counter operator -(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value - c2.Value };

        }

        public static Counter operator *(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value * c2.Value };

        }

        public static Counter operator /(Counter c1, Counter c2)
        {           
                return new Counter { Value = c1.Value / c2.Value };                       

        }

        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }

        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь первой фигуры");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь второй фигуры");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Counter c1 = new Counter() { Value = value1 };
            Counter c2 = new Counter() { Value = value2 };
            bool res1 = c1 > c2;
            Console.WriteLine("Площадь первой больше - " + res1);
            bool res2 = c1 < c2;
            Console.WriteLine("площадь первой меньше - " + res2);
            Counter c3 = c1 + c2;
            Console.WriteLine("Сумма: " + c3.Value);
            Counter c4 = c1 - c2;
            Console.WriteLine("Разность: " + c4.Value);
            Counter c5 = c1 * c2;
            Console.WriteLine("Произведение: " + c5.Value);
            if (c2.Value != 0)
            {
                Counter c6 = c1 / c2;
                Console.WriteLine("Частное: " + c6.Value);
            }
            else Console.WriteLine("На ноль делить нельзя!");
            
        }
    }
}
