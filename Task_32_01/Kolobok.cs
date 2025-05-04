using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; private set; }
        public bool IsAlive { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 6;
            IsAlive = true;
        }
        public void Roll()
        {
            Position ++;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}, скорость: {Speed}км/ч\n");
        }
        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

        //столкновения с препятствиями
        public void MeetObstacle(Obstacle obstacle)
        {
            Speed = obstacle.ModifySpeed(Speed);
            Console.WriteLine($"Колобок столкнулся с {obstacle.Name} и его скорость стала - {Speed}км/ч!\n");
        }
    }
}