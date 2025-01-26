namespace Task_04_10
{
    internal class Program
    {
        /*
         * Заполнить массив из 10 элементов случайными числами в интервале [-10..10] 
         * сделать реверс элементов отдельно для 1-ой и 2-ой половин массива.
         * Реверс реализовать через цикл.
         * Стандартные методы класса Array использовать нельзя.
              Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
              Результат: [4,0,-10,2,5,-7,9,2,7,-6]
        */

        static void Main(string[] args)
        {
            //создание массива
            int[] array = new int[10];
            Random rand = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
            }

            // вывод в консоль исходного массива
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            Console.WriteLine("\n");

            ReverseArray(array, 0, array.Length / 2 - 1); //реверс первого

            ReverseArray(array, array.Length / 2, array.Length - 1); //реверс второго

            Console.WriteLine("Результат: " + string.Join(", ", array));// вывод результата

            //реверсирование массивов
            void ReverseArray(int[] array, int start, int end)
            {
                while (start < end)
                {
                    int temp = array[start];
                    array[start] = array[end];
                    array[end] = temp;

                    start++;
                    end--;
                }
            }
        }
    }
}
