using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    public class Items
    {
        public string name;
        private bool useable;
        private bool needsItem;
        public Items(string _name, bool canUse)
        {
            name = _name;
            useable = canUse;
        }
        public string Name
        {
            get { return name; }
        }

        public bool Useable
        {
            get { return useable; }
        }
    }
}
