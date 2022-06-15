using System;

namespace CrocodileGame5
{
    internal class Program
    {
        static bool again = true;
        static void Main(string[] args)
        {
            int score = 0;
            while (again)
            {
                Random randomNumber1 = new Random();
                int number = randomNumber1.Next(1, 11);

                Random randomNumber2 = new Random();
                int number2 = randomNumber2.Next(1, 11);



                Console.WriteLine(number + " _ " + number2);


                var input = Console.ReadLine();
                if (input == "<" && number < number2)
                {
                    Console.WriteLine("Correct");
                    score++;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == ">" && number > number2)
                {
                    Console.WriteLine("Correct");
                    score++;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == "=" && number == number2)
                {
                    Console.WriteLine("Correct");
                    score++;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == "<" && number > number2)
                {
                    Console.WriteLine("Wrong");
                    score--;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == "<" && number == number2)
                {
                    Console.WriteLine("Wrong");
                    score--;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == ">" && number == number2)
                {
                    Console.WriteLine("Wrong");
                    score--;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == ">" && number < number2)
                {
                    Console.WriteLine("Wrong");
                    score--;
                    Console.WriteLine("Score: " + score);
                }
                else if (input == "=" && number != number2)
                {
                    Console.WriteLine("Wrong");
                    score--;
                    Console.WriteLine("Score: " + score);
                }
                else
                {
                    again = false;
                }

            }
        } 
        

    }
}
