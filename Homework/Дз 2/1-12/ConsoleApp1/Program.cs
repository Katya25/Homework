using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ЗАДАНИЕ № 1    

            ////НЕ СОВСЕМ ПОНИМАЮ ЗАДАНИЕ.   ЕСЛИ ИМЕЕТСЯ ВВИДУ С РАЗНОЙ ТОЧНОСТЬЮ, ТО:
            //double a = Math.PI;
            //float b = (float)a;
            //double c = 3.14;
            //int d = (int)b;
            //Console.WriteLine($"Большая точность {a}, меньше {b},  в таком виде обычно используют {c}, только целая часть {d};



            ////ЗАДАНИЕ № 2

            Console.WriteLine("What's your name?");  ////Full Name - ФИО 
            string name = Console.ReadLine();
            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("What's your patronymic?");
            string patronymic = Console.ReadLine();
            Console.WriteLine($"Hi, {surname} {name} {patronymic}");
            Console.WriteLine("How old are you?");
            byte ageOfPerson = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"You're {ageOfPerson} years old, {name}");
            Console.WriteLine("What's your hobby?");
            string hobby = Console.ReadLine();
            Console.WriteLine("It's cool! Have a nice day:)");





            ////ЗАДАНИЕ №3

            //Console.WriteLine("Версия Windows: {0}", Environment.OSVersion);
            //Console.WriteLine("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет");
            //Console.WriteLine("Имя компьютера : {0}", Environment.MachineName);
            //Console.WriteLine("Модель процессора:  {0}", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
            //Console.WriteLine("Число процессоров : {0}", Environment.ProcessorCount);
            //Console.WriteLine("Системная папка : {0}", Environment.SystemDirectory);
            //Console.WriteLine("Имя пользователя: {0}", Environment.UserName);
            //Console.WriteLine("Логические диски : {0}", String.Join(", ", Environment.GetLogicalDrives())
            //   .TrimEnd(',', ' ') .Replace("\\", String.Empty));
            //Console.ReadKey();







            ////ЗАДАНИЕ № 4

            //           // С ВРЕМЕННОЙ ПЕРЕМЕННОЙ
            //Console.WriteLine("please write the first number:");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("please write the second number:");
            //double second = Convert.ToDouble(Console.ReadLine());

            //double ass;                       ////ass-assistant
            //ass = first;
            //first = second;
            //second = ass;
            //Console.WriteLine($"Now first is {first} ahd second is {second}");



            ////БЕЗ ВРЕМЕННОЙ ПЕРЕМЕННОЙ

            //Console.WriteLine("please write the first number:");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("please write the second number:");
            //double second = Convert.ToDouble(Console.ReadLine());

            //first = first + second;
            //second = second - first;
            //second = -second;
            //first = first - second;
            //Console.WriteLine($"Now first is {first} ahd second is {second}");








            ////ЗАДАНИЕ № 5

            //Console.WriteLine("Введите, пожалуйста, расстояние в сантиметрах:");
            //decimal dictance = Convert.ToDecimal(Console.ReadLine());
            //int meters = (int)dictance / 100;
            //Console.WriteLine($" В метрах это будет: {meters}");







            ////ЗАДАНИЕ № 6

            //byte days = 234;
            //int weeks = days / 7;
            //Console.WriteLine($"в 234 днях полных недель: {weeks}");








            ////ЗАДАНИЕ № 7

            //int r_s_a = 543;                   ////rectangle_side_a -  сторона прямоугольника а
            //int r_s_b = 130;                   ////rectangle_side_b -  сторона прямоугольника б
            //int r_area = r_s_a * r_s_a;        ////rectangle_area - площадь прямоугольника

            //int square_side = 130;
            //int square_area = square_side * square_side;

            //int squares = r_area / square_area; 

            //Console.WriteLine($"Squares will be: {squares}");






            ////ЗАДАНИЕ № 8

            //Console.WriteLine("Пожалуйста, введите двузначное число:");
            //byte number = Convert.ToByte(Console.ReadLine());
            //int _10 = number / 10;
            //int _1 = number % 10;
            //int sum = _10 + _1;
            //int multiplication = _10 * _1;
            //Console.WriteLine($"Число десятков в Вашем числе: {_10}, а число единиц: {_1}");
            //Console.WriteLine($"Сумма его чисел: {sum} а произведение: {multiplication}"); 







            ////ЗАДАНИЕ № 9

            //Console.WriteLine("please write the first number:");
            //double first = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("please write the second number:");
            //double second = Convert.ToDouble(Console.ReadLine());
            //double amount = first + second;
            //double middle = amount / 2;
            //Console.WriteLine($"Arithmetic mean of these two numbers is: {middle}");







            //// ЗАДАНИЕ № 10

            //Console.WriteLine("Напишите любое число:");
            //double num = Convert.ToDouble(Console.ReadLine());
            //double square = num * num;
            //Console.WriteLine($"{num} в квадрате будет {square}");






            ////ЗАДАНИЕ № 11

            //Console.WriteLine("Напишите любое трехзначное число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int _100 = number % 10;
            //int _10 = number % 100 / 10;
            //int _1 = number % 1000 / 100;

            //int ass;                       
            //ass = _100;
            //_100 = _1;
            //_1 = ass;
            //Console.WriteLine($"Если написать ваше число наоборот, то бдет {_1}{_10}{_100}");






            ////ЗАДАНИЕ № 12

            //Console.WriteLine("Напишите любое трехзначное число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int _1 = number % 10;
            //int _10 = number % 100 / 10;
            //int _100 = number % 1000 / 100;

            //int ass;
            //ass = _100;
            //_100 = _10;
            //_10 = ass;
            //Console.WriteLine($"Если поменять первую и вторую цыфры местами, то бдет {_100}{_10}{_1}");

        }
    }
}
