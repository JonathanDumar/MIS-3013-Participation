using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Answer;
            

            Console.WriteLine("Heads or Tails?");
            Answer = Console.ReadLine();

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3);


            if (randomNbr == 1)
            {
               Console.WriteLine(Answer = "The coin landed on Heads");
            }
            else
            {
               Console.WriteLine(Answer = "The coin landed on Tails");
            }

            Console.WriteLine("The coin landed on "+ randomNbr);

        }
    }
}
