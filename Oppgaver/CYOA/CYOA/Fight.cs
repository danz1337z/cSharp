using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOA
{
    public class Fight
    {
        internal string PlayerName { get; set; }
        public Fight(string playerName)
        {
            PlayerName = playerName;
        }
        public virtual void FightRoom()
        {
            var Boss = new Character(400, 30, 10);
            var Hero = new Character(100, 20, 40);


            bool isPlayer = true;
            Random rnd = new Random();

            while (Boss.Health > 0 && Hero.Health > 0)
            {

                string playerName = isPlayer ? PlayerName : "Boss";
                string opponentName = isPlayer ? "Boss" : PlayerName;
                var player = isPlayer ? Hero : Boss;
                var opponent = isPlayer ? Boss : Hero;
                int dmg = opponentName == "Boss" ? player.Strength : rnd.Next(0, opponent.Strength + 1);

                Console.WriteLine(player.Fight(opponent, opponentName, dmg)
                    ? $"{playerName} hit {opponentName} with {dmg} damage, {opponentName} has {opponent.Health} hp left. {playerName} has {player.Stamina} stamina left"
                    : $"{playerName} recharged!");

                isPlayer = !isPlayer;
            }

            string winnerName = isPlayer ? "Boss" : PlayerName;

            Console.WriteLine(winnerName + " won!");

        }
    }
}
