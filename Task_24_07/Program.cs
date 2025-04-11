namespace Task_24_07
{
    internal class Program
    {
        /*
          Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащие это 
          слово (регистронезависимо)
         */

        static void Main(string[] args)
        {
            string filePath = @"D:\docs\text.doc"; 
            string searchWord = "хозяйство";
            List<string> foundLines = FindLines(filePath, searchWord);

            if (foundLines.Count > 0)
            {
                Console.WriteLine($"Cтроки, содержащие слово \"{searchWord}\":");
                foreach (string line in foundLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"Слово \"{searchWord}\" не найдено в файле.");
            }
        }

        static List<string> FindLines(string path, string word)
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(line);
                    }
                }
            }

            return result;
        }
    }
}

