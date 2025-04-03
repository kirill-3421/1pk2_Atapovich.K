namespace Task_20_04r
{
    internal class Program
    {
        /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
            • Car
            • Bike
            • Bus
            • Truck
            • Motorcycle
         Храните список транспортных средств (можно просто List<VehicleType>).
         Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
         Реализуйте поиск по типу и вывод информации
        */

        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Truck);
            manager.AddVehicle(VehicleType.Bike);
            manager.AddVehicle(VehicleType.Bus);
            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Bus);
            manager.AddVehicle(VehicleType.Car);

            manager.DispalyVehicles();

            int busCount = manager.CountVehicles(VehicleType.Bus);
            Console.Write($"\nКоличество автобусов: {busCount}\n");

            int carCount = manager.CountVehicles(VehicleType.Car);
            Console.Write($"Количество автомобилей: {carCount}\n");

        }
    }
}
