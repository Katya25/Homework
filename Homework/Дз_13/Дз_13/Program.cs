using System;

namespace Дз_13
{
    
    class CoffeeMaker
    {
        private int totalvalueOfWater = 1000;
        private int totalcountOfSeed = 50;
        private int totalvalueOfMilk = 750;
        private int totalvalueOfSugare = 250;




        private int valueOfWater;
        private int countOfSeed;
        //private bool isOn = true;           
        private int valueOfMilk;
        private int valueOfSugare;
        

      

        public int ValueOfWater { get => valueOfWater; }
        public int CountOfSeed { get => countOfSeed; }
        public int ValueOfMilk { get => valueOfMilk; }
        public int ValueOfSugare { get => valueOfSugare; }
        //public bool IsOn { get => isOn; set => isOn = value; }



        public void MakeCoffe(int coffee)
        {
            Console.WriteLine($"До Water {totalvalueOfWater}, sugare {totalvalueOfSugare}," +
                           $" seed {totalcountOfSeed}, milk {totalvalueOfMilk}");
            Console.WriteLine();

            //if (IsOn)
            //{
                switch (coffee)
                {
                    case 1:

                        valueOfWater = 120;
                        valueOfSugare = 10;
                        countOfSeed = 5;
                        valueOfMilk = 0;

                        Console.WriteLine("Классический американо или хотите что-то добавить? \n" +
                            "(Если классический, то нажмите 1, если хотите что-то добавить - 2)");
                        int AddToAmericano = Convert.ToInt32(Console.ReadLine());

                        if (AddToAmericano == 2)
                        {
                            Console.WriteLine("Что вы хоите добавить?(Сахар - 1, молоко - 2, вода - 3, зерна кофе - 4 )");
                            int WhatAdd = Convert.ToInt32(Console.ReadLine());
                            switch (WhatAdd)
                            {
                                case 1:
                                    Console.WriteLine("Сколько сахара добавить?");
                                    valueOfSugare += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("Сколько молока добавить?");
                                    valueOfMilk += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("Сколько воды добавить?");
                                    valueOfWater += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("Сколько зерен кофе добавить?");
                                    countOfSeed += Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Такого варианта нет");
                                    break;
                            }
                        }


                        if (totalvalueOfWater > valueOfWater & totalvalueOfSugare > valueOfSugare &
                            totalcountOfSeed > countOfSeed & totalvalueOfMilk > valueOfMilk)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            totalvalueOfMilk -= valueOfMilk;
                            Console.WriteLine($"Ваш кофе (Американо) говов");
                        }

                        if (totalvalueOfMilk < valueOfMilk)
                        Console.WriteLine("молоко закончилось");

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");

                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна кофе закончились");
                        break;


                    case 2:

                        Console.WriteLine("Какой латте желаете: европейский (200мл) или американский(500мл)?\n" +
                            "(Для европейского нажмите 1, для американского - 2)");
                        int WhatLatte = Convert.ToInt32(Console.ReadLine());
                        switch (WhatLatte)
                        {
                            case 1:
                                valueOfWater = 60;
                                valueOfMilk = 120;
                                break;
                            case 2:
                                valueOfWater = 120;
                                valueOfMilk = 360;                             
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }

                        valueOfSugare = 20;
                        countOfSeed = 5;

                        if (totalvalueOfWater > valueOfWater & totalvalueOfSugare > valueOfSugare &
                            totalcountOfSeed > countOfSeed & totalvalueOfMilk > valueOfMilk)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            totalvalueOfMilk -= valueOfMilk;
                            Console.WriteLine($"Ваш кофе (Латте) говов");
                        }

                        if (totalvalueOfWater < valueOfWater)                   
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)                          
                            Console.WriteLine("Сахар закончился");

                        if (totalcountOfSeed < countOfSeed)                           
                            Console.WriteLine("Зерна коффе закончились");

                        if (totalvalueOfMilk < valueOfMilk)                          
                            Console.WriteLine("молоко закончилось");
                        break;


        
                    case 3:

                        Console.WriteLine("Какой эспрессо вы хотите (simple espresso(нажмите 1), doppio(двойное(нажмите 2)), \n" +
                            "lungo(некрепкоое(нажмите - 3)))");
                        int whatEspresso = Convert.ToInt32(Console.ReadLine());

                        valueOfWater = 30;

                        switch (whatEspresso)
                        {
                            case 1:
                                valueOfSugare = 10;
                                countOfSeed = 7;
                                break;
                            case 2:
                                valueOfSugare = 10;
                                countOfSeed = 15;
                                break;
                            case 3:
                                valueOfSugare = 10;
                                countOfSeed = 4;
                                break;
                            default:
                                Console.WriteLine("Такого варианта нет");
                                break;
                        }
                        
                        if (totalvalueOfWater > valueOfWater & totalvalueOfSugare > valueOfSugare &
                           totalcountOfSeed > countOfSeed)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalvalueOfSugare -= valueOfSugare;
                            totalcountOfSeed -= CountOfSeed;
                            Console.WriteLine($"Ваш кофе (эспрессо) говов");
                        }

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");

                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна коффе закончились");
                        break;

                       
                    case 4:

                        valueOfSugare = 0;
                        valueOfWater = 100;
                        valueOfMilk = 50;
                        countOfSeed = 5;

                        Console.WriteLine("Классический капучино или хотите что-то добавить? \n" +
                            "(Если классический, то нажмите 1, если хотите что-то добавить - 2)");
                        int AddToCapucino = Convert.ToInt32(Console.ReadLine());

                        if (AddToCapucino == 2)
                        {
                            Console.WriteLine("Что вы хоите добавить?(Сахар - 1, молоко - 2, вода - 3, зерна кофе - 4 )");
                            int WhatAdd = Convert.ToInt32(Console.ReadLine());
                            switch (WhatAdd)
                            {
                                case 1:
                                    Console.WriteLine("Сколько сахара добавить?");
                                    valueOfSugare += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("Сколько молока добавить?");
                                    valueOfMilk += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("Сколько воды добавить?");
                                    valueOfWater += Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("Сколько зерен кофе добавить?");
                                    countOfSeed += Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Такого варианта нет");
                                    break;
                            }
                        }

                        if (totalvalueOfWater > valueOfWater & totalvalueOfSugare > valueOfSugare &
                           totalcountOfSeed > countOfSeed & totalvalueOfMilk > valueOfMilk)
                        {
                            totalvalueOfWater -= valueOfWater;
                            totalcountOfSeed -= CountOfSeed;
                            totalvalueOfMilk -= valueOfMilk;
                            totalvalueOfSugare -= valueOfSugare;
                            Console.WriteLine($"Ваш кофе (Капучино) говов");
                        }

                        if (totalvalueOfWater < valueOfWater)
                            Console.WriteLine("Вода закончилась");                   

                        if (totalcountOfSeed < countOfSeed)
                            Console.WriteLine("Зерна коффе закончились");

                        if (totalvalueOfSugare < valueOfSugare)
                            Console.WriteLine("Сахар закончился");

                        if (totalvalueOfMilk < valueOfMilk)
                            Console.WriteLine("молоко закончилось");
                        break;             
                }

                Console.WriteLine();
                Console.WriteLine($" После Water {totalvalueOfWater}, sugare {totalvalueOfSugare}," +
                          $" seed {totalcountOfSeed}, milk {totalvalueOfMilk}");

            //}
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Какой кофе: (americano(нажмите 1), latte(2), espresso(3), capucino(4))");

            int coffee = Convert.ToInt32(Console.ReadLine());
            
            CoffeeMaker coffeeMaker = new CoffeeMaker();
            coffeeMaker.MakeCoffe(coffee);

        }
    }
}
