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
        public override int AffectSpeed(int currentSpeed) => currentSpeed / 2;
    }
}
