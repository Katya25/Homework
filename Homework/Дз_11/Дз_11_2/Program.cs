using System;
/*2. Определить класс с именем Worker, содержащий следующие поля:
    - фамилия и инициалы работника;
    - название занимаемой должности;
    - год поступления на работу.
    Методы:
    - ввод данных в массив из n элементов типа Worker;
    - упорядочить по алфавиту фамилии работников;
    - вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.*/

namespace Дз_11_2
{
    class worker
    {
     
        public string FirstName;
        public string Inizials;
        public int StartWork;

        public worker(string FirstName, string Inizials, int WhenStartWork)
        {
            this.FirstName = FirstName;
            this.Inizials = Inizials;
            this.StartWork = WhenStartWork;
        }
        public void Sort(string[] FirstNames)
        {
            Array.Sort(FirstNames);
            foreach (var item in FirstNames)
            {
                Console.WriteLine(item);
            }
        }

        public void Staj(int[] YersOfWork, string[] FirstNames, int staj)
        {
            for (int i = 0; i < YersOfWork.Length; i++)
            {

                if (YersOfWork[i] >= staj)
                {
                    Console.WriteLine(FirstNames[i] + "(" + YersOfWork[i] + ")");
                }

            }
        }
}
    class Program
    {
        static void Main()
        {
            /* - ввод данных в массив из n элементов в типа Worker;
            - упорядочить по алфавиту фамилии работников;
            - вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.*/

            worker worker1 = new worker("Ivanov", "I.V.", 2000);
            worker worker2 = new worker("Maximov", "M.A.", 1950);
            worker worker3 = new worker("Nazarenko", "N.A.", 2019);

            string[] FirstNames = { worker1.FirstName, worker2.FirstName, worker3.FirstName };
            worker1.Sort(FirstNames);
            Console.WriteLine("Введите, пожалуйста, стаж работника");
            int staj = Convert.ToInt32(Console.ReadLine());

            int[] YersOfWork = { 2019 - worker1.StartWork, 2019 - worker2.StartWork, 2019 - worker3.StartWork };

            worker1.Staj(YersOfWork, FirstNames, staj);
        }
    }
}
