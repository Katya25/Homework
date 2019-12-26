using System;

namespace Занятие_25
{
    public class овал : GeometricFigure
    {
        private double PI = Math.PI;


        public double R { get; set; }
        public double D { get; set; }

        public double БольшаяОсь { get; set; }
        public double МеньшаяОсь { get; set; }

        public override void Info()
        {
            
            double Ploshad = (БольшаяОсь * МеньшаяОсь) * PI;
            Console.WriteLine("Ploshad " + Ploshad);
        }

    }
}
