using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Entity
    {
        protected string name;
        protected int hp;

        public string Name
        {
            get { return name; }
        }

        public int Hp
        {
            get { return hp; }
        }

        public void GetDamaged(int ammount)
        {
            hp -= ammount;
        } 

        public void GetHealed(int ammount)
        {
            hp += ammount;
        }
    }
}
