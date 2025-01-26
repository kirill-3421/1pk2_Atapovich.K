namespace Task_04_05
{
    internal class Program
    {
        /*
         * В массиве хранятся сведения о количестве осадков за месяц(30 дней). 
         * Определить общее количество осадков, выпавших за каждую декаду месяца(10 дней)
         * вывести день с самыми сильными осадками за месяц
         *отдельно вывести дни без осадков.
         *Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет осадков, до 300 мм выпавших осадков
        */

        static void Main(string[] args)

        {          // создание массива-месяца
            int[] precipitation = new int[30];
            Random rnd = new Random();

            // заполнение массива-месяца случайными числами
            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = rnd.Next(0, 301);
            }
              
                int[] decadaPrecipitation = new int[3]; // создание массива-декады

                // осадки за каждую декаду
                for (int i = 0; i < precipitation.Length; i++)
                {
                    if (i < 10) decadaPrecipitation[0] += precipitation[i]; // первая декада
                    else if (i < 20) decadaPrecipitation[1] += precipitation[i]; // вторая декада
                    else decadaPrecipitation[2] += precipitation[i]; // третья декада  
                }
                // вывод значений осадков
                Console.WriteLine("Общее количество осадков за каждую декаду месяца: \n");
                Console.WriteLine($"Первая декада: {decadaPrecipitation[0]} мм. ");
                Console.WriteLine($"Вторая декада: {decadaPrecipitation[1]} мм. ");
                Console.WriteLine($"Третья декада: {decadaPrecipitation[2]} мм. ");
                Console.WriteLine("\n");

                int maxPrecipitation = 0; // макс.осадки
                int dayWithMaxPrecipitation = 0; // день с макс.осадками


                    // поиск дня с макс.осадками и вывод
                    for (int i = 0; i < precipitation.Length; i++)
                    {
                        if (precipitation[i] > maxPrecipitation)
                        {
                            maxPrecipitation = precipitation[i];
                            dayWithMaxPrecipitation = i;
                        }

                    }
                    Console.WriteLine($"День с самыми сильными осадками: {dayWithMaxPrecipitation}( {maxPrecipitation} мм).");

                    Console.WriteLine("Дни без осадков: ");
                    for (int i = 0; i < precipitation.Length; i++)
                    {
                        if (precipitation[i] == 0)
                        {
                            Console.Write($"{i} ");
                        }
                    }
            }
        }
    }
