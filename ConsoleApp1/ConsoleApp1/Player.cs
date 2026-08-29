using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player: Entity
    {
        public Player(string name)
        {
            this.name = name;
            hp = 10;
        }
    }
}
