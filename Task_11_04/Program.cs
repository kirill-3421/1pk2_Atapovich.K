namespace Task_11_04
{
    internal class Program
    {
        /*
         Массив параметров (params): Напишите метод, который принимает массив чисел и 
        возвращает их среднее значение. Используйте ключевое слово params 
         */

        static void Main(string[] args)
        {
            double resault = AverageValue(21, 14, 7, 5, 76);
            Console.WriteLine($"Среднее значение: {resault}.");
        }

        /// <summary>
        /// вычисляет среднее значение
        /// </summary>
        /// <returns>среднее значение</returns>
        static double AverageValue(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }

            double average = (double)sum / values.Length;
            return average;
        }
    }
}
