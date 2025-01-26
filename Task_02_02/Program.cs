namespace Task_02_02
{
    internal class Program
    { 
        /* Найти значение выражения 
         * при a = 8, b = 14, c = π/4
         */

        static void Main(string[] args)
        {
                // ввод данных

                double a = 8;
                double b = 14;
                double c = Math.PI / 4;

                // вычисления и вывод результата

                double part1 = b + Math.Pow((a - 1), 1.0 / 3);
                double part2 = Math.Pow(part1, 0.25);
                double part3 = Math.Abs(a - b);
                double part4 = Math.Pow(Math.Sin(c), 2);
                double part5 = part4 + Math.Tan(c);
                double part6 = part3 * part5;

                double resault = part2 / part6;
                Console.WriteLine(resault);
        }
    }
}
