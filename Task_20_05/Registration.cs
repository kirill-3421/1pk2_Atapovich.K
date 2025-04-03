using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    internal class Registration
    {
        public void CheckAccess(User user, string action)
        {
            switch (action)
            {
                case "DeletePost": 
                    if (user.Access == AccessLevel.Admin || user.Access == AccessLevel.Moderator)
                    {
                        Console.WriteLine($"{user.Name} может удалить пост");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав для удаления поста!");
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка: Неизвестное действие!");
                    break;
            }
        }
    }
}
