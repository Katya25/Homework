using System;
using System.IO;
using System.Threading.Tasks;
/*Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге.
При вызове метода, производится поиск строки в книге. (Книга любая, подгружаем с помощью Filesteam).*/

namespace _2
{
   

    public static class FindAndReplaceManager
    {
        public static void FindNext(this string str1, string str2)
        {
            bool b = str1.Contains(str2);
            if(b)
            Console.WriteLine("Есть такая подстрока");
            else Console.WriteLine("Нет такой подстроки");
        }
    }

    class Program
    {
        static void Main(string[] args)
  
        {
            string str1 = "Ненавижу школу";
            Console.WriteLine("Какую строку хотите найти?");
            string str2 = Console.ReadLine();


            str1.FindNext(str2);
            
        }
    }
}


