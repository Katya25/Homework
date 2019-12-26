using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = 14;
            int Earch = years * 31557600;
            double Mercury = Earch * 0.2408467;
            double Venus = Earch * 0.61519726;
            double Mars = Earch * 1.8808158;
            double jupiter = Earch * 11.862615;
            double Saturn = Earch * 29.447498;
            double Uranus = Earch * 84.016846;
            double Neptune = Earch * 164.79132;

            Console.WriteLine(Earch);
            Console.WriteLine(Mercury);
            Console.WriteLine(Venus);
            Console.WriteLine(Mars);
            Console.WriteLine(jupiter);
            Console.WriteLine(Saturn);
            Console.WriteLine(Uranus);
            Console.WriteLine(Neptune);
        }
    }
}
