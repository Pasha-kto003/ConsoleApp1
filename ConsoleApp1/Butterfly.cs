using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Butterfly : Animal, IFlying
    {
        public string Name
        { get; set; }
        public override string ToString() => Name;
        public Butterfly(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
    }
}
