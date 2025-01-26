namespace Task_03_05
{
    internal class Program
    {
           /* Вывести таблицу соответствия температуры в градусах Цельсия и Фаренгейта
            * (F = C * 1,8 + 32). 
            * Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться вовремя работы программы
           */

        static void Main(string[] args)
        {
                // Ввод шага и температур

                Console.WriteLine("Введите начальную температуру в Цельсиях: ");
                double startTemp = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите конечную температуру в Цельсиях: ");
                double endTemp = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите шаг: ");
                double step = double.Parse(Console.ReadLine());

            // условия при неверном вводе инфориации

                if (startTemp > endTemp)
                {
                    Console.WriteLine("Начальная температура должна быть меньше конечной, попробуйте снова");
                }
                else if (startTemp < endTemp)
                {
                    Console.WriteLine(startTemp);
                }


                //вывод таблицы

                for (double i = startTemp; i <= endTemp; i += step)
                {
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"| Температура в Цельсиях: {i};    |     Температура в Фаренгейтах: {i * 1.8 + 32} ");
                }

            Console.WriteLine("----------------------------------------------------------------------");

            }
        }
}
