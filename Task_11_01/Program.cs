namespace Task_11_01
{
    internal class Program
    {
        /*
         * Передача по значению: Напишите метод, который принимает два целых числа и меняет их местами. 
         * Проверьте, изменились ли значения переменных вне метода 
         */

        static void Main(string[] args)
        {
            int a = 7;
            int b = 14;
            Console.WriteLine($"До смены мест: а = {a}, b = {b}.");
            Console.WriteLine("\n");
            SwapPlaces(a, b);
            Console.WriteLine($"После смены мест: a = {a}, b = {b}.");
        }

        /// <summary>
        /// метод должен поменять местами двва целых числа
        /// </summary>
        /// <param name="c">первое число</param>
        /// <param name="d">второе число</param>
        static void SwapPlaces(int c, int d)
        {
            int num = c;
            c = d;
            d = num;
        }
    }
}
