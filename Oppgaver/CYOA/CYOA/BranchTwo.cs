using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CYOA
{
    internal class BranchTwo
    {
        private List<Items> inventory;

        public BranchTwo()
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
                DownStairs();
            }
            else
            {
                Console.WriteLine("You stumble and fall, hitting your head you instantly die.");
            }
        }

        public virtual void UpStairs()
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
        public virtual void DownStairs()
        {
            Clear();
            Console.WriteLine("Downstairs you find a door");
            Console.WriteLine("The door is locked. What do you want to use?");
            string open = Console.ReadLine();
            if (inventory.Exists(x => x.Name == "key") && open == "key")
            {
                Console.WriteLine("The door opens.");
            }
            if (!inventory.Exists(x => x.Name == "key") && open == "key")
            {
                Console.WriteLine("The door remains shut.");
            }
            else
            {
                Console.WriteLine("The door remains shut.");
            }
        }
    }
}
