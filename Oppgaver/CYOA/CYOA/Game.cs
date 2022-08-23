using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    public class Game
    {
        public Game()
        {
            Console.WriteLine("What's you name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Time for an adventure!");
            Console.WriteLine("Before you are three doors. Which do you choose? One, two or three?");

            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "one":
                    Console.WriteLine("Door one");
                    BranchOne BranchOne = new BranchOne();
                    break;
                case "two":
                    Console.WriteLine("Door two");
                    BranchTwo BranchTwo = new BranchTwo();
                    break;
                case "three":
                    Console.WriteLine("This door has pudding");
                    BranchThree BranchThree = new BranchThree();
                    break;
                default:
                    Console.WriteLine("kuk");
                    break;
            }
        }
    }
}
