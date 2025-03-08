namespace Task_10_08
{
    internal class Program
    {
        /*
          * Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индекс искомого 
          элемента в массиве.
          * Если элемента нет – верните индекс = -1

         */

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 15);
            }
            int countToFind = 7;

            int index = SearchIndex(array, countToFind);

            if(index != -1)
            {
                Console.WriteLine($"{countToFind} - этот элемент найден в массиве по индексу - {index}.");
            }
            else
            {
                Console.WriteLine($"Элемент {countToFind} не найден в массиве.");
            }
        }

        /// <summary>
        /// поиск элемента в массиве по индексу
        /// </summary>
        /// <param name="array">массив рандомных чисел</param>
        /// <param name="count">искомый элемент</param>
        /// <returns>индекс искомого элемента</returns>
         static int SearchIndex(int[] array, int count)
        {
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] == count)
                {
                    return i;
                }
            }
            return -1;
        } 
    }
}
