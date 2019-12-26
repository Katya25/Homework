using System;



namespace Дз_3
{
    class Program
    {

        //////ЗАДАНИЕ № 1

        //static double евро(double г)
        //{
        //    double евро = г / 27.9;
        //    return евро;
        //}

        //static double доллары(double г)
        //{
        //    double доллары = г / 25.6;
        //    return доллары;
        //}

        //static double рубли(double г)
        //{
        //    double рубли = г / 0.39;
        //    return рубли;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите сумму в гривнах");
        //    var г = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("В долларах это ");
        //    Console.WriteLine(доллары(г));
        //    Console.WriteLine("В евро ");
        //    Console.WriteLine(евро(г));
        //    Console.WriteLine("В рублях ");
        //    Console.WriteLine(рубли(г));
        //}











        ////ЗАДАНИЕ № 2

        //static double дни(double секунды)
        //{
        //    double result = секунды / 86400;
        //    return result;
        //}

        //static double часы(double секунды)
        //{
        //    double result = секунды / 3600;
        //    return result;
        //}

        //static double минуты(double секунды)
        //{
        //    double result = секунды / 60;
        //    return result;
        //}

        //static string Д_Ч_М(double секунды)
        //{
        //    int minutes = Convert.ToInt32(секунды / 60);
        //    int newSec = Convert.ToInt32(секунды - minutes * 60);
        //    int hour = minutes / 60;
        //    int newMinnutes = minutes - hour * 60;
        //    int days = hour / 24;
        //    int newHours = hour - days * 24;


        //    string время = ($"{days} дней {newHours} часов {newMinnutes} минут {newSec} секунд");
        //    return время;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите время в секундах");
        //    var секунды = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("В днях это ");
        //    Console.WriteLine(дни(секунды));
        //    Console.WriteLine("В часах это ");
        //    Console.WriteLine(часы(секунды));
        //    Console.WriteLine("В минутах это ");
        //    Console.WriteLine(минуты(секунды));
        //    Console.WriteLine("Всего это ");
        //    Console.WriteLine(Д_Ч_М(секунды));
        //}













        ////ЗАДАНИЕ № 3

        //static decimal Perimetr(decimal side)
        //{
        //    decimal result = 4 * side;
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Чему равна сторона квадрата?");
        //    var side = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("Периметр этого квадрата будет:");
        //    Console.WriteLine(Perimetr(side));
        //}










        ////ЗАДАНИЕ № 4

        //static decimal Diametr(decimal r)
        //{
        //    decimal result = 2 * r;
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите радиус");
        //    var r = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("Диаметр будет");
        //    Console.WriteLine(Diametr(r));
        //}









        ////ЗАДАНИЕ № 5


        //static string Сумма_Скидки(decimal сумма, decimal скидка)
        //{
        //    decimal В_одном_Проценте = сумма / 100;
        //    decimal Сум_Скид = скидка * В_одном_Проценте;
        //    decimal К_Оплате = сумма - Сум_Скид;
        //    string Всего = ($"{К_Оплате}");
        //    return Всего;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите, пожалуйста, сумму покупки");
        //    decimal сумма = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("Введите вашу скидку в процентах");
        //    decimal скидка = Convert.ToDecimal(Console.ReadLine());
        //    Console.WriteLine("Всего с учетом скидки");
        //    Console.WriteLine(Сумма_Скидки(сумма, скидка));
        //}




    }
}
