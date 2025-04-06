using System.Collections.Generic;

namespace Task_21_07
{
    internal class Program
    {
        /*
         Написать метод, который находит первый ключ в словаре, соответствующий заданному значению. 
         Если значения нет, вернуть null.
         */

        static void Main(string[] args)
        {
            Dictionary<string, int> accordance = new Dictionary<string, int> 
            {
                {"три",3 },
                {"пять",5 },
                {"семь",7 },
                {"шесть",6 },
                {"десять",10 }
            };

            int searchValue = 5;
            string key = FindKeyByValue(accordance, searchValue);

            if (key != null)
            {
                Console.WriteLine($"Ключ, соответствующий значению {searchValue}: {key}");
            }
            else
            {
                Console.WriteLine($"Значение {searchValue} не найдено в словаре.");
            }
        }

        //метод класса - поиск первого ключа по значению в словаре
        static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                if (kvp.Value == value)
                {
                    return kvp.Key; 
                }
            }
            return null;
        }
    }
}
