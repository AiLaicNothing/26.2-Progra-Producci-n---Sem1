using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Event
    {
        public string name;

        public abstract void ExecuteEvent(Menu menu);
    }
}
