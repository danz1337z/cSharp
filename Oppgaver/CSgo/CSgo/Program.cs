using System;

namespace CSgo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;
            //MakeTeams();

            //T
            var terrorist1 = new Terrorist();
            var terrorist2 = new Terrorist();
            var terrorist3 = new Terrorist();
            var terrorist4 = new Terrorist();
            var terrorist5 = new Terrorist();
            //liste med T: 
            var tListe = new List<Terrorist>();
            tListe.Add(terrorist1);
            tListe.Add(terrorist2);
            tListe.Add(terrorist3);
            tListe.Add(terrorist4);
            tListe.Add(terrorist5);

            //CT
            var counterTerrorist1 = new CounterTerrorist();
            var counterTerrorist2 = new CounterTerrorist();
            var counterTerrorist3 = new CounterTerrorist();
            var counterTerrorist4 = new CounterTerrorist();
            var counterTerrorist5 = new CounterTerrorist();

            //liste med CT:

            var ctListe = new List<CounterTerrorist>();
            ctListe.Add(counterTerrorist1);
            ctListe.Add(counterTerrorist2);
            ctListe.Add(counterTerrorist3);
            ctListe.Add(counterTerrorist4);
            ctListe.Add(counterTerrorist5);

            //------------------------------------------------ fikse det over??----






            //terrorist1.FindBombSite(Player.IsSuccessful(10));
            //terrorist1.PlantBomb();
            GameRunning(gameRunning, tListe, ctListe);



            //terrorist1.KillCounterTerrorist(ctListe[0], Player.IsSuccessful(7));

        }






        public static void MakeTeams()
        {
            //T
            var terrorist1 = new Terrorist();
            var terrorist2 = new Terrorist();
            var terrorist3 = new Terrorist();
            var terrorist4 = new Terrorist();
            var terrorist5 = new Terrorist();
            //liste med T: 
            var tListe = new List<Terrorist>();
            tListe.Add(terrorist1);
            tListe.Add(terrorist2);
            tListe.Add(terrorist3);
            tListe.Add(terrorist4);
            tListe.Add(terrorist5);

            //CT
            var counterTerrorist1 = new CounterTerrorist();
            var counterTerrorist2 = new CounterTerrorist();
            var counterTerrorist3 = new CounterTerrorist();
            var counterTerrorist4 = new CounterTerrorist();
            var counterTerrorist5 = new CounterTerrorist();

            //liste med CT:

            var ctListe = new List<CounterTerrorist>();
            ctListe.Add(counterTerrorist1);
            ctListe.Add(counterTerrorist2);
            ctListe.Add(counterTerrorist3);
            ctListe.Add(counterTerrorist4);
            ctListe.Add(counterTerrorist5);
        }



        public static void GameRunning(bool gameRunning, List<Terrorist> terrorists, List<CounterTerrorist> counterTerrorists)
        {
            while (gameRunning)
            {
                //T metoder
                int nextPlayerCT = 0;
                foreach (Terrorist terrorist in terrorists)
                {
                    terrorist.KillCounterTerrorist(counterTerrorists[nextPlayerCT], Player.IsSuccessful(7));
                    Console.WriteLine($"T:'{terrorist.Id}' tries to kill CT:'{counterTerrorists[nextPlayerCT].Id}'. <- this player is dead?: CT:{counterTerrorists[nextPlayerCT].IsDead}");
                    nextPlayerCT++;
                }

                //CT metoder
                int nextPlayerT = 0;
                foreach (CounterTerrorist counterTerrorist in counterTerrorists)
                {

                    counterTerrorist.KillTerrorist(terrorists[nextPlayerT], Player.IsSuccessful(5));
                    Console.WriteLine($"CT:'{counterTerrorist.Id}' tries to kill T:'{terrorists[nextPlayerT].Id}'. <- this player is dead?: T'{terrorists[nextPlayerT].IsDead}'");
                    nextPlayerT++;
                }


                //int killcountCT = 0;
                //foreach (CounterTerrorist counterTerrorist in counterTerrorists)
                //{
                //    bool isDead = counterTerrorist.IsDead;
                //    if(isDead == true) { killcountCT++; }

                //}

                if (counterTerrorists[0].IsDead
                    && counterTerrorists[1].IsDead
                    && counterTerrorists[2].IsDead
                    && counterTerrorists[3].IsDead
                    && counterTerrorists[4].IsDead)
                {
                    Console.WriteLine($"All the CounterTerrorists are dead.");
                    Console.WriteLine($"Terrorists win!");
                    gameRunning = false;
                }

                if (terrorists[0].IsDead
                    && terrorists[1].IsDead
                    && terrorists[2].IsDead
                    && terrorists[3].IsDead
                    && terrorists[4].IsDead)
                {
                    Console.WriteLine($"All the Terrorists are dead.");
                    Console.WriteLine($"CounterTerrorists win!");
                    gameRunning = false;
                }


            }
        }

    }
}





/*
 Vi skal programmere en konsoll-utgave av CS:GO med terrorists and counterterrorists. 

Et lag består av 5 team-members. Alle spillerene har en property bool IsDead {get; set;} 

Terroristene skal ha en metode bool FindBombSite() som går random mot “A” som bruker metoden IsSuccessful(10) for at de finner A. De har også en metode KillCounterTerrorist(CounterTerrorist ct) som bruker IsSuccessful(7). 
Når A er funnet, skal de kalle på en metode som heter PlantBomb(). Da havner spillet i en tidsmodus som tikker ned inntil bomben er sprengt. (Bruk en For-løkke som teller nedover istedenfor oppover) Det tar 5 tidsenheter å plante bomben og 15 tidsenheter fra den er plantet til den sprenger. 
Når bomben sprenger avsluttes spillet og terroristene vinner kampen. 

Counter-terrorists har en metode som heter DefuseBomb() som bruker 5 tidsenheter på å fullføre. De har også en metode KillTerrorist(Terrorist terrorist) IsSuccessful(5) for å finne en random fra terroristlaget og drepe han. Da settes propertien IsDead =true; 
Når en bombe er plantet øker KillTerrorist() slik at den heller bruker IsSuccessful(3). Alle medlemene må være døde før DefuseBomb() kan kalles. Dersom de rekker å fullføre DefuseBomb() vinner counter-terroristene

Print ut til konsollen for hver metode som kalles hva som skjer i spillet.

Programmet kjører i en While(true) Løkke frem til et av lagene har vunnet, lagene tar tur med å kalle på metodene sine. Terroristene kan alternere mellom FindBombSite og KillCounterTerrorist og CounterTerroristene bruker KillTerrorist().

   public static bool IsSuccessful(int maxValue)

   {

            Random rand = new Random();

            return rand.Next(0, maxValue) == 2;

   }
 */