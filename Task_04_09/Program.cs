namespace Task_04_09
{
    internal class Program
    {
        /*
         * В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. 
         * То есть найти и вывести уникальные элементы массива
        */

        static void Main(string[] args)
        {
            //создание массива
            int[] array = new int[30];
            Random rand = new Random();

            // заполнение массива случайными числами и вывод этого массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 31);
            }
            Console.WriteLine("Массив: " + string.Join(",", array));
            Console.WriteLine("\n");

            // создание массива для уникального элемента 
            int[] uniqueElements = new int[array.Length];
            int uniqueCount = 0;

            // создание циклов для работы с элементами массивов и поиска уникального
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueElements[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }

            
            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = uniqueElements[i];
            }

            // вывод
            Console.WriteLine("Уникальные элементы: " + string.Join(", ", result));
        }
    }
}
