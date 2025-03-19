namespace Task_13_02
{
    internal class Program
    {
        /*
         * создать класс питомца 
           свойства:
         * кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
           методы:
         * вывод информации об объекте
         * изменение значения веса животного
         * изменение отметки о состоянии здоровья
           конструторы:
         * предусмотрите разные варианты инициализации объектов
         */
        static void Main(string[] args)
        {
            Pet pet = new Pet("Моня", "кошка", 5);
            pet.Weight = 9;
            pet.IsHealth = true;
            pet.GetInfo();
            pet.ChangeWeight(10);
            pet.ChangeHealth();

            Console.WriteLine("\n");

            Pet pet2 = new Pet("Мухтар", "пёс", 7, 33, false);
            pet2.GetInfo();
            pet2.ChangeHealth();
            pet2.ChangeWeight(52);
        }
    }
}
