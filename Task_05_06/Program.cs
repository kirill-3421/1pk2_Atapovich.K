namespace Task_05_06
{
    internal class Program
    {
        /*
         * Осуществить генерация двумерного [10*5] массива по следующему правилу: 
           • 1 столбец содержит нули 
           • 2 столбец содержит числа кратные 2 
           • 3 столбец содержит числа кратные 3 
           • 4 столбец содержит числа кратные 4 
           • 5 столбец содержит числа кратные 5 
         * Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
         */

        static void Main(string[] args)
        {

            int rows = 10;
            int lines = 5;

            // Создаем массив
            int[,] count = new int[rows, lines];

            // Заполняем массив согласно условиям
            for (int i = 0; i < rows; i++)
            {
                count[i, 0] = 0; // 1 столбец содержит нули
                count[i, 1] = i * 2; // 2 столбец содержит числа кратные 2
                count[i, 2] = i * 3; // 3 столбец содержит числа кратные 3
                count[i, 3] = i * 4; // 4 столбец содержит числа кратные 4
                count[i, 4] = i * 5; // 5 столбец содержит числа кратные 5
            }

            // Выводим оригинальный массив
            Console.WriteLine("Исходный массив: \n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    Console.Write(count[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            // Транспонирование массива
            int[,] changedCount = new int[lines, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    changedCount[j, i] = count[i, j];
                }
            }

            // Выводим транспонированный массив
            Console.WriteLine("Новый массив:\n");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(changedCount[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }       
    }
}

