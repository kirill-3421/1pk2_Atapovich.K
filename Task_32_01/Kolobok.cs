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
            Speed = 1;
            IsAlive = true;
        }
        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}, скорость: {Speed}");
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
        public void EncounterObstacle(Obstacle obstacle)
        {
            int newSpeed = obstacle.AffectSpeed(this.Speed);
            if (newSpeed < 0) newSpeed = 0;

            if (newSpeed != this.Speed)
            {
                Console.WriteLine($"Колобок встретил {obstacle.Name} и его скорость изменилась с {this.Speed} до {newSpeed}!");
                this.Speed = newSpeed;
            }
        }
    }
}