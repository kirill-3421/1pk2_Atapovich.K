namespace Task_05_03
{
    internal class Program
    {
        /*
         * Даны два массива, заполненные символами английского алфавита размером 3*3.
         * Проверить, являются ли матрицы равными,
         * если да, то вывести сообщение о том, что они равны, 
         * если нет, то вывести повторно матрицы с цветовой индикацией только тех элементов, которые равны. 
         * (матрицы считаются равными, если их соответствующие элементы равны. 
         */

        static void Main(string[] args)
        {
            // создание двух массивов
            char[,] Array1 = new char[3, 3]
            {
                {'k','g','g' },
                {'v','f','h' },
                {'j','k','a' }
            };

            char[,] Array2 = new char[3, 3]
            {
                {'k','c','g' },
                {'m','f','z' },
                {'j','o','a' }
            };

            bool equal = true;

            // проверка равенств матриц
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Array1[i, j] != Array2[i, j])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
            {
                Console.WriteLine("Матрицы равны.");
            }
            else
            {
                // вывод с выделением цветом равных элементов матрицы
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Array1[i, j] == Array2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Array1[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.Write(Array1[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Array1[i, j] == Array2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Array2[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.Write(Array2[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}
