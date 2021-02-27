using System;

namespace Loops_GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowbound;
            int highbound;
            int answer;
            int randomNbr;

            
                Console.WriteLine("Input your lower value >>");
                lowbound = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input your higher value >>");
                highbound = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                randomNbr = rnd.Next(lowbound, highbound + 1);
            do
            {
                Console.WriteLine("Guess the random number between your lower and higher values >>");
                answer = Convert.ToInt32(Console.ReadLine());
            
                if (answer == randomNbr)
                {
                    Console.WriteLine("Congratulations! You guessed correctly.");

                }
                else
                {
                    Console.WriteLine("You guessed incorrectly. Try again.");
                }

            } while (answer != randomNbr);
        }
    }
}
