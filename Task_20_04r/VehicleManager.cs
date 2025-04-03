using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04r
{
    internal class VehicleManager
    {
        private List<VehicleType> vehicles = new List<VehicleType>();

        //конструктор класса
        public VehicleManager() { }

        public void AddVehicle(VehicleType vehicle)
        {
            vehicles.Add(vehicle);
        }

        //метод класса - подсчет транспортных средств по виду 
        public int CountVehicles(VehicleType type)
        {
            int count = 0;

            foreach(var vehicle in vehicles)
            {
                if(vehicle == type) count++;
            }
            return count;
        }


        //метод класса - отображение всех трнаспортных средств
        public void DispalyVehicles()
        {
            if(vehicles.Count == 0)
            {
                Console.WriteLine("Нет транспортных средств");
                return;
            }

            Console.WriteLine("Списoк всех транспортных средств:\n");
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
