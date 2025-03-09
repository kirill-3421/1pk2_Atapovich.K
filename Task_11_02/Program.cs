namespace Task_11_02
{
    internal class Program
    {
        /*
         Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и 
         меняет их местами. Проверьте, изменились ли значения переменных вне метода 
         */

        static void Main(string[] args)
        {
            int a = 3;
            int b = 21;
            Console.WriteLine($"До смены мест: a = {a}, b = {b}.");
            Console.WriteLine("\n");
            SwapPlaces(ref a, ref b);
            Console.WriteLine($"После смены мест: a = {a}, b = {b}.");
        }

        /// <summary>
        /// меняет местами два целых числа
        /// </summary>
        /// <param name="m">первое число</param>
        /// <param name="n">второе число</param>
        static void SwapPlaces(ref int m, ref int n)
        {
            int num = m;
            m = n;
            n = num;
        }
    }
}
