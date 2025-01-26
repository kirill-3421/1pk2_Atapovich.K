namespace Task_03_07
{
    internal class Program
    { 
        /* Вывести таблицу скорости
         * шаг=0,5 
         *  v = g*t , 
         * 2 g = 9,8 м/с2 –ускорение свободного падения
        */
        static void Main(string[] args)
        {         
                // заголовок таблицы

                Console.WriteLine("Таблица скорости свободно падающего тела: ");
                Console.WriteLine("-----------------------");
                Console.WriteLine("| t(c)    |    v(м/с) |");
                Console.WriteLine("-----------------------");

                // нахождение скорости по формуле и вывод значений

                const double g = 9.8;

                for (double t = 0; t <= 10; t += 0.5)
                {
                    double v = g * t;
                    Console.WriteLine($"|  {t:F1}    |    {v:F2}   |");
                    Console.WriteLine("-----------------------");
                }
            }
    }
}
