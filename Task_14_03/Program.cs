namespace Task_14_03
{
    internal class Program
    {
        /*
         Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте 
         так, чтобы метод работал только для неотрицательных чисел
         */

        static void Main(string[] args)
        {
            Console.Write("Введите любое неотрицательное целое число: ");
            int n = int.Parse(Console.ReadLine());

            long factorial = Math.Factorial(n);

            if (factorial == -1)
            {
                Console.WriteLine("Факториал вычисляется только для неотрицательных чисел.");
            }
            else
            {
                Console.WriteLine($"Факториал числа {n} равен - {factorial}.");
            }
        }
    }
}
