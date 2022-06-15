using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Player
    {
        public string Name { get; set; }
        public Inventory Inventory { get; set; }

        public Player(string aName)
        {
            Name = aName;
            Inventory = new Inventory();
        }
    }
}
