using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    internal class Weapons : Items
    {
        public int Damage { get; set; }
        public Weapons(string aName, int aDamage)
        {
            Name = aName;
            Damage = aDamage;
        }

        //public override void Use()
        //{
        //    Console.WriteLine("Du bruker sverd");
        //}
    }
}
