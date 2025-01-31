namespace Task_05_08
{
    internal class Program
    {
        /*
         * Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл.
         * Создать новый массив, который будет произведением двух предыдущих
         * (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в результирующий массив) 
         * Вывести результирующий массив
         */

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int[,] resaultArray = new int[10, 10];

            // Заполнение первого массива
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = rand.Next(1, 10);
                }
            }

            // Заполнение второго массива
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    array2[i, j] = rand.Next(1, 10);
                }
            }

            // 1 массив * 2 массив
            for(int i = 0;i < 10; i++)
            {
                for( int j = 0; j< 10; j++)
                {
                    resaultArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            Console.WriteLine("Результирующий массив: ");
            Console.WriteLine("\n");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(resaultArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
