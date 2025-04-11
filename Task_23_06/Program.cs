namespace Task_23_06
{
    internal class Program
    {
        /*
         Напишите программу со следующими функциями:
           1. Выведите информации о всех дисках в системе
           2. Выведите содержимое каталога C:\Users (названия папок)
           3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
             a) Создание вложенного каталога “temp”
             b) Вывод информации о текущем каталоге (имя, родитель и тд)
             c) Вывод информации о вложенном каталоге
           4. Переместите каталог “temp” по пути “D:\work\newTemp”
             a) Реализуйте вывод информационного сообщения об успешном (или нет) перемещении
           5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении
         */

        static void Main(string[] args)
        {
            //1. Выведите информации о всех дисках в системе
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            Console.WriteLine("Диски в текущей системе:\n");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"{drive.Name}: Размер диска: {drive.TotalSize / 1024 / 1024 / 1024}гб\n" +
                    $"Доступное место на диске: {drive.AvailableFreeSpace / 1024 / 1024 / 1024}гб\nТип диска: {drive.DriveType}\n" +
                    $"Метка диска: {drive.VolumeLabel}\n");
            }
            

            //2. Выведите содержимое каталога C:\Users (названия папок)
            string pathName = Console.ReadLine();

            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Файлы в папке - {pathName}");
                List<String> list = Directory.GetFiles(pathName).ToList();

                if (list.Count > 0)
                {
                    int n = 1;
                    foreach (String s in list)
                    {
                        Console.WriteLine(n + ": " + s);
                        Console.WriteLine("\n");
                    }
                }
                else
                    Console.WriteLine("нет файлов\n");
            }
            else
            {
                Console.WriteLine("каталог не существует\n");
            }
            

            //задание 3, создание вложенного каталога "temp"
            string workDir = @"D:\work";
            Directory.CreateDirectory(workDir);
            string tempDir = Path.Combine(workDir, "temp");
            Directory.CreateDirectory(tempDir);
            Console.WriteLine("Новый каталог 'temp' в D:\\work\n");

            //Вывод информации о текущем каталоге (имя, родитель и тд)
            Console.WriteLine("Информация о текущем каталоге:");
            DirectoryInfo currentDirectory = new DirectoryInfo(workDir);
            Console.WriteLine($"Имя: {currentDirectory.Name}\nРодительский каталог: {currentDirectory.Parent?.Name}" +
                $"\nПолный путь: {currentDirectory.FullName}\n");

            //Вывод информации о вложенном каталоге
            DirectoryInfo tempDirectoryInfo = new DirectoryInfo(tempDir);
            Console.WriteLine($"Информация о каталоге 'temp':");
            Console.WriteLine($"Имя: {tempDirectoryInfo.Name}\nРодительский каталог: {tempDirectoryInfo.Parent?.Name}" +
                $"\nПолный путь: {tempDirectoryInfo.FullName}\n");
            

            //4. Переместите каталог “temp” по пути “D:\work\newTemp” и вывод о перемещении
            string newTempDir = Path.Combine(workDir, "newTemp");
            if (Directory.Exists(tempDir))
            {
                Directory.Move(tempDir, newTempDir);
                Console.WriteLine($"Каталог 'temp' был успешно перемещен в 'newTemp'");
            }
            else
            {
                Console.WriteLine($"Ошибка: Каталог 'temp' не существует\n");
            }

            // 5. Удалить каталог "D:\work\newTemp" и вывести сообщение об успешном (или нет) удалении
            if (Directory.Exists(newTempDir))
            {
                Directory.Delete(newTempDir, true);
                Console.WriteLine("Каталог 'newTemp' успешно удален\n");
            }
            else
            {
                Console.WriteLine("Ошибка: Каталог 'newTemp' не существует, поэтому его нельзя удалить");
            }
        }
    }
}
