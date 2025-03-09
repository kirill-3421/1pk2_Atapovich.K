namespace Task_11_06
{
    internal class Program
    {
        /*
         Передача массива по значению: Напишите метод, который принимает массив целых чисел и 
         изменяет его элементы, увеличивая каждый на 1. 
        Проверьте, изменился ли оригинальный массив вне метода. 
         */

        static void Main(string[] args)
        {
            Console.Write("Начальный массив:  ");
            int[] num = new int[11];
            Random random = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(0, 51);
                Console.Write(num[i] + "\t");
            } 
            Console.WriteLine("\n");
            IncreasingArrayElements(num);
            Console.Write("Изменённый массив: ");
            for (int i = 0;i < num.Length;i++)
            {
                Console.Write(num[i] + "\t");
            }
            Console.WriteLine();
        }

        static void IncreasingArrayElements(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i]++;
            }
        }
    }
}
