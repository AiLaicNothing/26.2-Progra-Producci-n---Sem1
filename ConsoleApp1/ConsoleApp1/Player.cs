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
            if (name.Length == 0)
            {
                throw new Exception("The name can not be empty");
            }

            this.name = name;
            hp = 10;
        }
    }
}
