using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} сказал - ГАВ!");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Пса зовут - {Name}, ему {Age} лет(года), он {Color} цвета.");
        }
    }
}
