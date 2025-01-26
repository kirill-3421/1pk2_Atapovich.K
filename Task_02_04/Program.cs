namespace Task_02_04
{
    internal class Program
    { 
        /*
           Программа определяет возраст пользователя
           Пользователь должен ввести свою дату рождения:
          * год
          * месяц
          * дату
          В зависимости от выбранного режима произвести соответствующие действия с пользовательскими данными и выведите соответствующие сообщения.
        */

        static void Main(string[] args)
        {
          
            // ввод данных пользователем

                Console.WriteLine("Введите ваш год рождения: \t");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваш месяц рождения: \t");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваш день рождения \t");
                int day = int.Parse(Console.ReadLine());

            // вычисление возраста пользователя

                var today = DateTime.Today;
                DateTime birthday = new DateTime(year, month, day);
                int age = today.Year - birthday.Year;

            // вывод 

                if (birthday > today.AddYears(-age))
                    age--;

                if (age < 18)
                    Console.WriteLine("Вам ещё нет 18, вы несовершеннолетний. ");
                else if (age >= 18)
                    Console.WriteLine("Вы совершеннолетний.");

        }
    }
}
