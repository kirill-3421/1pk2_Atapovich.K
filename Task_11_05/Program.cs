namespace Task_11_05
{
    internal class Program
    {
        /*
         Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и 
         возвращает их сумму и произведение через выходные параметры (out). 
         */

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();
            int sum, product;
            Calculator(ref x, ref y, out sum, out product);
            Console.WriteLine($"Сумма чисел = {sum}.");
            Console.WriteLine("\n");
            Console.WriteLine($"Произведение чисел = {product}.");
        }

        /// <summary>
        /// нахождение суммыы и произведения двух целых чисел
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        /// <param name="sum">сумма чисел</param>
        /// <param name="product">произведение чисел</param>
        static void Calculator(ref int number1, ref int number2, out int sum, out int product)
        {
            sum = number1 + number2;
            product = number1 * number2;

        }
    }
}
