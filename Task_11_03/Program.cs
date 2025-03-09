namespace Task_11_03
{
    internal class Program
    {
        /*
         Выходной параметр (out): Напишите метод, который принимает строку и
         возвращает через выходной параметр количество гласных и согласных букв в этой строке 
         */

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.WriteLine("\n");
            int vowelsNum, consonantsNum;
            CountLetters(input, out vowelsNum, out consonantsNum);
            Console.WriteLine($"Количество гласных - {vowelsNum}.");
            Console.WriteLine("\n");
            Console.WriteLine($"Количество согласных - {consonantsNum}.");
        }

        /// <summary>
        /// подсчёт гласных и согласных букв в введённой строке
        /// </summary>
        /// <param name="input">введённая строка</param>
        /// <param name="vowels">гласные буквы</param>
        /// <param name="consonants">согласные буквы</param>
        static void CountLetters(string input, out int vowels, out int consonants)
        {
            consonants = 0;
            vowels = 0;
            string vowelsLetters = "aeiou";
            foreach (char c in input)
            {
                if (char.IsLetter(c)) // является ли введённый символ буквой
                {
                    if (vowelsLetters.Contains(c))
                    {
                        vowels ++;
                    }
                    else
                    {
                        consonants ++;
                    }
                } 
            }
        }
    }
}
