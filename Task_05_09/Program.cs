namespace Task_05_09
{
    internal class Program
    {
        /*
         * Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей 
         * (это матрица, где все недиагональные элементы меньше нуля) 
         * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.
         * Если не выполняется, то вывести сообщение что данная матрица не является Z-матрицей
         */

        static void Main(string[] args)
        {

            int n = 4;
            int[,] array = new int[n, n];
            Random rand = new Random();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }

            // Проверка на Z-матрицу
            bool zMatrix = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] >= 0) // Недигональные элементы должны быть < 0
                    {
                        zMatrix = false;
                        break;
                    }
                }
                if (!zMatrix)
                    break;
            }

            if (zMatrix)
            {
                Console.WriteLine("Данная матрица является Z-матрицей:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j) // Главная диагональ
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }
    }
}
