using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        public Entity player;
        public List<Event> events;

        private int currentEvents;
        private int maxEvents;

        public void Execute()
        {
            RegisterEvents();

            CreatePlayer();

            Console.WriteLine("[You enter a Dungeon]");

            LoopGameplay();
        }

        private void RegisterEvents()
        {
            events = new List<Event>()
            {
                new TwoPath_Event(),

            };
        }

        private void CreatePlayer()
        {
            Console.WriteLine("[Write your character name]");
            string playerName = Console.ReadLine();

            player = new Player(playerName);
            Console.WriteLine($"[{player.Name} is a adventures that has entered a Dungeon]");
            Console.WriteLine($"Currently has {player.Hp} Hp");
        }

        private void LoopGameplay()
        {
            while (player.Hp > 0 && currentEvents <= maxEvents)
            {
                Console.Clear();

                WaitInput();
            }
        }

        public void WaitInput()
        {
            Console.WriteLine("[Press Enter to continue...]");
            Console.ReadLine();
        }

        private void EndGame()
        {
            Console.Clear() ;

            if (player.Hp <= 0)
            {
                Console.WriteLine("[BAD ENDING]");
                Console.WriteLine("You suffered injuries and didnt survive");
            }
            else
            {
                Console.WriteLine("[GOOD ENDING]");
                Console.WriteLine("You has travelled thought the Dungeon and survive");
                Console.WriteLine("You become a good adventurer");
            }
        }
    }
}
