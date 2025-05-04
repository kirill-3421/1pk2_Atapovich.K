using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Mud : Obstacle
    {
        public Mud() : base("Грязь") { }
        public override int ModifySpeed(int currentSpeed)
        {
            // Камень уменьшает скорость на 1, но не меньше 0
            return Math.Max(currentSpeed / 2, 0);
        }
    }
}
