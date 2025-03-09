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
            SwapPlaces( ref a, ref b );
            Console.WriteLine($"После смены мест: a = {a}, b = {b}.");
        }

        static void SwapPlaces(ref int c, ref int d)
        {
            int num = c;
            c = d;
            d = num;
        }
    }
}
