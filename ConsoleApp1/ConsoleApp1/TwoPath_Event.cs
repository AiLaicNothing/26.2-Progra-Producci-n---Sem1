using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoPath_Event : Event
    {

        public TwoPath_Event()
        {
            name = $"[As you walk you encounter two paths]";
        }
        public override void ExecuteEvent(Menu menu)
        {
            Console.WriteLine(name);
            Console.WriteLine("[Choose a path to take]");

            Console.WriteLine("");

            Console.WriteLine("[1] Left path, there seems to be weirds sounds coming from there");
            Console.WriteLine("[2] Right path, ");

            string optionSelected = Console.ReadLine();

            if (optionSelected == "1")
            {
                Console.WriteLine($"As you walk this path, {menu.player.Name} get ambushed");
                Console.WriteLine("You take 1 damage");
                menu.player.GetDamaged(2);
                Console.WriteLine($"Current hp = {menu.player.Hp}");
            }
            else if (optionSelected == "2") 
            {
                Console.WriteLine("Luckily there was nothing wrong in this way");
            }
        }
    }
}
