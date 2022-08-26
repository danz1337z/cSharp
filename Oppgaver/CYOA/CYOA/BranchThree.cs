using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    internal class BranchThree : Branch
    {

        internal Fight Fight { get; set; }
        public BranchThree(Fight fight)
        {
            Fight = fight;
        }

        public override void BranchStart()
        {
            Console.WriteLine($"yo {Fight.PlayerName}");
            Fight.FightRoom();
        }
    }
}
