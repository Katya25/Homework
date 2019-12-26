using System;
/*3. Определить класс с именем Price, содержащий следующие поля:
    - название товара;
    - название магазина, в котором продается товар;
    - стоимость товара в грн.
    Методы:
    - ввод данных в массив из n элементов в типа Price;
    - упорядочить в алфавитном порядке по названиям товаров;
    - вывод информации о товаре, название которого ввел пользователь.*/


namespace Дз_11_3
{
    class Price
    {
        private string productName;
        private int productCost;
        private string shopName;
        private string[] nameArray;
        private string name1;
        private string name2;
        private string name3;
        private string shop1;
        private string shop2;
        private string shop3;
        private int cost1;
        private int cost2;
        private int cost3;
        private string write;


        public Price()

        {
        }

        public Price(string name1, string name2, string name3, string shop1, string shop2, string shop3,
            int cost1, int cost2, int cost3 )
        {
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.shop1 = shop1;
            this.shop2 = shop2;
            this.shop3 = shop3;
            this.cost1 = cost1;
            this.cost2 = cost2;
            this.cost3 = cost3;
        }

        public Price(string[] nameArray)
        {
            this.nameArray = nameArray;
        }
        public Price(string write)
        {
            this.write = write;
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;                
            }                      
        }
        public int ProductCost
        {
            get
            {
                return productCost;
            }
            set
            {
                productCost = value;
            }
        }
        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
            }
        }

        public string Name1 { get => name1; set => name1 = value; }
        public string Name2 { get => name2; set => name2 = value; }
        public string Name3 { get => name3; set => name3 = value; }
        public string Shop1 { get => shop1; set => shop1 = value; }
        public string Shop2 { get => shop2; set => shop2 = value; }
        public string Shop3 { get => shop3; set => shop3 = value; }
        public int Cost1 { get => cost1; set => cost1 = value; }
        public int Cost2 { get => cost2; set => cost2 = value; }
        public int Cost3 { get => cost3; set => cost3 = value; }
        public string Write1 { get => write; set => write = value; }

        public void Sort()
        {
            Array.Sort(nameArray);
            foreach (var item in nameArray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        
        public void Write()
        {
            if (write == name1)
            {
                Console.WriteLine($"Название продукта: {name1}, магазина: {shop1}, цена: {cost1}");
            }
            else if (write == name2)
            {
                Console.WriteLine($"Название продукта: {name2}, магазина: {shop2}, цена: {cost2}");
            }
            else if (write == name3)
            {
                Console.WriteLine($"Название продукта: {name3}, магазина: {shop3}, цена: {cost3}");
            }
            else
            {
                Console.WriteLine("Такого продукта нет");
            }
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Price price1 = new Price();
            price1.ProductName = "Хлеб";
            price1.ShopName = "АТБ";
            price1.ProductCost = 12;

            Price price2 = new Price();
            price2.ProductName = "Торт";
            price2.ShopName = "Варус";
            price2.ProductCost = 250;

            Price price3 = new Price();
            price3.ProductName = "Чипсы";
            price3.ShopName = "Ашан";
            price3.ProductCost = 9;

            string[] nameArray = { price1.ProductName, price2.ProductName, price3.ProductName };
            Price array = new Price(nameArray);
            array.Sort();

            string name1 = price1.ProductName;
            string name2 = price2.ProductName;
            string name3 = price3.ProductName;
            string shop1 = price1.ShopName;
            string shop2 = price2.ShopName;
            string shop3 = price3.ShopName;
            int cost1 = price1.ProductCost;
            int cost2 = price2.ProductCost;
            int cost3 = price3.ProductCost;
            Price name = new Price(name1, name2, name3, shop1, shop2, shop3, cost1, cost2, cost3 );


            Console.WriteLine("vvedite tovar");
            string write = Console.ReadLine();
            Price Write = new Price(write);
            Write.Write();
        }
    }
}
