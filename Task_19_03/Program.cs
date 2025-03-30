namespace Task_19_03
{
    internal class Program
    {
        /*
         Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод 
        (ввод каждой строки подтверждается нажатием на enter). 
        количество введенных строк произвольно, ввод завершается при вводе пустой строки. 
        После окончания ввода произведите объединение всех ранеее введенных строк в одну с использованием разделителя «-»
                Например:
                   Введите строку 1: "Hello"
                    Введите строку 2: "world"
                    Введите строку 3: "C#"
                    Результат: "Hello-world-C#"
         */

        static void Main(string[] args)
        {
            string end = "";

            while (true)
            {
                Console.Write("Введите строку или просто нажмите Enter(оставив строку пустой) для заврешения ввода: ");
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    break;
                }
                if(!string.IsNullOrEmpty(end))
                {
                    end += "-";
                }
                end += input;
            }
            Console.WriteLine($"\nРезультат: \"{end}\"");
        }
    }
}
