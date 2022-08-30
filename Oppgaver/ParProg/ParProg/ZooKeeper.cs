using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    internal class ZooKeeper
    {
        public string name;
        public int age;

        public ZooKeeper(string _name, int _age)
        {
            name = _name;
            age = _age;
        }

        //public string Name
        //{
        //    get { return name; }
        //}
        //public int Age
        //{
        //    get { return age; }
        //}
        public virtual void PrintInfo()
        {

            Console.WriteLine($"Name {name}, Age {age}");
        }
    }
}
