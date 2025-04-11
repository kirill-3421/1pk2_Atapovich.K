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

            Console.WriteLine($"Строки, содержащие слово \"{searchWord}\": ");
            foreach (string line in foundLines)
            {
                Console.WriteLine(line);
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

