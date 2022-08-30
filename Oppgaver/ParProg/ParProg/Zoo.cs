using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    internal class Zoo
    {
        public string Name { get; set; }
        public List<ZooKeeper> Keepers { get; set; }
        public List<Animals> Animals { get; set; }

        public Zoo(string name)
        {
            Name = name;
            Keepers = new List<ZooKeeper>
            {
                new ZooKeeper("Jim", 25)
            };
            Animals = new List<Animals>
            {
                new Lion("Frank", 40),
                new Lion("Tom", 40),
                new Capybara("Daniel", 69),
                new Chimpanzee("Julius", "Female", 420),
                new Chimpanzee("YOLOSWAG", "Male", 1337)
            };
            PrintAnimals();
        }



        public void PrintAnimals()
        {
            foreach (var animal in Animals)
            {
                PrintInfo(animal);
            }
        }

        public void PrintInfo(Animals animal)
        {
            Console.WriteLine($"{animal.Type} with the name of {animal.Name}");
        }
    }
}
