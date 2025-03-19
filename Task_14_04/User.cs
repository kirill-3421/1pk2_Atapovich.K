using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    public class User
    {
        //свойство для хранения пользователя
        public static User CurrentUser { get; set; }

        //свойства для имени и почты пользователя
        public string Name { get; set; }
        public string Email { get; set; }

        //метод класса - установка текущего пользователя
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }
    }
}
