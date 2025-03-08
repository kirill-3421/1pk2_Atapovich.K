namespace Task_10_06
{
    internal class Program
    {
        /*
         * Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n,
         * выводит на консоль сгенерированный массив размерности n*n.
         */

        static void Main(string[] args)
        {
            int n = 6;
            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
            int[,] count = new int[n, n];
            Random rnd = new Random();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    count[i, j] = rnd.Next(0, 101);
                }
            }

            for(int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    Console.Write(count[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
