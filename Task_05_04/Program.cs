namespace Task_05_04
{
    internal class Program
    {
        /*
         * Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и выясните является ли данная матрица диагональной (все элементы вне главной диагонали равны нулю) 
         * Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. 
         * Если нет, то вывести сообщение что матрица не является диагональной
         */
        static void Main(string[] args)
        {
            // создание массива
            int[,] Array =
            {
                {2,0,0 },
                {0,4,0 },
                {0,0,4 }
            };

            bool Diagonal = true;
            int n = 3;

            // проверка на диагональность
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && Array[i, j] != 0)
                    {
                        Diagonal = false;
                    }
                }
            }

            // вывод с выделением цвета
            if (Diagonal)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Array[i, j] + " "); 
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.Write(Array[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // вывод если не диагональная
            else
            {
                Console.WriteLine("Матрица не диагональная.");
            }
        }
    }
}
            
        
    

