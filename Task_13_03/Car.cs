using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    internal class Car
    {
        //свойства класса
        public string Number { get; set; }
        public string CarBrand { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        //конструкторы класса
        public Car() { }

        #region
        public Car(string number, string carBrand)
        {
            Number = number;
            CarBrand = carBrand;
        }
        #endregion

        #region
        public Car(string number, int speed)
        {
            Number = number;
            Speed = speed;
        }
        #endregion

        #region
        public Car(string number, string carBrand, string color, int speed)
        {
            Number = number;
            CarBrand = carBrand;
            Color = color;
            Speed = speed;
        }
        #endregion

        //метод класса - езда автомобиля
        public void Drive(double max)
        {
            while(Speed < max)
            {
                Speed = Speed + 1;
                Console.WriteLine($"Автомобиль {CarBrand} ускоряется, его текущая скорость - {Speed} км/ч.");
            }
        }

        //метод класса - торможение автомобиля
        public void Brake(int maxSpeed)
        {
            if (Speed > maxSpeed)
            {
                Console.WriteLine($"Скорость {Speed} км/ч превышает допустимую. Автомобиль останавливается.");
                Speed = 0; // Остановка автомобиля
            }
            else
            {
                Console.WriteLine($"Скорость {Speed} км/ч в пределах нормы. Автомобиль продолжает движение.");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Автомобиль - {CarBrand}\nномер автомобиля - {Number}\nцвет - {Color},\nтекущая скорость - {Speed} км/ч\n");
        }
    }
}
