using System;

/*Создать класс Tiles(кафель), который будет содержать поля с открытым доступом: brand, size_h, size_w, price и метод
 класса getData(). В главной функции объявить пару объектов класса и внести данные в поля.Затем отобразить их,
 вызвав метод getData().*/


namespace _12_1
{
    class Tiles
    {
        public string brand;
        public double size_h;
        public double size_w;
        public double price;

        public Tiles(string brand, double size_h, double size_w, double price)
        {
            this.brand = brand;
            this.size_h = size_h;
            this.size_w = size_w;
            this.price = price;
        }

        public void getData()
        {
            Console.WriteLine($"Brand is {brand}, size_h = {size_h}, size_w = {size_w}, price: {price}");
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string brand = "abc";
            double size_h = 0.5;
            double size_w = 1;
            double price = 100;

            Tiles _1 = new Tiles(brand, size_h, size_w, price);

            _1.getData();
        }
    }
}
