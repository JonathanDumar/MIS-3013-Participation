using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            string Answer;
            const int Heads = 1;
            const int Tails = 2;


            Console.WriteLine("Heads or Tails?");
            Answer = Console.ReadLine();

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);


            if (randomNbr == Heads)
            {
                Console.WriteLine("The coin landed on Heads");

                if (Answer == "Heads")
                {
                    Console.WriteLine("Congratulations, you're right!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }
            else if (randomNbr == Tails)
            {
                Console.WriteLine("The coin landed on Tails");
                if (Answer == "Tails")
                {
                    Console.WriteLine("Congratulations, you're right!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
            }

            const string DeveloperName = "Jonathan Dumar";

            Console.WriteLine("\nThis program was developed by " + DeveloperName);

            Console.ReadKey();
           
        }
    }
}
