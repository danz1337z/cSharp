using System;
using System.Reflection.Metadata;

namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Warrior = new Player("Warrior");
            var Sword = new Weapons("Sword", 5);


            Warrior.Inventory.ItemList.Add(Sword);
            Warrior.Inventory.ItemList[0].Use();
        }
    }
}

