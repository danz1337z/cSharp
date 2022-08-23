using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using static System.Console;

namespace TexAd
{
    internal class Game
    {
        public static void Play()
        {


            var Warrior = new Player("Warrior");

            var Sword = new Weapons("Sword", 5, 3, 0);
            var Shank = new Weapons("Shank", 1, 3, 0);
            var Blicky = new Weapons("Blicky", 0, 100, 0);

            Warrior.Inventory.ItemList.Add(Sword);
            Warrior.Inventory.ItemList.Add(Blicky);
            Warrior.Inventory.ItemList[1].Use();


        }
    }
}
