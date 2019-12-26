using System;
/*Изучить Singelton. Создать класс, где необходимо подключить базу данных в проект и класс, который будет отвечать
за соединение с ней. Один раз создается соединение и нет нужды создавать его снова и снова*/
namespace _4
{
    class Singelton
    {
        private static Singelton instance;
        public Singelton()
        {

        }

        public static Singelton GetInstance(string str)
        {
            if (instance == null)
            {
                instance = new Singelton();
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("База данных уже была подключена");
            }
            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string SQL = "База данных подключена";
            Singelton s = Singelton.GetInstance(SQL);

            string SQL2 = "База данных не подключена";
            Singelton s2 = Singelton.GetInstance(SQL2);

        }
    }
}
