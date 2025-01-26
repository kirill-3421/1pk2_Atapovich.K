using System;

namespace Task_04_07
{
    internal class Program
    {
        /*
         * В массиве на 30 элементов содержатся данные по росту учеников в классе.
         * Рост мальчиков - отрицательные значения. 
         * Вычислить и вывести количество мальчиков и девочек в классе 
         * Вывести средний рост для мальчиков и девочек. 
         * При выводе избавиться от отрицательных значений
        */

        static void Main(string[] args)
        {

            int[] heights = new int[30];
            Random random = new Random();

            for (int i = 0; i < heights.Length; i++)
            {
                if (random.Next(2) == 0) // 50% вероятность для мальчиков и девочек
                {
                    heights[i] = -random.Next(150, 201); // Рост мальчиков 
                }
                else
                {
                    heights[i] = random.Next(150, 201); // Рост девочек 
                }
            }

            int boysCount = 0, girlsCount = 0;
            int boysSum = 0, girlsSum = 0;

            // Подсчет количества детей  и суммы роста
            foreach (int height in heights)
            {
                if (height < 0) // Мальчики
                {
                    boysCount++;
                    boysSum += -height; // Избавляемся от отрицательных значений
                }
                else // Девочки
                {
                    girlsCount++;
                    girlsSum += height;
                }
            }

            // Вычисление среднего роста
            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            // Вывод информации
            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine("\n");
            Console.WriteLine($"Средний рост мальчиков: {boysAverage:F2}");
            Console.WriteLine($"Средний рост девочек: {girlsAverage:F2}");
            
        }
    }
}
  

