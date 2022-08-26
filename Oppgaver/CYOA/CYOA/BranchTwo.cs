using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CYOA
{
    internal class BranchTwo : Branch
    {

        private List<Items> inventory;

        internal Fight Fight { get; set; }
        public BranchTwo(Fight fight)
        {
            Fight = fight;
        }

        public override void BranchStart()
        {
            Console.WriteLine("Before you are two sets of stairs. One going up and one going down.");
            string stairChoice = Console.ReadLine().ToLower();

            if (stairChoice == "up")
            {
                Console.WriteLine("Going up!");
                UpStairs();
            }
            else if (stairChoice == "down")
            {
                Console.WriteLine("Going down");
                Console.WriteLine("Downstairs you find a door");
                Console.WriteLine("The door is locked. Seeing no way to open it, you return upstairs.");

            }
            else
            {
                Console.WriteLine("You stumble and fall, hitting your head you instantly die.");
            }
        }

        public void UpStairs()
        {
            inventory = new List<Items>();
            Clear();
            Console.WriteLine("Upstairs you find a key and you pick it up");
            Items key = new Items("key", true);
            inventory.Add(key);
            Console.WriteLine("Adventure has chosen you!");
            Console.WriteLine("Go back downstairs?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                DownStairs();
            }
            else
            {
                Console.WriteLine("you died");
            }
        }
        public void DownStairs()
        {
            Clear();
            Console.WriteLine("Downstairs you find a door");
            Console.WriteLine("The door is locked. What do you want to use?");
            string open = Console.ReadLine().ToLower();
            if (inventory.Exists(x => x.Name == "key") && open == "key")
            {
                Console.WriteLine("The door opens.");
                OpenDoor();
            }
            else
            {
                Console.WriteLine("The door remains shut.");
            }
        }

        public void OpenDoor()
        {
            Console.WriteLine($"You are entering a new room, {Fight.PlayerName}");
            Console.ReadLine();
            Fight.FightRoom();
        }
    }
}

