using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    internal class User
    {
        public string Name { get; set; }
        public AccessLevel Access { get; set; }

        public User() { }
        public User(string name, AccessLevel access)
        {
            Name = name;
            Access = access;
        }
    }
}
