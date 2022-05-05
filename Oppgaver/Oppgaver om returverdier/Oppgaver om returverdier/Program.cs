using System;

namespace Oppgaver_om_returverdier
{
    internal class Program
    {
        static int tall1 = 5;
        static int tall2 = 3;
        static void Main(string[] args)
        {
            var toTall = TallSum(tall1, tall2);
            Console.WriteLine(toTall);


        }

        static int TallSum(int tall1, int tall2)
        {
            return tall1 + tall2;
        }
        static void Ingenting()
        {
            return;
        }
    }
}
