using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    public class Game
    {
        public string name { get; set; }
        public Fight fight { get; set; }
        internal BranchList branchList { get; set; }
        public Game()
        {
            Console.WriteLine("What's you name?");
            name = Console.ReadLine();
            fight = new Fight(name);
            branchList = new BranchList(fight);
            //branch2 = new BranchTwo(name);
        }

        public void Start()
        {

            Console.WriteLine($"Hello {name}! Time for an adventure!");
            Console.WriteLine("Before you are three doors. Which do you choose? One, two or three?");

            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "one":
                    Console.WriteLine("Door one");
                    branchList.Branchs[0].BranchStart();
                    break;
                case "two":
                    Console.WriteLine("Door two");
                    branchList.Branchs[1].BranchStart();
                    break;
                case "three":
                    Console.WriteLine("This door has pudding");
                    branchList.Branchs[2].BranchStart();
                    break;
                default:
                    Console.WriteLine("vdsvds");
                    break;
            }
        }
    }
}
