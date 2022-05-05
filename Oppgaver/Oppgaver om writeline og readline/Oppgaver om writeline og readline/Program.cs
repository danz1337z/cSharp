using System;

namespace Oppgaver_om_writeline_og_readline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Velkommen " + name);
        }
    }
}
