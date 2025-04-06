namespace Task_21_06
{
    internal class Program
    {
        /*
          Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
         */

        static void Main(string[] args)
        {
            List<int> list = new List<int> {1,2,2,3,3,3,7,6,5,4,4,4,4,3,5,5,5,};
            List<int> uniqueNum = RemoveDublicates(list);

            Console.Write("Уникальные элементы: ");
            foreach (var number in uniqueNum)
            {
                Console.Write(number + " ");
            }
        }

        static List<T> RemoveDublicates<T>(List<T> list)
        {
            List<T> unique = new List<T>();
            foreach (T item in list)
            {
                if(!unique.Contains(item))
                    unique.Add(item);
            }
            return unique;
        }
    }
}
