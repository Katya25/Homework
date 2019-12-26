using System;
/*2. Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода
void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись. */
namespace Дз_19_2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Видео воспроизводится");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Видео поставлено на паузу");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Видео выключено");
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Запись включена");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись поставлена на паузу");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Запись выключена");
        }

        public void Write(string str)
        {
            Player p = new Player();
            switch (str)
            {
                case "1":
                    ((IPlayable)p).Play();                    
                    break;
                case "2":
                    ((IPlayable)p).Pause();
                    break;
                case "3":
                    ((IPlayable)p).Stop();
                    break;
                case "4":
                    ((IRecodable)p).Record();
                    break;
                case "5":
                    ((IRecodable)p).Pause();
                    break;
                case "6":
                    ((IRecodable)p).Stop();
                    break;
                case "7":
                    Console.WriteLine("Компьютер выключен");
                    break;
                case "8":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1-IPlayable.Play     2-IPlayable.Pause     3-IPlayable.Stop    
            //4-IRecodable.Record       5-IRecodable.Pause      6-IRecodable.Stop 
            //7-              8-
            Player player = new Player();
            player.Write("1");
            player.Write("4");
            string str = "";
            do
            {
                Console.WriteLine("Что хотите сделать?(1-IPlayable.Play     2-IPlayable.Pause     3-IPlayable.Stop\n" +
                    "4-IRecodable.Record      5-IRecodable.Pause      6-IRecodable.Stop    7-выключить компьютер)");
                str = Console.ReadLine();
                player.Write(str);
            } while (str != "7");

        }
        
    }
}
