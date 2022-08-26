using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CYOA
{
    internal class BranchOne : Branch
    {
        internal Fight Fight { get; set; }
        public BranchOne(Fight fight)
        {
            Fight = fight;
        }

        public override void BranchStart()
        {
            Console.WriteLine($"There's a monster. It eats you. {Fight.PlayerName} is dead.");
        }
    }
}
