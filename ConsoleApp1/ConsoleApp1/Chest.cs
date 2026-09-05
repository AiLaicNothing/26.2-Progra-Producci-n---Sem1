using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Chest: Event
    {
        public Chest()
        {
            name = $"[You encounter a chest]";
        }
        public override void ExecuteEvent(Menu menu)
        {
            Console.WriteLine(name);
            Console.WriteLine("[Choose a path to take]");

            Console.WriteLine("");

            Console.WriteLine("[1] Open the chest");
            Console.WriteLine("[2] Ignore it");
            Console.WriteLine("[3] KIck it?");

            string optionSelected = Console.ReadLine();

            if (optionSelected == "1")
            {
                Console.WriteLine($"You try to open the chest, {menu.player.Name} get attacked by a mimic");
                Console.WriteLine("You take 1 damage");
                menu.player.GetDamaged(1);
                Console.WriteLine($"Current hp = {menu.player.Hp}");
            }
            else if (optionSelected == "2")
            {
                Console.WriteLine("You choose to ignore it");
            }
            else if (optionSelected == "3")
            {
                Console.WriteLine("You kick the chest for some reason");
                Console.WriteLine("The chest come to life and run in pain");
                Console.WriteLine("It drop a potion that heals you");
                Console.WriteLine("You heal 1 damage");
                menu.player.GetHealed(1);
                Console.WriteLine($"Current hp = {menu.player.Hp}");
            }
        }
    }
}
