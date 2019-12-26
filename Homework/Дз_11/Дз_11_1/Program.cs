using System;
/*1. Определить класс с именем Order содержащий следующие поля:
    - расчетный счет плательщика(формат уточнить в Интернете);
    - расчетный счет получателя;
    - перечисляемая сумма в грн, $, евро
    Методы:
    - упорядочить по убыванию перечисляемой суммы;
    - вывод информации о тех плательщиках, перечисляемая сумма которых не меньше суммы,
    введенной пользователем.
    - ввод данных в массив из n элементов типа Order в Main;*/


namespace Дз_11_1
{
    class Order
    {
        public decimal Platil;
        public decimal Poluch;

        public decimal SumHrn;
        public decimal SumDollar;
        public decimal SumEvro;

        public decimal sum1;
        public decimal sum2;
        public decimal sum3;
        public decimal sumPolz;

        public Order(decimal sum1, decimal sum2, decimal sum3)
        {
            this.sum1 = sum1;
            this.sum2 = sum2;
            this.sum3 = sum3;
        }

        public Order(decimal Platil, decimal Poluch, decimal SumHrn, decimal SumDollar, decimal SumEvro, decimal sumPolz)
        {
            this.Platil = Platil;
            this.Poluch = Poluch;
            this.SumHrn = SumHrn;
            this.SumDollar = SumDollar;
            this.SumEvro = SumEvro;
            this.sumPolz = sumPolz;
        }
        public void Poradok(decimal sum1, decimal sum2, decimal sum3)
        {
            decimal[] ChtoZaChem = { sum1, sum2, sum3 };
            Array.Sort(ChtoZaChem);
            Array.Reverse(ChtoZaChem);
            foreach (var item in ChtoZaChem)
            {
                Console.Write(item + ", ");
            }
        }
        public void Sravnenie(decimal sumPolz, decimal[] sravnenie, decimal[] plat, decimal[] poluch, decimal[] HRN, decimal[] Evro, decimal[] Dollars)
        {
            for (int i = 0; i < sravnenie.Length; i++)
            {
                if (sravnenie[i] >= sumPolz)
                {
                    Console.WriteLine($"Карта отправителя: {plat[i]}, получателя: {poluch[i]}, \n" +
                        $"сумма гривен: {HRN[i]}, сумма долларов: {Dollars[i]}, \n" +
                        $"сумма евро: {Evro[i]}, общая сумма: {sravnenie[i]} ");
                }
            }
        }

    }
        class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Karta1");
            decimal Platil1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Poluchatel");
            decimal Poluch1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("hrn");
            decimal SumHrn1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dollars");
            decimal SumDollar1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Evro");
            decimal SumEvro1 = Convert.ToDecimal(Console.ReadLine());
            decimal sum1 = SumHrn1 + SumEvro1 * 29 + SumDollar1 * 25;

            Console.WriteLine("Karta2");
            decimal Platil2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Poluchatel");
            decimal Poluch2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("hrn");
            decimal SumHrn2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dollars");
            decimal SumDollar2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Evro");
            decimal SumEvro2 = Convert.ToDecimal(Console.ReadLine());
            decimal sum2 = SumHrn2 + SumEvro2 * 29 + SumDollar2 * 25;

            Console.WriteLine("Karta3");
            decimal Platil3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Poluchatel");
            decimal Poluch3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("hrn");
            decimal SumHrn3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dollars");
            decimal SumDollar3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Evro");
            decimal SumEvro3 = Convert.ToDecimal(Console.ReadLine());
            decimal sum3 = SumHrn3 + SumEvro3* 29 + SumDollar3 * 25;

            Order ord = new Order( sum1, sum2, sum3);
            ord.Poradok(sum1, sum2, sum3);

            Console.WriteLine("Введите сумму в грн: ");
            decimal sumPolz = Convert.ToDecimal(Console.ReadLine());

            decimal[] plat = new decimal[3];
            plat[0] = Platil1;
            plat[1] = Platil2;
            plat[2] = Platil3;

            decimal[] poluch = new decimal[3];
            poluch[0] = Poluch1;
            poluch[1] = Poluch2;
            poluch[2] = Poluch3;

            decimal[] HRN = new decimal[3];
            HRN[0] = SumHrn1;
            HRN[1] = SumHrn2;
            HRN[2] = SumHrn3;

            decimal[] Evro = new decimal[3];
            Evro[0] = SumEvro1;
            Evro[1] = SumEvro2;
            Evro[2] = SumEvro3;

            decimal[] Dollars = new decimal[3];
            Dollars[0] = SumDollar1;
            Dollars[1] = SumDollar2;
            Dollars[2] = SumDollar3;

            decimal[] sravnenie = new decimal[3];
            sravnenie[0] = sum1;
            sravnenie[1] = sum2;
            sravnenie[2] = sum3;
            Console.WriteLine("Информация о платильщиках, чья сумма больше " + sumPolz);
            ord.Sravnenie(sumPolz, sravnenie, plat, poluch, HRN, Evro, Dollars);
        }
       
    }
}
