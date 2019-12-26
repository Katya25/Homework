using System;

namespace Дз_11
{
    //НОМЕР 4
    /*Создать класс с именем Rectangle, содержащий следующие поля:
    -два поля, описывающие длины сторон double side1, side2.
-создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1
и side2 инициализируются значениями аргументов 
Методы :
- вычисление площади прямоугольника -double AreaCalculator()
- периметр прямоугольника - double PerimeterCalculator()
- Создать два свойства double Area и double Perimeter с одним методом доступа get
- Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на 
экран периметр и площадь.*/
    class RectAngele
    {

        private double side1;
        private double side2;

        public RectAngele(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Perimeter()
        {
            return 2 * side1 + 2 * side2;
        }

        public double Area()
        {
            return side1 * side2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны");
            double side2 = double.Parse(Console.ReadLine());

            RectAngele rect = new RectAngele(side1, side2);

            Console.WriteLine("Площадь = " + rect.Area());
            Console.WriteLine("Периметр = " + rect.Perimeter());
        }
    }
}
