using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SuspiciousFountain: Event
    {
        public SuspiciousFountain()
        {
            name = $"[You encounter a fountain, its water seems different]";
        }
        public override void ExecuteEvent(Menu menu)
        {
            Console.WriteLine(name);
            Console.WriteLine("[Would you drink it?]");

            Console.WriteLine("");

            Console.WriteLine("[1] Yes, drink from the fountain");
            Console.WriteLine("[2] Lets not take a risk, and continue ");

            string optionSelected = Console.ReadLine();

            if (optionSelected == "1")
            {
                Console.WriteLine($"As you drink it, you start to feel better");
                Console.WriteLine("You are heal 1 hp");
                menu.player.GetHealed(1);
                Console.WriteLine($"Current hp = {menu.player.Hp}");
            }
            else if (optionSelected == "2")
            {
                Console.WriteLine("You dont drink it, and continue exploring");
            }
        }
    }
}
