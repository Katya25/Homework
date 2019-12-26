using System;
using System.Collections.Generic;

namespace Дз_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 4
            {
                ////Дано предложение. Определить, сколько в нем одинаковых пар соседних букв.​


                Console.WriteLine("Дано предложение. Определить, сколько в нем одинаковых пар соседних букв");
                string text1 = "мама папа тетя дядя";
                string text = text1.ToUpper();
                Console.WriteLine();
                Console.WriteLine("TASK 4");
                int couples = 0;
                char[] temp = text.ToCharArray();

                List<char> chars = new List<char>();

                for (int i = 0; i < text.Length; i++) //записываю в лист только буквы
                {
                    if (temp[i] != '.' & temp[i] != ',' & temp[i] != ' ')
                    {
                        chars.Add(temp[i]);
                    }
                }

                for (int i = 0; i <= chars.Count - 2; i += 2)
                {
                    Console.WriteLine(chars[i] + "" + chars[i + 1]);
                }




                for (int i = 0; i <= chars.Count - 2; i += 2)
                {

                    for (int j = 0; j < i; j++)
                    {
                        if (chars[i] == chars[j] & chars[i + 1] == chars[j + 1])
                        {
                            couples++;
                        }
                    }

                }
                Console.WriteLine();
                Console.WriteLine(couples);

            }
            #endregion

            #region Task 1
            {
                //Составить программу обмена значениями трех переменных величин а, b, c строкового типа           
                //по следующей схеме: а) b присвоить значение c, а присвоить значение b, c присвоить 
                //значение а; б) b присвоить значение а, с присвоить значение b, а присвоить значение c​

                Console.WriteLine();
                Console.WriteLine("TASK 1");
                string stra = "XD";
                string strb = "LOL";
                string strc = "OMG";
                Console.WriteLine($"Изначально а = {stra}, b = {strb}, и c = {strc}");

                string tempa = stra;
                string tempb = strb;
                string tempc = strc;

                Console.WriteLine("а) b присвоить значение c, а присвоить значение b, c присвоить значение а:");
                strb = strc;
                stra = tempb;
                strc = tempa;
                Console.WriteLine($"Теперь а = {stra}, b = {strb}, и c = {strc}");

                Console.WriteLine("б) b присвоить значение а, с присвоить значение b, а присвоить значение c:");
                strb = stra;
                stra = tempc;
                strc = tempb;
                Console.WriteLine($"Теперь а = {stra}, b = {strb}, и c = {strc}");
                

            }
            #endregion

            #region Task 2
            {
                //Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же букву?​

                Console.WriteLine();
                Console.WriteLine("TASK 2");
                Console.WriteLine("Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же букву​");
                Console.WriteLine("Напишите слово: ");
                string word = Console.ReadLine();
                var answer = word[0].Equals(word[word.Length - 1]);
                if(answer == true)
                    Console.WriteLine("Верно");
                else
                    Console.WriteLine("Не верно");
                
            }
            #endregion

            #region Task 3
            {
                //Даны два слова.Верно ли, что первое слово начинается на ту же букву, на которую 
                //заканчивается второе слово ? ​

                Console.WriteLine();
                Console.WriteLine("TASK 3");
                Console.WriteLine("Даны два слова. Верно ли, что первое слово начинается на ту же букву, \n" +
                    "на которую заканчивается второе слово?");
                Console.WriteLine("Напишите первое слово: ");
                string word1 = Console.ReadLine();
                Console.WriteLine("Напишите второе слово: ");
                string word2 = Console.ReadLine();
                var answer = word1[0].Equals(word2[word2.Length - 1]);
                if (answer == true)
                    Console.WriteLine("Верно");
                else
                    Console.WriteLine("Не верно");
                
            }
            #endregion

          

            #region Task 5
            {
                //Дан текст. Определить, сколько в нем предложений. ​

                Console.WriteLine();
                Console.WriteLine("TASK 5");
                Console.WriteLine("Дан текст. Определить, сколько в нем предложений");
                string text = "Ночь. Тусклый свет фанарей. Поворот. За ним еще один. Осталось всего\n " +
                    "каких-то 30 метров. И вот, наконец-то, он у цели. Осталось лишь протянуть руку,\n но " +
                    "хриплый голос окликнул его";
                Console.WriteLine(text);
                string[] sentences = text.Split('.');
                int counter = sentences.Length;
                Console.WriteLine($"В этом тексте {counter} предложений");
                
            }
            #endregion

            #region Task 6
            {
                //Дано предложение, в котором имеются одна буква с и одна буква Т.Определить, какая из них 
                //встречается раньше(при просмотре слова слева направо)​

                Console.WriteLine();
                Console.WriteLine("TASK 6");
                Console.WriteLine("Дано предложение, в котором имеются одна буква с и одна буква Т.Определить, какая из них \n" +
                    "встречается раньше(при просмотре слова слева направо)​");
                string text = "Это было сегодня";
                int c = text.IndexOf('с');
                int t = text.IndexOf('т');
                if(c > t)
                {
                    Console.WriteLine("Буква \"т\" раньше");
                }
                else
                {
                    Console.WriteLine("Буква \"с\" раньше");
                }
                
            }
            #endregion

            #region Task 7
            {
                //Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т.д.местах, 
                //заменить буквой а. ​

                Console.WriteLine();
                Console.WriteLine("TASK 7");
                Console.WriteLine("Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т.д.местах, \n" +
                    "заменить буквой а​");
                string text = "Он зашел в комнату";
                char[] temp = text.ToCharArray();
                
                for (int i = 3; i < temp.Length; i += 3)
                {
                    temp[i] = 'a';
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i]);
                }
                Console.WriteLine();
                

            }
            #endregion

            #region Task 8
            {
                //Дано слово. Поменять местами его вторую и пятую буквы. 

                Console.WriteLine();
                Console.WriteLine("TASK 8");
                Console.WriteLine("Дано слово. Поменять местами его вторую и пятую буквы");
                string text = "слово";
                Console.WriteLine("Then: " + text);
                char[] arr = text.ToCharArray();
                var temp = arr[1];
                arr[1] = arr[4];
                arr[4] = temp;
                text = new string(arr);
                Console.WriteLine("Now: " + text);
                
            }
            #endregion

            #region Task 9
            {
                //Дан текст. Найти сумму всех имеющихся в нем чисел.​

                Console.WriteLine();
                Console.WriteLine("TASK 9");
                Console.WriteLine("Дан текст. Найти сумму всех имеющихся в нем чисел");
                string text = "2hjj4id90";
                Console.WriteLine("Text: " + text);
                char[] temp = text.ToCharArray();
                int sum = 0;
                

                for (int i = 0; i < temp.Length; i++)
                {
                    if (Char.IsDigit(temp[i]))
                    {
                        sum += int.Parse(text[i].ToString());
                       
                    }
                }
                Console.WriteLine("Sum is " + sum);
            }
            #endregion

            #region Task 10
            {
                //*Дано натуральное число n(n  1000).Напечатать это число русскими словами(тринадцать,
                //сто пять, двести сорок один, тысяча и т.д.). ​
                Console.WriteLine("TASK 10");

                string[] nums_1_9 = "ноль один два три четыре пять шесть семь восемь девять".Split();
                string[] nums_10_19 = "десять одиннадцать двенадцать тринадцать четырнадцать пятнадцать шестнадцать семнадцать восемнадцать девятнадцать".Split();
                string[] nums_20_90 = "ноль десять двадцать тридцать сорок пятьдесят шестьдесят семьдесят восемьдесят девяносто".Split();
                string[] nums_100_900 = "ноль сто двести триста четыреста пятьсот шестьсот семьсот восемьсот девятьсот".Split();

                Console.WriteLine("введите число от 0 до 1000");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 10)                                //5
                {
                    Console.WriteLine(nums_1_9[number]);
                }
                if (number < 20 & number >= 10)                  //15
                {
                    Console.WriteLine(nums_10_19[number - 10]);
                }
                if (number < 100 & number >= 20)
                {
                    int _10 = number / 10;
                    int _1 = number % 10;
                    if (_1 != 0)                                   //55
                        Console.WriteLine(nums_20_90[_10] + " " + nums_1_9[_1]);
                    else if (_1 == 0 & _10 != 0)                  //50
                        Console.WriteLine(nums_20_90[_10]);
                }
                if (number < 1000 & number >= 100)
                {
                    int _100 = number / 100;
                    int _10_20 = number % 100;
                    int _10 = number % 100 / 10;
                    int _1 = number % 100 % 10;
                    if (_10_20 >= 10 & _10_20 < 20)                  //517
                        Console.WriteLine(nums_100_900[_100] + " " + nums_10_19[_10_20 - 10]);
                    else if (_10_20 == 0)                            //500
                        Console.WriteLine(nums_100_900[_100]);
                    else if (_1 == 0 & _10 != 0)                     //560
                        Console.WriteLine(nums_100_900[_100] + " " + nums_20_90[_10]);
                    else if (_10 == 0 & _1 != 0)                      //507
                        Console.WriteLine(nums_100_900[_100] + " " + nums_1_9[_1]);
                    else if (_1 != 0 & _10 != 0)                     //555
                        Console.WriteLine(nums_100_900[_100] + " " + nums_20_90[_10] + " " + nums_1_9[_1]);
                }

            }
            #endregion

        }
    }
}
