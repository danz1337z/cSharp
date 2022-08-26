using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    internal class BranchList
    {
        public List<Branch> Branchs { get; set; }
       

        public BranchList(Fight fight)
        {
            Branchs = new List<Branch>();
            Branchs.Add(new BranchOne(fight));
            Branchs.Add(new BranchTwo(fight));
            Branchs.Add(new BranchThree(fight));
        }


    }
}
