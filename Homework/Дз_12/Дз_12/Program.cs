using System;

/*Преобразовать строки двумерного массива в столбцы. Например было: 
11	22
33	44
55	66
77	88
стало:
11	33	55	77
22	44	66	88

Класс будет содержать два метода: один заполнит массив значениями, второй произведет замену значений строк на значения
столбцов.*/


namespace Дз_12
{
    class Matrix
    {
        public int index1;
        public int index2;
        public int[,] array;

        public Matrix(int index1, int index2, int[,] array)
        {
            this.index1 = index1;
            this.index2 = index2;
            this.array = array;
        }

        public int[,] Write()
        {
            for (int a = 0; a < index1; a++)
            {
                for (int b = 0; b < index2; b++)
                {
                    array[a, b] = new Random().Next(10, 100);
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return array;
        }


        public void Change()
        {
            int[,] array2 = new int[index2, index1];
            for (int k = 0; k < index2; k++)
            {
                for (int c = 0; c < index1; c++)
                {
                    array2[k, c] = array[index1 - c - 1, k];
                    Console.Write(array2[k, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int index1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            int index2 = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[index1, index2];

            Matrix matrix = new Matrix(index1, index2, array);

            matrix.Write();
            matrix.Change();

        }
    }
}
