namespace Task_10_07
{
    internal class Program
    {
        /*
         * Создайте метод, с помощью которого можно сгенерировать и вернуть символьный двумерный массив 
         * массив должен состоять из символов русского алфавита
         * выведите на консоль данный массив с помощью другого метода (который принимает данный массив в качестве параметра)
         */
 
        /// <summary>
        /// создаёт и возвращает двумерный массив с символами русского языка
        /// </summary>
        /// <param name="rows">строки</param>
        /// <param name="cols">столбцы</param>
        static void Main(string[] args)
        {
            int rows = 4;
            int cols = 5;
            char[,] alphabet = ArrayGenerate(rows, cols);
            PrintAray(alphabet);
        }

        static char[,] ArrayGenerate(int rows, int cols)
        {
            char[,] alphabet = new char[rows, cols];
            Random rnd = new Random();
            char[] rusAlhabet = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    alphabet[i, j] = rusAlhabet[rnd.Next(0, rusAlhabet.Length)];
                }
            }
            return alphabet;
        }

       
        /// <summary>
        /// выводит этот двумерный массив
        /// </summary>
        /// <param name="alphabet"></param>
        static void PrintAray(char[,] alphabet)
        {
            int rows = alphabet.GetLength(0);
            int cols = alphabet.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(alphabet[i, j] + "\t");
                }
                Console.WriteLine();
            } 
        }
    }
}
