namespace Task_19_02
{
    internal class Program
    {
        /*
         Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий предложения (есть знаки препинания).
         программa после анализа выводит текст, разделенный на части:
             a)По пробелам (отдельные слова построчно)
             b)По предложениям (отдельные предложения построчно)
              (используйте метод Split())

         */

        static void Main(string[] args)
        {
            Console.Write("Введите текст(ставьте знаки препинания, если они необходимы): ");
            string input = Console.ReadLine();

            //разделение текста по пробелам
            string[] words = input.Split(' ');
            Console.WriteLine("\nСлова в тексте:");
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word)) // Проверка, что слово не пустое
                {
                    Console.WriteLine(word);
                }
            }

            //разделение текста по предложениям
            char[] sentenceDelimiters = { '.', '!', '?', '-', ';'};
            string[] sentences = input.Split(sentenceDelimiters);

            Console.WriteLine("\nПредложения в тексте:");
            foreach (string sentence in sentences)
            {
                if (!string.IsNullOrWhiteSpace(sentence))
                {
                    Console.WriteLine(sentence.Trim()); //избавление от лишних пробелов
                }
            }
        }
    }
}
