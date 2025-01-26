namespace Task_03_04
{
    internal class Program
    {  
        /*
         * Пользователь вводит в консоли произвольный текст.
         * После каждого ввода консоль очищается. 
         * Когда пользователь введёт слово «exit» или пустую строку – ввод останавливается и выводиться количество строк введенных пользователем
        */
        static void Main(string[] args)
        { 
            //од переменных для ввода и подсчёта строк

                int count = 0;
                string input;

            // цикл для ввода строк пользователем

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Каждая введённая вами строка будет подсчитыватьcя.\n");
                    Console.WriteLine("Введите текст. Если хотите выйти, то введите 'exit' или оставьте строку пустой:\n");
                    input = Console.ReadLine();


                    if (input == "exit" || string.IsNullOrEmpty(input))
                    {
                        break;
                    }

                    count++;
                }

                // вывод количества строк

                Console.Clear();
                Console.WriteLine($"Вы ввели {count} строк");
        }
    }
}
