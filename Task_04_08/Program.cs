namespace Task_04_08
{
    internal class Program
    {
        /*
         * Дан массив, содержащий последовательность 50 случайных чисел. 
         * Найти количество пар элементов, значения  которых равны.
        */
        static void Main(string[] args)
        {
            //создание массива
            int[] array = new int[50];
            Random rand = new Random();

            // заполнение массива случайными числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 31);
            }

            // поиск равных пар чисел
            int pairOfCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        pairOfCount++;
                }
            }

            // вывод количества равных пар
            Console.WriteLine("Массив: " + string.Join(",", array));
            Console.WriteLine($"Количество равных пар: {pairOfCount}");
        }
    }
}
