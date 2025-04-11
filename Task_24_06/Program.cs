namespace Task_24_06
{
    internal class Program
    {
        /*
         Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте StreamReader
         */

        static void Main(string[] args)
        {
            string filePath = @"D:\docs\text.doc";
            int count = CountLines(filePath);
            Console.WriteLine($"Количество строк в файле: {count}");
        }

        static int CountLines(string path)
        {
            int count = 0;
            using(StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
