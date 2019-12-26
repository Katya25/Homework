using System;

namespace Занятие_25
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь первой фигуры");
            int ploshad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите площадь второй фигуры");
            int ploshad2 = Convert.ToInt32(Console.ReadLine());

            Counter c1 = new Counter() { Value = ploshad1 };
            Counter c2 = new Counter() { Value = ploshad2 };
            bool res1 = c1 > c2;
            Console.WriteLine("Первое число больше второго - " + res1);
            bool res2 = c1 < c2;
            Console.WriteLine("Первое число меньше второго - " + res2);
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
