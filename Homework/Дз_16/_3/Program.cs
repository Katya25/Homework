using System;
/*Создаем расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию*/
namespace _3
{
    public static class ExtForArray
    {
        public static void NewSort(this int[] array)
        {
            Array.Sort(array);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 98, 24, 6, 147, 0 };
            myArray.NewSort();
            foreach (var item in myArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
