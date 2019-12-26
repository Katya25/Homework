using System;
/*Определите класс футболиста, который содержит имя футболиста и его номер на поле. 
И определите класс футбольной команды, который хранит 11 футболистов в виде массива 
и обеспечивает доступ к этим футболистам через индексатор.*/
namespace Дз_18
{
    class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }

    }

    class FootballTeam
    {
        FootballPlayer[] data;

        public FootballPlayer this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public FootballTeam(int x)
        {
            data = new FootballPlayer[x];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FootballTeam player = new FootballTeam(5);
            player[0] = new FootballPlayer() { Name = "Messi", Number = 10 };
            Console.WriteLine(player[0].Number);
            Console.WriteLine(player[0].Name);
        }
    }
}
