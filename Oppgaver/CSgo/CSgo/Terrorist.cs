using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSgo
{
    internal class Terrorist : Player
    {
        // IsSuccessful(10) returnerer enten true eller false.
        // kaller på metoden: FindBombSite(IsSuccessful(10));

        public bool FindBombSite(bool successful)
        {
            //HER SKAL T FINNE ELLER IKKE FINNE BOMB SITE "A"
            if (successful == true)
            {
                Console.WriteLine("T FANT BOMBSITE A");
                PlantBomb();
                return true;
            }
            else
            {
                Console.WriteLine("T FANT IKKE BOMBSITE A");
                return false;
            }
        }
        //DENNE OVER ER GREI.... ?



        public void KillCounterTerrorist(CounterTerrorist ct, bool successful)
        {
            if (successful == true)
            {
                ct.IsDead = true;
            }

        }

        public void PlantBomb()
        {
            Console.WriteLine($"Planting the bomb...");
            int plantCountdown = 5;
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"Time left: {i}");
                Thread.Sleep(1000);
                plantCountdown--;
            }

            if (plantCountdown <= 0)
            {
                Console.WriteLine($"The bomb has been planted.");
            }

            //Thread.Sleep(5000);

            int bombCountdown = 15;
            for (int i = 15; i > 0; i--)
            {
                Console.WriteLine($"Time left: {i}");
                Thread.Sleep(1000);
                bombCountdown--;
            }

            if (bombCountdown <= 0)
            {
                Console.WriteLine("Terroristene vant!");
                //GameRunning = false;
            }
        }
    }
}