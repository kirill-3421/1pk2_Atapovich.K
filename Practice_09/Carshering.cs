using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practice_09
{
     internal static class Carshering
    {
        internal static Dictionary<CharacteristicCar, HashSet<DateTime>> rentals = new();
        public static string rentalsFile = "rentals.json";
        /// <summary>
        /// Для аренды конкретного автомобиля на конкреную дату (с проверкой на занятость)
        /// </summary>
        /// <param name="car"></param>
        public static void AddCar(CharacteristicCar car)
        {
            if (!rentals.ContainsKey(car))
            {
                rentals.Add(car, new HashSet<DateTime>());
            }
        }
        /// <summary>
        /// Аренда автомобиля с проверкой на занятость
        /// </summary>
        /// <param name="car"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool RentCar(CharacteristicCar car, DateTime date)
        {
            if (rentals.TryGetValue(car, out HashSet<DateTime> dates))
            {
                if (!dates.Contains(date))
                {
                    dates.Add(date);
                    return true;
                }
                return false;
            }
            return false;
        }
        /// <summary>
        /// Oтмена аренды
        /// </summary>
        /// <param name="car"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool CancelRental(CharacteristicCar car, DateTime date)
        {
            if (rentals.ContainsKey(car) && rentals[car].Contains(date))
            {
                rentals[car].Remove(date);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Выручка от аренды конкретного автомобиля
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public static double GetCarRevenue(CharacteristicCar car)
        {
            if (rentals.ContainsKey(car))
            {
                return rentals[car].Count * car.Price;
            }
            return 0;
        }
        /// <summary>
        /// Общая выручка
        /// </summary>
        /// <returns></returns>
        public static double GetTotalRevenue()
        {
            double totalRevenue = 0;
            foreach (var el in rentals)
            {
                totalRevenue += el.Value.Count * el.Key.Price;
            }
            return totalRevenue;
        }
        public static void SaveRentals()
        {
            try
            {
                var rentalsForSerialization = new Dictionary<string, HashSet<DateTime>>(); //преобразовываем ключи в строки
                foreach (var elem in rentals) // создаем ключи для авто
                {
                    string carKey = elem.Key.Number + "_"
                                    + elem.Key.Year + "_"
                                    + elem.Key.Category;
                    rentalsForSerialization.Add(carKey, elem.Value);
                }
                string json = JsonSerializer.Serialize(rentalsForSerialization);
                File.WriteAllText(rentalsFile, json);
                Console.WriteLine("Данные об аренде сохранены.");
            }
            catch
            {
                Console.WriteLine($"Ошибка при сохранении данных об аренде");
            }
        }
        public static void LoadRentals()
        {
            try
            {
                if (File.Exists(rentalsFile))
                {
                    string json = File.ReadAllText(rentalsFile);
                    var deserializedRentals = JsonSerializer.Deserialize<Dictionary<string, HashSet<DateTime>>>(json);
                    rentals = new Dictionary<CharacteristicCar, HashSet<DateTime>>();
                    foreach (var ell in deserializedRentals)
                    {
                        string[] parts = ell.Key.Split('_');
                        if (parts.Length == 3)
                        {
                            string number = parts[0];
                            int year = int.Parse(parts[1]);
                            CarType category = Enum.Parse<CarType>(parts[2]);
                            List<CharacteristicCar> carList = CharacteristicCar.CarsList.GetValueOrDefault(category.ToString()) ?? new();
                            CharacteristicCar car = carList.Find(c => c.Number == number && c.Year == year);
                            if (car != null)
                            {
                                rentals.Add(car, ell.Value);
                            }
                            else
                            {
                                Console.WriteLine($"Автомобиль {ell.Key} не найден.");
                            }
                        }
                    }
                    Console.WriteLine("Данные об аренде загружены.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных об аренде: {ex.Message}");
            }
        }
    }
}
                

