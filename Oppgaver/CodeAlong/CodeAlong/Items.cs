using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexAd
{
    internal class Items
    {
        public string Name { get; set; }
        public Items()
        {

        }

        public virtual void Use()
        {
            Console.WriteLine($"You used {Name}");
        }
    }
}
