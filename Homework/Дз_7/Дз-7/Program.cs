using System;

namespace Дз_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Вывести на экран все элементы второй строки массива
            {
                Console.WriteLine("Task-1");
                Console.WriteLine("Дан массив:");
                int index1 = 10;
                int index2 = 10;
                int[,] arr = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(10, 100);
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Вывести на экран все элементы второй строки массива");
                for (int a = 0; a < index2; a++)
                {
                    Console.Write(arr[1, a] + ", ");
                }
                Console.WriteLine();
            }
            #endregion


            #region Task 2
            //С помощью генератора случайных значений создайте два массива. Выполните по 
            //отдельности сначала сложение, потом умножения массивов друг на друга. Выведете
            //исходные массивы и результат вычислений на экран
            {
                Console.WriteLine();
                Console.WriteLine("Task-2");
                Console.WriteLine("С помощью генератора случайных значений создайте два массива.\n" +
                    " Выполните по  отдельности сначала сложение, потом умножения массивов \n" +
                    "друг на друга. Выведете исходны массивы и результат вычислений на экран");
                int index1 = 5;
                int index2 = 5;
                int[,] arr1 = new int[index1, index2];
                Console.WriteLine("Первый массив:");
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr1[i, j] = new Random().Next(10, 100);
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Второй массив:");
                Console.WriteLine();
                int index11 = 5;
                int index12 = 5;
                int[,] arr2 = new int[index11, index12];
                for (int i = 0; i < index11; i++)
                {
                    for (int j = 0; j < index12; j++)
                    {
                        arr2[i, j] = new Random().Next(10, 100);
                        Console.Write(arr2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Сложение массивов:");
                for (int i = 0; i < index1 & i < index11; i++)
                {
                    for (int j = 0; j < index2 & i < index12; j++)
                    {
                        arr1[i, j] = arr1[i, j] + arr2[i, j];
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Перемножение массивов:");
                for (int i = 0; i < index1 & i < index11 ; i++)
                {
                    for (int j = 0; j < index2 & i < index12; j++)
                    {
                        arr1[i, j] = arr1[i, j] * arr2[i, j];
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }



                Console.WriteLine();
            }
            #endregion


            #region Task 3 
            //Выясните есть ли одинаковые числа в массиве или же массив содержит только разные
            {
                Console.WriteLine();
                Console.WriteLine("Task-3");
                Console.WriteLine("Выясните есть ли одинаковые числа в массиве или же массив" +
                    " содержит только разные");
                int index1 = 5;
                int index2 = 5;
                int[,] arr1 = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr1[i, j] = new Random().Next(10, 100);
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                
                for (int i = 0; i < index1; i++) 
                {               
                    for (int j = 0; j < index2; j++)
                    {
                        for (int k = 0; k < index1; k++)
                        {
                            for (int d = 0; d < index2; d++)
                            {
                                if(arr1[i, j] == arr1[k, d] & i != k & j != d)
                                {
                                        Console.WriteLine($"Есть одинаковые.И эти числа - {arr1[i, j]}." +
                                            $" Координаты ({i}, {j}) ");       
                                }
                            }
                        }
                    }
                }

                Console.WriteLine();
            }
            #endregion


            #region Task 4 
            //Сосчитайте количество различных чисел в массиве
            {
                Console.WriteLine("Task-4");
                Console.WriteLine("Сосчитайте количество различных чисел в массиве");
                int index1 = 3; //количество строк
                int index2 = 3; //количество столбцов
                int razn = 1;   // результат подсчета кол-ва разных чисел

                // Создание массива
                int[,] arr1 = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr1[i, j] = new Random().Next(1, 10);
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("массив создан" + "\t");
                // массив создан

                // текущая координата

                for (int i = 0; i < index1; i++) // перебираем строки
                {
                    for (int j = 0; j < index2; j++) // перебираем столбцы
                    {
                        int flag_sovpadeniy = 0; //обнуляем совпадения для текущей позиции 
                        if (i == 0 && j == 0) // переход из позиции 0,0 в 0,1 (в 0,0 сравнивать несчем)
                        {
                            j++; ;
                        }
                        // сравниваем с предыдущими значениями
                        int k = 0;
                        if (k < i) // цикл для перебора ВСЕХ значений из предыдущих строк
                        {
                            for (k = 0; k < i; k++) // перебор номеров строк
                            {
                                for (int c = 0; c < index2; c++) // перебор ВСЕХ номеров столбцов в строке
                                {
                                    if (arr1[i, j] == arr1[k, c])
                                    {
                                        flag_sovpadeniy++;

                                    }
                                }
                            }
                        }
                        else    // для текущей строки i сравниваем только с предыдущими позициями
                        {
                            for (int c = 0; c < j; c++)
                            {
                                if (arr1[i, j] == arr1[i, c]) // при совпадении flag_sovpadeniy увеличиваем на 1
                                {
                                    flag_sovpadeniy++;
                                }
                            }
                        }
                        if (flag_sovpadeniy == 0)
                        {
                            razn++;
                        }
                    }
                }
                Console.WriteLine("Результат=" + razn + "\t");
                Console.WriteLine();

            }
            #endregion


            #region Task 5 
            //Определите количество столбцов и количество строк массива, в которых не содержится
            //ни одного отрицательного элемента.Выведите на экран найденные значения
            {
                Console.WriteLine();
                Console.WriteLine("Task-5");
                Console.WriteLine("Определите количество столбцов и количество строк массива,\n " +
                    "в которых не содержится ни одного отрицательного элемента.Выведите\n " +
                    " на экран найденные значения");
                int index1 = 5; // к-во строк
                int index2 = 5; // к-во столбцов
                int ne_otric1 = 0;
                int ne_otric2 = 0;

                // создание массива
                int[,] arr1 = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr1[i, j] = new Random().Next(-2, 9);
                        Console.Write(arr1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                //находит неотрицательные строки
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        if (arr1[i, j] < 0) break;
                        else
                        {
                            if (j == index2 - 1) ne_otric1++;
                        }
                    }
                }
                Console.WriteLine("неотрицательных строк " + ne_otric1);

                //находит неотрицательные столбцы
                for (int j = 0; j < index2; j++)
                {
                    for (int i = 0; i < index1; i++)
                    {
                        if (arr1[i, j] < 0) break;
                        else
                        {
                            if (i == index1 - 1) ne_otric2++;
                        }
                    }
                }
                Console.WriteLine("неотрицательных столбцов " + ne_otric2);


            }
            #endregion


            #region Task 6 
            //Отсортируйте столбцы массива в порядке возрастания сумм их элементов
            {
                Console.WriteLine("Task-6");
                Console.WriteLine("Отсортируйте столбцы массива в порядке возрастания сумм их элементов");
                Console.WriteLine("Дан массив:");
                {
                    int index1 = 3;
                    int index2 = 10;
                    int[,] arr = new int[index1, index2];
                    for (int i = 0; i < index1; i++)
                    {
                        for (int j = 0; j < index2; j++)
                        {
                            arr[i, j] = new Random().Next(1, 10);
                            Console.Write(arr[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int n = 0; n < index1; n++)
                    {
                        for (int j = 1; j < index2; j++)
                        {
                            int sumPrevStolbca = 0; // сумма предыдущего столбца
                            for (int i = 0; i < index1; i++)
                            {
                                sumPrevStolbca += arr[i, j - 1];
                            }

                            int sumTekushStolbca = 0;       // сумма текущего столбца
                            for (int i = 0; i < index1; i++)
                            {
                                sumTekushStolbca += arr[i, j];
                            }

                            if (sumPrevStolbca > sumTekushStolbca)
                            {
                                for (int k = 0; k < index1; k++)
                                {
                                    int temp = arr[k, j];
                                    arr[k, j] = arr[k, j - 1];
                                    arr[k, j - 1] = temp;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < index1; i++)
                    {
                        for (int j = 0; j < index2; j++)
                        {
                            Console.Write(arr[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
            }
            #endregion


            #region Task 7 
                //Просуммируйте все элементы двумерного массива
                {
                Console.WriteLine("Task-7");
                Console.WriteLine("Просуммируйте все элементы двумерного массива");
                int index1 = 10;
                int index2 = 10;
                int sum = 0;
                int[,] arr = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(10, 100);
                        Console.Write(arr[i, j] + "\t");
                        sum += arr[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Сумма всех єлементов массива: ");
                Console.WriteLine(sum);
                Console.WriteLine();
            }
            #endregion


            #region Task 8
            //Заполните главные диагонали массива нулями
            {
                Console.WriteLine("Task-8");
                Console.WriteLine("Заполните главные диагонали массива нулями");
                int index1 = 9;
                int index2 = 9;
                int[,] arr = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(10, 100);
                        if (i == j | i + j == index1 - 1)
                        {
                            arr[i, j] = 0;
                        }
                        Console.Write(arr[i, j] + "\t");
                      
                    }
                    Console.WriteLine();
                }    
                Console.WriteLine();
            }
            #endregion


            #region Task 9  
            //Выведете на экран номера тех ячеек массива, в которых находятся отрицательные числа
            {
                Console.WriteLine("Task-9");
                Console.WriteLine("Выведете на экран номера тех ячеек массива, в которых находятся\n " +
                    "отрицательные числа");
                int index1 = 5;
                int index2 = 5;
                int[,] arr = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(-9, 10);
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Координаты отрицательных чисел:");
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        if (arr[i, j] < 0)
                        {
                            Console.WriteLine($"Строка {i + 1}, столбик {j + 1};");
                        }

                    }
                    
                }

                Console.WriteLine();
            }
            #endregion


            #region Task 10 
            //Поменять максимальный и минимальный элемент массива местами
            {
                Console.WriteLine("Task-10");
                Console.WriteLine("Поменять максимальный и минимальный элемент массива местами");
                int index1 = 5;
                int index2 = 5;
                int[,] arr = new int[index1, index2];
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(10, 100);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                int minI = 0, minJ = 0, maxI = 0, maxJ = 0;
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        if (arr[minI, minJ] > arr[i, j])
                        {
                            minI = i;
                            minJ = j;
                        }
                        if (arr[maxI, maxJ] < arr[i, j])
                        {
                            maxI = i;
                            maxJ = j;
                        }
                    }
                }

                Console.WriteLine($"Минимальный: {arr[minI, minJ]}");
                Console.WriteLine($"Makсимальный: {arr[maxI, maxJ]}");

                int tmp = arr[maxI, maxJ];
                arr[maxI, maxJ] = arr[minI, minJ];
                arr[minI, minJ] = tmp;

                Console.WriteLine();
                Console.WriteLine("Новый массив:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


            }
            #endregion


            #region Task 11
            //*Пользователь вводит число. Определить сумму всех элементов массива, 
            //которые больше заданного пользователем числа, если такое есть
            {
                Console.WriteLine();
                Console.WriteLine("Task-11");
                Console.WriteLine("*Пользователь вводит число. Определить сумму всех элементов массива,\n " +
                    "которые больше заданного пользователем числа, если такое есть");
                Console.WriteLine();
               
                int index1 = 5;
                int index2 = 5;
                int[,] arr = new int[index1, index2];
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        arr[i, j] = new Random().Next(1, 10);
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.Write("Введите число:");
                int a = Convert.ToInt32(Console.ReadLine());

                int sum = 0;
                for (int i = 0; i < index1; i++)
                {
                    for (int j = 0; j < index2; j++)
                    {
                        if (arr[i, j] > a)
                        {
                            sum += arr[i, j];
                        }
                    }
                }
                Console.WriteLine($"Сумма всех єлементов массива, больших числа {a} = {sum}");
                Console.WriteLine();

            }
            #endregion  
        }
    }
}
