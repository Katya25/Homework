using System;

namespace Дз_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Найти сумму положительных нечетных чисел, меньших 50.​
            {
                Console.WriteLine("Задание № 1");
                int sum = 0;
                for (int i = 0; i < 50; i++)
                {
                    if (i % 2 != 0)
                        sum += i;
                }
                Console.WriteLine($"Сумма всех чисел от 0 до 50 = {sum}");
                Console.WriteLine("");
            }
            #endregion
            
            #region Task 2
            //Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.​
            {
                Console.WriteLine("задание №2");
                int a = new Random().Next(1, 5);
                int b = new Random().Next(5, 20);
                Console.WriteLine($"От {a} до {b}");
                int sum = 0;
                for (int i = a; i < b; i++)
                {
                    if (i % 4 == 0)
                        sum += i;
                }
                Console.WriteLine($"Сумма чисел из этого промежутка, кратных 4, = {sum}");
                Console.WriteLine("");
            }
            #endregion

            #region Task 3
            /*Найти: а) все двузначные числа, сумма квадратов цифр которых делится на 13; 
            б) все двузначные числа, обладающие следующим свойством: если к сумме цифр числа
            прибавить квадрат этой суммы, то получится снова искомое число.​*/
            {
                Console.WriteLine("Задание №3 а)");
                Console.WriteLine("Все двузначные числа, сумма квадратов цифр которых делится на 13, это:");
                for (int num = 10; num < 100; num++)
                {
                    int _10 = (num / 10) * (num / 10);    // _10 десятки
                    int _1 = (num % 10) * (num % 10);     // _1 еденицы
                    int sum = _10 + _1;
                    if (sum % 13 == 0)
                    {
                        Console.Write(num + ",  ");
                    }
                }
                Console.WriteLine("");
            }

            {
                Console.WriteLine("");
                Console.WriteLine("Задание №3 б)");
                Console.WriteLine("Все двузначные числа, обладающие следующим свойством: если к сумме цифр \n" +
                    "числа прибавить квадрат этой суммы, то получится снова искомое число.");
                for (int num = 10; num < 100; num++)
                {
                    int _10 = (num / 10);    // _10 десятки
                    int _1 =  (num % 10);     // _1 еденицы
                    int sum = _10 + _1;
                    int sum_V_kvadrate = Convert.ToInt32(Math.Pow(sum, 2));
                    int all = sum + sum_V_kvadrate;
                    if (num == all)
                    {
                        Console.WriteLine($"Этому условию соответствует: {num}");
                    }
                }
                Console.WriteLine("");
            }

            #endregion

            #region Task 4  
            /*Даны вещественные числа. Найти: а) максимальное из вещественных чисел;
            б) минимальное из вещественных чисел; в) максимальное и минимальное из вещественных чисел.
            Примечание В задаче(в) использовать только один оператор цикла​*/
            {
                Console.WriteLine("Задание №4 а)");
                Random x = new Random();
                double a = Convert.ToDouble(x.Next(100)/10.0);
                double b = Convert.ToDouble(x.Next(100) / 10.0);
                if (a > b)
                    Console.WriteLine($"число a ({a}) - максимальное");
                else if (a < b)
                    Console.WriteLine($"число b ({b}) - максимальное");
                else
                    Console.WriteLine($"{a} = {b}. Эти числа равны");
            }
          
            {               
                Console.WriteLine("Задание №4 б)");
                Random x = new Random();
                double a = Convert.ToDouble(x.Next(100) / 10.0);
                double b = Convert.ToDouble(x.Next(100) / 10.0);
                if (a < b)
                    Console.WriteLine($"число a ({a}) - минимальное");
                else if (a > b)
                    Console.WriteLine($"число b ({b}) - минимальное");
                else
                    Console.WriteLine($"{a} = {b}. Эти числа равны");
            }
           
            {
                Console.WriteLine("Задание №4 в)");
                Random x = new Random();
                double a = Convert.ToDouble(x.Next(100) / 10.0);
                double b = Convert.ToDouble(x.Next(100) / 10.0);
                if (a > b)
                    Console.WriteLine($"число a ({a}) - максимальное, а число b ({b})- минимальное");
                else if (a < b)
                    Console.WriteLine($"число b ({b}) - максимальное, а число а ({a}) - минимальное");
                else
                    Console.WriteLine($"{a} = {b}. Эти числа равны");
            }
            Console.WriteLine();
            #endregion 

            #region Task 5
            //Даны два целых числа A и B(A<B). Найти сумму и произведение всех целых чисел от A до B включительно.​
            {
                Console.WriteLine("Задание №5");
                int a = new Random().Next(1, 5);
                int b = new Random().Next(5, 20);
                Console.WriteLine($"Область значения от {a} до {b}");
                int summa = 0;
                int proizvedenie = 1;

                while (a <= b)
                {
                    summa += a;
                    proizvedenie *= a;

                    a++;
                }
                Console.WriteLine($"Сумма всех чисел в этом интервале {summa}, а произведение {proizvedenie}");
                Console.WriteLine("");
            }
            #endregion

            #region Task 6
            /*Даны два целых числа A и B(A < B).Вывести в порядке возрастания все целые числа, расположенные между
            A и B(включая сами числа A и B),  а также количество N этих чисел.​*/
            {
                Console.WriteLine("Задание №6");
                int a = new Random().Next(1, 5);
                int b = new Random().Next(5, 20);
                Console.WriteLine($"Область значения от {a} до {b}");
                int n = 0;
                Console.WriteLine("Все целые числа в этом диапазоне:");
                while (a <= b)
                {
                    Console.Write($"{a}, ") ;
                    n++;
                    a++;
                }
                Console.WriteLine($"Количество цифр = {n}");
                Console.WriteLine("");
            }
            #endregion

            #region Task 7
            //Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, …, 2 кг конфет.​
            {
                Console.WriteLine("Задание №7");
                double price = 66.6;
                Console.WriteLine($"Цена килограмма конфет = {price} грн");
                for (double a = 1.2; a <= 2.0; a += 0.2)    //Почему не 1.2, 1.4, 1.6, 1.8, 2 -?
                {
                    Console.WriteLine("За" + a + "   " + a * price + "грн");
                }
                Console.WriteLine("");
            }
            #endregion

            #region Task 8
            /*Даны целые положительные числа A и B(A < B).Вывести все целые числа от A до B включительно; 
            при этом каждое число должно выводиться столько раз, каково его значение(например, число 3 выводится
            3 раза).*/
            {
                Console.WriteLine("Задание №8");
                int a = new Random().Next(1, 5);
                int b = new Random().Next(5, 20);
                Console.WriteLine($"Диапазон от {a} до {b}");
               
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }





    }
}
