using System;

namespace Дз_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*Найдите индексы первого вхождения максимального элемента. Выведите два числа:
            номер строки и номер столбца, в которых стоит наибольший элемент в двумерном
            массиве. Если таких элементов несколько, то выводится тот, у которого меньше 
            номер строки, а если номера строк равны то тот, у которого меньше номер столбца.*/
            {
                Console.WriteLine("Task-1");
                Console.WriteLine("Найдите индексы первого вхождения максимального элемента. Выведите два числа: \n" +
                    "номер строки и номер столбца, в которых стоит наибольший элемент в двумерном \n" +
                    "массиве.Если таких элементов несколько, то выводится тот, у которого меньше \n" +
                    "номер строки, а если номера строк равны то тот, у которого меньше номер столбца.\n");
                int index1 = 10;
                int index2 = 10;
                int[,] arr1 = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr1[i, j] = new Random().Next(1, 5);
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int max = arr1[0, 0];
                string coords = string.Empty;
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        if (max < arr1[i, j])
                        {
                            max = arr1[i, j];
                            coords = string.Format($"Coords max element: {i + 1}, {j + 1}");
                        }
                    }
                }
                Console.WriteLine($"Max element: {max}");
                Console.WriteLine(coords);
            }

            #endregion



            #region Task-2
            /*Дано нечетное число n. Создайте двумерный массив из n x n элементов, заполнив
            его символами "."(каждый элемент массива является строкой из одного символа).
            Затем заполните символами "*" среднюю строку массива, средний столбец массива, 
            главную диагональ и побочную диагональ.В результате единицы в массиве должны
            образовывать изображение звездочки.Выведите полученный массив на экран, разделяя
            элементы массива пробелами.*/
            {
                Console.WriteLine("Task-2");
                Console.WriteLine("Дано нечетное число n. Создайте двумерный массив из n x n элементов, заполнив\n" +
                    "его символами '.'(каждый элемент массива является строкой из одного символа). \n" +
                    "Затем заполните символами '*'среднюю строку массива, средний столбец массива, \n" +
                    "главную диагональ и побочную диагональ.В результате единицы в массиве должны \n5" +
                    "образовывать изображение звездочки.Выведите полученный массив на экран, разделяя \n" +
                    "элементы массива пробелами.");
                int index1 = 9; 
                int index2 = 9;
                char[,] arr = new char[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = '.';
                        if (i == j | i + j == index1 - 1 | j == index2 / 2 | i == index1 / 2)
                        {
                            arr[i, j] = '*';
                        }
                        Console.Write(arr[i, j] + " ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion






            #region Task-3
            /*Дан квадратный массив.Поменяйте местами элементы, стоящие на главной и побочной
            диагонали, при этом каждый элемент должен остаться в том же столбце(то есть в
            каждом столбце нужно поменять местами элемент на главной диагонали и на побочной 
            диагонали).*/
            {
                Console.WriteLine();
                Console.WriteLine("Task-3");
                Console.WriteLine("Дан квадратный массив.Поменяйте местами элементы, стоящие на главной и побочной\n" +
                    "диагонали, при этом каждый элемент должен остаться в том же столбце(то есть в \n" +
                    "каждом столбце нужно поменять местами элемент на главной диагонали и на побочной \n" +
                    "диагонали).");
                int index1 = 5;
                int index2 = 5;
                int i = 0, j = 0, k = index1 - 1;
                int tmp;
                int[,] arr = new int[index1, index2];
                for (int a = 0; a < index1; a++)
                {
                    for (int b = 0; b < index2; b++)
                    {
                        arr[a, b] = new Random().Next(10, 100);
                        Console.Write(arr[a, b] + " ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
               

                while (i < 5)
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = tmp;
                    i++; j++; k--;
                }

                for (int z = 0; z < index1; z++)
                {
                    for (int l = 0; l < index1; l++)
                    {
                        Console.Write(arr[z, l] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion




            #region Task-4
            /*Дан прямоугольный массив размером n x m.Поверните его на 90 градусов по часовой
            стрелке, записав результат в новый массив размером m x n.*/
            {
                Console.WriteLine();
                Console.WriteLine("Task-4");
                Console.WriteLine("Дан прямоугольный массив размером n x m.Поверните его на 90\n " +
                    "градусов по часовой стрелке, записав результат в новый массив размером" +
                    " m x n.");
                int index1 = 6;
                int index2 = 5;
               
                int[,] array = new int[index1, index2];
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
            #endregion
        }
    }
}
