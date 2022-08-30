using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    internal class AnimalsList
    {
        public static List<Animals> Animal { get; set; }


        public static void ListInfo()
        {
            Animal = new List<Animals>
            {
                new Lion("Frank", 40),
                new Lion("Tom", 40),
                new Capybara("Daniel", 69),
                new Chimpanzee("Julius","Female", 420),
                new Chimpanzee("YOLOSWAG","Male", 1337)
            };
            //Animal[0].Printinfo();
            //Animal[1].Printinfo();

            foreach (var Animals in Animal)
            {
                Animals.Printinfo();
            }
        }

    }

}
