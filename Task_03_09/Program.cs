namespace Task_03_09
{
    internal class Program
    {
        /*
         * Вклад в банке составляет x рублей.
         * Ежегодно он увеличивается на p процентов, после чего дробная часть копеек отбрасывается. 
         * Каждый год сумма вклада становится больше. 
         * Определите, через сколько лет вклад составит не менее y рублей.*/

            /* Пример
              входные данные
             * 100
             * 10
             * 200
              выходные данные: 8
            */

        static void Main(string[] args)
        {
            // ввод данных

            Console.Write("Введите начальную сумму вклада:  ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите процент по вкладу:  ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Введите необходимую Вам сумму:  ");
            int y = int.Parse(Console.ReadLine());

            // ввод переменных

            double depositAmount = x;
            int years = 0;

            while(depositAmount < y)
            {
                depositAmount += (depositAmount * p) / 100; // расчёт процентов 
                depositAmount = Math.Floor(depositAmount * 100) / 100; // отбрасвание копеек
                years++;
            }

            // вывод количетсва лет

            Console.WriteLine($"Вклад достигнет необходимой Вам суммы через {years} лет(года). ");
        }
    }
}
