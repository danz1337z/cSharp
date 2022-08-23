using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexAd
{
    internal class Inventory
    {
        public List<Items> ItemList { get; set; }
        public Inventory()
        {
            ItemList = new List<Items>();
        }
    }
}
