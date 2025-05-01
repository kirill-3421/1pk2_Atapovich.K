using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Stone : Obstacle
    {
        public Stone() : base("Камень") { }
        public override int AffectSpeed(int currentSpeed) => currentSpeed - 1;
    }
}
