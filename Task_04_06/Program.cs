namespace Task_04_06
{
    internal class Program
    {
        /*
         * Заполнить массив случайными положительными и отрицательными числами 
         * все числа по модулю должны быть разными. 
         * Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть  двух равных по модулю. 
         * В полученном массиве найти наибольшее по модулю число
         */
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int count;
                do
                {
                    count = rand.Next(-100, 101);
                } while (Array.Exists(array, x => Math.Abs(x) == Math.Abs(count)));
                array[i] = count;
            }

            int maxModule = array[0];
            foreach (var count in array)
            {
                if (Math.Abs(count) > Math.Abs(maxModule))
                    maxModule = count;
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("Наибольшее по модулю число: " + maxModule);
        }
    }
}
