using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TexAd
{
    internal class Weapons : Items
    {
        public int SlashingDamage { get; set; }
        public int PiercingDamage { get; set; }
        public int BluntDamage { get; set; }

        public Weapons(string aName, int aSlashingDamage, int aPiercingDamage, int aBluntDamage)
        {
            Name = aName;
            SlashingDamage = aSlashingDamage;
            PiercingDamage = aPiercingDamage;
            BluntDamage = aBluntDamage;
        }

        //public void WeaponInfo()
        //{
        //    var Sword = new Weapons("Sword", 5, 3, 0);
        //    var Shank = new Weapons("Shank", 1, 3, 0);
        //    var Blicky = new Weapons("Blicky", 0, 100, 0);


        //}


        //public override void Use()
        //{
        //    Console.WriteLine("Du bruker sverd");
        //}
    }
}
