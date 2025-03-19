using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        //свойства класса
        public string Name { get; set; }
        public string View {  get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public bool IsHealth { get; set; }

        //конструкторы класса
        public Pet() { }
        #region
        public Pet(string name, string view, int age)
        {

            Name = name;
            View = view;
            Age = age;
        }
        #endregion

        #region
        public Pet(string name, string view, bool isHealth)
        {
            Name = name;
            View = view;
            IsHealth = isHealth;
        }
        #endregion

        #region
        public Pet(string name, string view, int age, int weight, bool isHealth)
        {
            Name = name;
            View = view;
            Age = age;
            Weight = weight;
            IsHealth = isHealth;
        }
        #endregion

        //метод класса - вывод информации об объекте
        public void GetInfo()
        {
            string n =  IsHealth ? "здоров" : "нездоров";
            Console.WriteLine($"Кличка - {Name}\nВид - {View}\nВозраст - {Age} лет\nВес - {Weight} кг\nСостояние здоровья - {IsHealth}.");
        }

        //метод класса - изменение веса животного
        public void ChangeWeight(int weight)
        {
            Weight = weight;
            Console.WriteLine($"Новый вес питомца {Name} - {Weight} кг.");
        }

        //метод класса - изменение отметки состояния здоровья
        public void ChangeHealth()
        {
            IsHealth = !IsHealth;
            if (IsHealth == true)
            {
                Console.WriteLine("Здоров");
            }
            else
            {
                Console.WriteLine("Нездоров");
            }
        }
    }
}
