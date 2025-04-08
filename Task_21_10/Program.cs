namespace Task_21_10
{
    internal class Program
    {
        /*
         Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их 
          значения
         */

        static void Main(string[] args)
        {
            Dictionary<string, int> dic1 = new Dictionary<string, int> 
            {
                {"Mersedes",2 },
                {"BMW",1 },
                {"Porshe",3 },
                {"Ferrari",4 },
                {"Lamborgini",5 }
            };

            Dictionary<string, int> dic2 = new Dictionary<string, int>
            {
                {"Mazda",2 },
                {"Lada",6 },
                {"Nissan",7 },
                {"Ford",8 },
                {"Tesla",3 }
            };

            Dictionary<string, int> resultDic = MergeDictionaries(dic1, dic2);
            Console.WriteLine("Получившийся словарь:\n");
            foreach (var pair in resultDic)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        //статический метод класса - объединяет словари
        static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {

            Dictionary<string, int> result = new Dictionary<string, int>(); 
            foreach (var pair in dict1)
            {
                result[pair.Key] = pair.Value; // Ключ и значение из первого словаря
            }

            foreach (var pair in dict2)
            {
                if (result.ContainsKey(pair.Key))
                {
                    result[pair.Key] += pair.Value; // Суммируем значения
                }
                else
                {
                    result[pair.Key] = pair.Value; // Добавляем новый ключ и значение
                }
            }

            return result; 
        }
    }
}
