using System;

namespace OppgaverOmMainMetodenOgArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine(args.Length);

        }
    }
}
