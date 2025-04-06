namespace Task_21_08
{
    internal class Program
    {
        /*
         напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки
         */

        static void Main(string[] args)
        {
            string[] array =
            {
                "машина",
                "автобус",
                "газель",
                "машина",
                "газель",
                "газель"
            };
            string[] unique = GetUniqueElements(array);

            Console.Write("Уникальные строки: ");
            foreach (string element in unique)
            {
                Console.Write(element + " ");
            }
        }

        static string[] GetUniqueElements(string[] strings)
        {
            HashSet<string> uniqueSet = new HashSet<string>();
            foreach (string str in strings)
            {
                uniqueSet.Add(str);
            }
            return uniqueSet.ToArray();
        }
    }
}
