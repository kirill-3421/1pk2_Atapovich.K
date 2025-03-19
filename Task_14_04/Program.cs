using System.Security.Cryptography.X509Certificates;

namespace Task_14_04
{
    internal class Program
    {
        /*
         Определите класс User, который будет иметь статическое свойство CurrentUser, представляющее текущего 
         пользователя, и метод для его установки.

         */

        static void Main(string[] args)
        {
            User user = new User { Name = "Кирилл", Email = "k.irill@gmail.com" };
            User.SetCurrentUser(user);
            Console.WriteLine($"Текущий пользователь - {User.CurrentUser.Name}\nEmail - {User.CurrentUser.Email}");
        }
    }
}
