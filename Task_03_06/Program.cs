namespace Task_03_06
{
    internal class Program
    {
        /* Вывести таблицу значений функции: 
         * 𝑦=|𝑥|для -4≤x≤4
         * с шагом h = 0,5
        */

        static void Main(string[] args)
        {           
              //заголовок таблицы

                Console.WriteLine("Таблица значений функции y=|x|: ");
                Console.WriteLine("--------------");
                Console.WriteLine("|  x   |   y  |");
                Console.WriteLine("--------------");

                // выполнениe действий над функцией и вывод значений

                for (double x = -4; x <= 4; x += 0.5)
                {
                    double y = Math.Abs(x);
                    Console.WriteLine($"| {y:F1}  | {x:F1} |");
                    Console.WriteLine("--------------");
                }
        }
    }
}
