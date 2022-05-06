using System;

namespace OppgaverIfElse
{
    internal class Program
    {
        //------------Oppgave 2------------\\
        static int Blabla()
        {
            int value1 = 5;
            int value2 = 5;

            bool status = value1 == value2;

            if (status)
            {
                return value1 * value2;
            }
            else
            {
                return
             value1 + value2;
            }
        }

        //------------Oppgave 1------------\\
        //static bool Blabla()
        //{
        //    int value1 = 5;
        //    int value2 = 6;

        //    bool status = value1 == value2;

        //    if (status)
        //    {
        //        return true;
        //    }
        //    else { return false; }
        //}
        static void Main(string[] args)
        {
            //Console.Write("Write a number: ");
            //var input1 = Console.ReadLine();
            //Console.Write("Write another number: ");
            //var input2 = Console.ReadLine();

            //if (input1.Equals(input2))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            Console.Write(Blabla());

        }
    }
}
