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
        private Random rand = new Random();

        private int currentEvents;
        private int maxEvents = 5;
        private int eventsCompleted;

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
                new SuspiciousFountain(),
                new Chest()
            };
        }

        private void CreatePlayer()
        {
            Console.WriteLine("[Write your character name]");

            string playerName = Console.ReadLine();

            try
            {
                player = new Player(playerName);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            //player = new Player(playerName);
            Console.WriteLine($"[{player.Name} is a adventures that has entered a Dungeon]");
            Console.WriteLine($"Currently has {player.Hp} Hp");
        }

        private void LoopGameplay()
        {
            while (player.Hp > 0 && eventsCompleted < maxEvents)
            {
                Console.Clear();

                Event currentEvent = events[rand.Next(events.Count)];

                currentEvent.ExecuteEvent(this);

                eventsCompleted++;

                WaitInput();
            }

            EndGame();
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
