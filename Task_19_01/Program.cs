namespace Task_19_01
{
    internal class Program
    {
        /*
        Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего программа запрашивает подстроку для поиска.
        Если подстрока найдена - то программа запрашивает текст для того чтобы заменить на него эту подстроку 
        (столько раз, сколько раз подстрока встречена в тексте)
           Пример:
            Введите строку: "Привет, мир!"
            Введите подстроку для поиска: "мир"
            Введите подстроку для замены: "друг"
            Результат: "Привет, друг!"

         */

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.Write("Введите подсроку для поиска: ");
            string searchInput = Console.ReadLine();

            if(input.Contains(searchInput))
            {
                Console.Write("Введите строку для замены: ");
                string resultInput = Console.ReadLine();

                string resultInput2 = input.Replace(searchInput, resultInput);
                Console.WriteLine($"Результат: {resultInput2}");
            }
            else
            {
                Console.WriteLine("Подстрока не найдена, попробуйте снова");
                return;
            }
        }
    }
}
