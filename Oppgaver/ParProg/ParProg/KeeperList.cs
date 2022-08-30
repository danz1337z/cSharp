using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    internal class KeeperList
    {
        //private static List<ZooKeeper> _zooKeeperList;
        //_zooKeeperList = new List<ZooKeeper>();

        //Console.WriteLine($"Zookeeper ");
        //_zooKeeperList[0].PrintInfo();
        public List<ZooKeeper> Keepers { get; set; }

        public KeeperList()
        {
            Keepers = new List<ZooKeeper>();
        }
    }
}
