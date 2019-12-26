using System;

namespace Занятие_25
{
    public class Треугольник : X_Угольник
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }

        public readonly double SumOfCorners = 180;

        public double Corner_A { get; set; }
        public double Corner_B { get; set; }
        public double Corner_C { get; set; }

        public double Aria;

        public override void Proverka()
        {
            double Corners = Corner_A + Corner_B + Corner_C;
            if (Corners != 180)
            {
                Console.WriteLine("Это не треугольник! Сумма углов должна быть = 180. А у вас = " + Corners);
            }
        }

        public override void Info()
        {
            double Perimetr = Side_A + Side_B + Side_C;
            Console.WriteLine("Perimetr " + Perimetr);
       
            double Ploshad = Side_A * Side_B * Math.Sin(Corner_C);
            Console.WriteLine("Ploshad " + Ploshad);
        }
    }
}
