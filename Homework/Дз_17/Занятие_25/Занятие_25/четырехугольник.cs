using System;

namespace Занятие_25
{
    public class четырехугольник : X_Угольник
    {
        public readonly double SumOfCorners = 360;
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }
        public double Side_D { get; set; }

        public double Corner_A { get; set; }
        public double Corner_B { get; set; }
        public double Corner_C { get; set; }
        public double Corner_D { get; set; }

        public double D1 { get; set; }
        public double D2 { get; set; }
        public double Corner_D1_D2 { get; set; }

        public double Aria;

        public override void Proverka()
        {
            double Corners = Corner_A + Corner_B + Corner_C + Corner_D;
            if (Corners != 360)
            {
                Console.WriteLine("Это не четырехугольник! Сумма углов должна быть = 360. А у вас = " + Corners);
            }
        }

        public override void Info()
        {
            double Perimetr = Side_A + Side_B + Side_C + Side_D;
            Console.WriteLine("Perimetr " + Perimetr);

            double Ploshad = D1 * D2 * Math.Sin(Corner_D1_D2);
            Console.WriteLine("Ploshad " + Ploshad);
        }
    }
}
