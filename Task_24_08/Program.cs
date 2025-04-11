namespace Task_24_08
{
    internal class Program
    {
        /*
          реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователем
         */

        static void Main(string[] args)
        {
            string filePath = @"D:\docs\text.doc";
            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();

            Console.Write("Введите слово для замены: ");
            string replacementWord = Console.ReadLine();

            ReplaceText(filePath, searchWord, replacementWord);//замена текста
            Console.WriteLine("Замена выполнена.");
        }

        static void ReplaceText(string path, string searchWord, string replaceWord)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден");
                return; 
            }

            string[] lines = File.ReadAllLines(path);
           
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(searchWord, replaceWord);
            }

            File.WriteAllLines(path, lines);
        }
    }
}
