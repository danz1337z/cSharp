using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSgo
{
    internal class CounterTerrorist : Player
    {

        public void DefuseBomb() { }

        public void KillTerrorist(Terrorist terrorist, bool successful)
        {
            if (successful == true)
            {
                terrorist.IsDead = true;
            }
        }


        //public void KillTerrorist(Terrorist terrorist) /*IsSuccessful(SuccessRate)*/ { }


        //public void IsSuccessful(SuccessRate) {}
        //public void DefuseBomb() { }
    }
}