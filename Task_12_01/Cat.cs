using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02
{
    public class Cat
    {
        // свойства
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //конструктор класса
        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        //метод класса - издание звука(мяу!)
        public void MakeSound()
        {
            Console.WriteLine($"{Name} сказала Мяу!\n");
        }

        //метод класса - информация о кошке
        public void GetInfo()
        {
            Console.WriteLine($"Кошку зовут - {Name}, ей {Age} лет(года), она {Color} цвета.");
        }
    }
}
