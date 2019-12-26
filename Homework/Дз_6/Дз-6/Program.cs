using System;

namespace Дз_6
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int size = 20;
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    int randomNumber = new Random().Next(0, 21);
                    arr[i] = randomNumber;
                    for (int j = 0; j < i; j++)
                    {
                        while (arr[j] == arr[i])
                        {
                            arr[i] = randomNumber;
                        }
                    }
                }
                foreach (int i in arr)
                {
                    Console.Write(i + ", ");
                }
            }



            #region Task 1
            //Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе 
            //выполнения программы.
            {
                Console.WriteLine("Task-1");
                Console.WriteLine("Заполнить массив из десяти элементов значениями, вводимыми \n" +
                    "с клавиатуры в ходе выполнения программы.(10 чисел слишком долго вводить,\n " +
                    "так что пусть будет 2");
                int size = 2;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Введите число: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Вы ввели следующие числа: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
            }
           
            #endregion





            #region Task 2
            //Заполнить массив из пятнадцати элементов случайным образом: а) вещественными 
            //значениями, лежащими в диапазоне от 0 до 1; б) вещественными значениями х(22 х < 23);
            //в) вещественными значениями х(0 х < 10); г) вещественными значениями х(–50 х < 50); 
            //д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.
            {
                Console.WriteLine();
                Console.WriteLine("Task-2");
                Console.WriteLine("Заполнить массив из пятнадцати элементов случайным образом:");
                Console.WriteLine("а) вещественными значениями, лежащими в диапазоне от 0 до 1");
                int size = 15;
                double[] arr = new double[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().NextDouble();
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("вещественными значениями х(22 < х < 23)");
                int size = 15;
                double[] arr = new double[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    Random x = new Random();
                    arr[i] = Convert.ToDouble(x.Next(220, 231) / 10.0);

                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();

            }

            {
                Console.WriteLine("в) вещественными значениями х(0 х < 10)");
                int size = 15;
                double[] arr = new double[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    Random x = new Random();
                    arr[i] = Convert.ToDouble(x.Next(0, 100) / 10.0);

                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("г) вещественными значениями х(–50 < х < 50)");
                int size = 15;
                double[] arr = new double[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    Random x = new Random();
                    arr[i] = Convert.ToDouble(x.Next(-500, 501) / 10.0);

                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно");
                int size = 15;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(0, 11);
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
            }
            #endregion






            #region Task 3 
            //Используя датчик случайных чисел, заполнить массив из двадцати элементов
            //неповторяющимися числами.
            {
                Console.WriteLine();
                Console.WriteLine("Task-3");
                Console.WriteLine("Используя датчик случайных чисел, заполнить массив \n" +
                    " из двадцати элементов неповторяющимися числами.");


                int size = 20;
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    int randomNumber = new Random().Next(0, 21);
                    arr[i] = randomNumber;
                    //for (int j = 0; j < i; j++)
                    //{
                        while(arr[i - 1] == arr[i])
                        {
                            arr[i] = randomNumber;
                        }
                    //}
                }
                foreach (int i in arr)
                {
                    Console.Write(i + ", ");
                }

                //    List<int> arr = new List<int>();
                //Random rnd = new Random((new Random()).Next());
                //for (int i = 0; i < 10; i++)
                //{
                //    int j = rnd.Next(1, 20); // тут получаем случайное значение
                //    while (arr.Contains(j)) j = rnd.Next(1, 20); // тут проверяем
                //    arr.Add(j); // тут сохраняем/запоминаем
                //}

                    //foreach (int i in arr) Console.Write(i.ToString() + " | ");
                    //Console.WriteLine();






                    //Console.WriteLine("не получается");
                    //int size = 20;
                    //int[] arr = new int[size];

                    //for (int i = 0; i < arr.Length; i++)
                    //{
                    //    int randomNumber = new Random().Next(0, 21);
                    //    arr[i] = randomNumber;
                    //    for (int j = 0; j < i; j++)
                    //    {
                    //        if (arr[i] == arr[j])
                    //        {
                    //            do
                    //            {
                    //                arr[i] = new Random().Next(0, 21);
                    //            } while (arr[i] == arr[j]);
                    //        }
                    //    }

                    //    Console.WriteLine(arr[i] + ", ");
                    //}

            }
            #endregion





            #region Task 4
            //Дан массив. Все его элементы: а) увеличить в 2 раза; б) уменьшить на число А;
            //в) разделить на первый элемент.
            {
                Console.WriteLine();
                Console.WriteLine("Task-4");
                Console.WriteLine("");
                int size = 5;
                int[] arr = new int[size];
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    int randomNumber = new Random().Next(0, 50);
                    arr[i] = randomNumber;
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine("Все его элементы:");
                int b = arr[0];
                Console.WriteLine("а) увеличить в 2 раза;");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * 2;
                    Console.Write(arr[i] + ", ");
                }


                int A = new Random().Next(5, 11);
                Console.WriteLine($"уменьшить на число {A}");
               
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] / 2 - A;
                    Console.Write(arr[i] + ", ");
                }
                
                Console.WriteLine("в) разделить на первый элемент");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i]  + A;
                    arr[i] = arr[i] / b;
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
            }
            #endregion







            #region Task 5
            //В массиве хранятся сведения о стоимости 12 различных предметов. Определить
            //общую стоимость всех предметов.
            {
                Console.WriteLine();
                Console.WriteLine("Task-5");
                Console.WriteLine("Стоимость 12 предметов:");
                int size = 12;
                int sum = 0;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {

                    arr[i] = new Random().Next(5, 1000);
                    sum += arr[i];
                    Console.Write(arr[i]  + ", ");
                }
                Console.WriteLine(" Определить общую стоимость всех предметов");
                Console.WriteLine($"Сумма = {sum}");
                Console.WriteLine();
            }
            #endregion




            #region Task 6
            //Дан массив целых чисел. Выяснить: 
            //а) верно ли, что сумма элементов массива есть четное число; 
            //б) верно ли, что сумма квадратов элементов массива есть пятизначное число.
            {
                Console.WriteLine();
                Console.WriteLine("Task-6");
                Console.WriteLine("Дан массив целых чисел. Выяснить:");
                int size = 10;
                int sum = 0;
                int kvadrat = 0;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {

                    arr[i] = new Random().Next(1, 100);
                    sum += arr[i];
                    int a = arr[i] * arr[i];
                    kvadrat += a;
                } 
                Console.WriteLine("а) верно ли, что сумма элементов массива есть четное число");
                if(sum % 2 == 0)
                {
                    Console.WriteLine("Сумма является четным числом");
                }
                else
                {
                    Console.WriteLine("Сумма нечетная");
                }

                Console.WriteLine("б) верно ли, что сумма квадратов элементов массива есть пятизначное число");
                if(kvadrat / 10000 > 0)
                {
                    Console.WriteLine($"Сумма квадратов = {kvadrat} и является пятизначным числом");
                }
                else
                {
                    Console.WriteLine($"Сумма квадратов = {kvadrat} и не является пятизначным числом");
                }
                Console.WriteLine();
            }
            #endregion




            #region Task 7
            //Дан массив. Напечатать: а) все неотрицательные элементы; 
            //б) все элементы, не превышающие число 100.
            {
                Console.WriteLine();
                Console.WriteLine("Task-7");
                Console.WriteLine("Дан массив. Напечатать:");
                int size = 10;
                int[] arr = new int[size];
                Console.WriteLine("a) Неотрицательные числа: ");
                for (int i = 0; i < arr.Length; i++)
                {    
                    arr[i] = new Random().Next(-1000, 1000);
                    if(arr[i] >= 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine("б) Все элементы, не превышающие 100, это: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-1000, 1000);
                    if (arr[i] < 100)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
            }
            #endregion






            #region Task 8
            //Дан массив целых чисел. Напечатать: а) все четные элементы; 
            //б) все элементы, оканчивающиеся нулем.
            {
                Console.WriteLine();
                Console.WriteLine("Task-8");
                Console.WriteLine("Дан массив целых чисел. Напечатать:");
                int size = 10;
                int[] arr = new int[size];
                Console.WriteLine("a) Четные числа: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 100);
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine("Все элементы, оканчивающиеся нулем: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 10 == 0)                              //Числа, оканчивающиеся на ноль,
                    {                                                  // делятся на 10
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
            }
            #endregion






            #region Task 9
            //Дан массив. Вывести на экран сначала его неотрицательные элементы, 
            //затем отрицательные.
            {
                Console.WriteLine();
                Console.WriteLine("Task-9");
                Console.WriteLine("Дан массив. Вывести на экран сначала его неотрицательные\n" +
                    " элементы, затем отрицательные.");
                int size = 10;
                int[] arr = new int[size];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    if (arr[i] >=0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
            }
            #endregion







            #region Task 10
            //Дан массив. Вывести на экран сначала его элементы, стоящие на четных местах, 
            //затем — на нечетных.
            {
                Console.WriteLine();
                Console.WriteLine("Task-10");
                Console.WriteLine("Дан массив:");
                int size = 10;
                int[] arr = new int[size];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.Write($"{i}){arr[i]}    ");
                }
                Console.WriteLine();
                Console.WriteLine("На четных местах:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("На нечетных местах:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                }
                Console.WriteLine();
            }
            #endregion







            #region Task 11
            //Дан массив. Найти: а) сумму элементов массива, значение которых не превышает 20;
            //б) сумму элементов массива, больших числа a.
            {
                Console.WriteLine();
                Console.WriteLine("Task-11");
                Console.WriteLine("Дан массив:");
                int size = 10;
                int sum = 0;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(5, 100);
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine("Найти:");
                Console.WriteLine("а) сумму элементов массива, значение которых не превышает 20");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 20)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine($" {sum}");

                Console.WriteLine();
                Console.WriteLine("б) сумму элементов массива, больших числа a");
                int a = new Random().Next(20, 50);
                Console.WriteLine($"Число а = {a}");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > a)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine($"И эта сумма = {sum}");
                Console.WriteLine();
            }
            #endregion






            #region Task 12
            //Дан массив целых чисел. Найти: а) сумму нечетных элементов; 
            //б) сумму элементов, кратных заданному числу; в) сумму элементов массива, кратных a или b.
            {
                Console.WriteLine();
                Console.WriteLine("Task-12");
                Console.WriteLine("Дан массив целых чисел:");
                int size = 10;
                int sum = 0;
                int sum2 = 0;
                int sum3 = 0;
                int[] arr = new int[size];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(1, 100);
                    Console.Write($"{i}){arr[i]}    ");
                }
                Console.WriteLine();
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма нечетных элементов = {sum}");
                int a = new Random().Next(1, 10);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % a == 0)
                    {
                        sum2 += arr[i];
                    }
                }
                Console.WriteLine($"Сумма чисел, кратных числу {a} = {sum2}");
                Console.WriteLine();
                int b = new Random().Next(1, 10);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % a == 0 | arr[i] % b == 0)
                    {
                        sum3 += arr[i];
                    }
                }
                Console.WriteLine($"Сумма чисел, кратных числу {a} или {b} {sum3}");
            }
            Console.WriteLine();
            #endregion








            #region Task 13
            //Определить сумму второго, четвертого, шестого и т.д.элементов массива.
            {
                Console.WriteLine();
                Console.WriteLine("Task-13");
                Console.WriteLine("Определить сумму второго, четвертого, шестого и т.д.элементов массива");
                int size = 10;
                int sum = 0;
                int[] arr = new int[size];
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.Write($"{i}){arr[i]}    ");
                }
                Console.WriteLine();
               
                for (int i = 1; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += arr[i];
                    }
                }
                Console.WriteLine($"Сумма чисел на четных местах = {sum}");
            }
            #endregion







            #region Task 14
            //Дан массив. Определить количество неотрицательных элементов.
            {
                Console.WriteLine();
                Console.WriteLine("Task-14");
                Console.WriteLine("Дан массив:");
                int size = 10;
                int kolichestvo = 0;
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-100, 100);
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] >= 0)
                    {
                        kolichestvo++;
                    }
                }
                Console.WriteLine($"Количество неотрицательных элементов массива = {kolichestvo}");
            }
            #endregion







            #region Task 15
            //Рост каждого из 22 учеников класса представлен в виде массива. Определить 
            //количество учеников, рост которых не превышает значения r.
            {
                Console.WriteLine();
                Console.WriteLine("Task-15");
                Console.WriteLine("Рост 22 учеников класа:");
                int size = 22;
                int kolichestvo = 0;
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(150, 180);
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
                int r = new Random().Next(160, 170);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] <= r)
                    {
                        kolichestvo++;
                    }
                }
                Console.WriteLine($"Количество учеников, чей рост не привышает {r}см = {kolichestvo}");
            }
            #endregion



        }
    }
}
