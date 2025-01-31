using System;

namespace Task_05_07
{
    internal class Program
    {
        /*
         *  У пользователя в консоли запрашивается число n, 
         *  генерируется квадратный массив целых числе [n*n]. 
         *  Заполнение случайными числами в диапазоне от 10 до 99 включительно. 
         * Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом)
         * Осуществить умножение матрицы на ее минимальный элемент, 
         * при выводе цветом выделить пять максимальных значений в массиве 
         */

        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

                // Создание массива и его заполнение
            int[,] arrey = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrey[i, j] = rand.Next(10, 100);
                }
            }

            // Поиск минимального элемента
            int minCount = arrey[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arrey[i, j] < minCount)
                    {
                        minCount = arrey[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в матрице: {minCount}");
            Console.WriteLine("\n");

            // Умножение матрицы на минимальный элемент
            int[,] resultArrey = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultArrey[i, j] = arrey[i, j] * minCount;
                }
            }

            // Поиск пяти максимальных значений
            int[] maxMeaning = new int[5];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = resultArrey[i, j];
                    for (int k = 0; k < maxMeaning.Length; k++)
                    {
                        if (value > maxMeaning[k])
                        {
                            for (int m = maxMeaning.Length - 1; m > k; m--)
                            {
                                maxMeaning[m] = maxMeaning[m - 1];
                            }
                            maxMeaning[k] = value;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Произведение матрицы на её минимальное значение:");
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isMaxMeaning = false;
                    foreach (int max in maxMeaning)
                    {
                        if (resultArrey[i, j] == max)
                        {
                            isMaxMeaning = true;
                            break;
                        }
                    }

                    if (isMaxMeaning)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow; 
                        Console.Write(resultArrey[i, j] + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(resultArrey[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
    

