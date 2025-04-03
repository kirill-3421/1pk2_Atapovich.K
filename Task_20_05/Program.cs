namespace Task_20_05
{
    internal class Program
    {
        /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
            • Guest (только чтение)
            • User (чтение + комментарии)
            • Moderator (удаление контента)
            • Admin (полный доступ)
         Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалить пост).
         На основе уровня доступа выводите сообщение (например, "Ошибка: Недостаточно прав!")
        */

        static void Main(string[] args)
        {
            User guest = new User("Гость", AccessLevel.Guest);
            User user = new User("Пользователь", AccessLevel.User);
            User moderator = new User("Модератор", AccessLevel.Moderator);
            User admin = new User("Администратор", AccessLevel.Admin);

            Registration reg = new Registration();

            
            reg.CheckAccess(guest, "DeletePost");
            reg.CheckAccess(user, "DeletePost");
            reg.CheckAccess(moderator, "DeletePost");
            reg.CheckAccess(admin, "DeletePost");
        }
    }
}
