using System;

namespace Занятие_25
{
    public class ромб : X_Угольник
    {
        public readonly double SumOfCorners = 360;
        public double Side_A { get; set; }
        public double Corner_A { get; set; }
        public double Corner_B { get; set; }

        public double Aria;

        public double D1 { get; set; }
        public double D2 { get; set; }
        public readonly double Corner_D1_D2 = 90;

       

        public override void Proverka()
        {
            double Corners = (Corner_A + Corner_B) * 2;
            if (Corners != 360)
            {
                Console.WriteLine("Это не ромб! Сумма углов должна быть = 360. А у вас = " + Corners);
            }
        }

        

        public override void Info()
        {
            double Perimetr = Side_A * 4;
            Console.WriteLine("Perimetr " + Perimetr);

            double Ploshad = (D1 * D2) / 2;
            Console.WriteLine("Ploshad " + Ploshad);
        }
    }
}
