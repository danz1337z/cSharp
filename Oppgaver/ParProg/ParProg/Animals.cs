using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    public class Animals
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public Animals(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public virtual void Printinfo()
        {

            Console.WriteLine($"Name {Name}, Type {Type}, Age {Age}");
        }
    }
}
