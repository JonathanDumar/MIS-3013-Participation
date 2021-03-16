using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();

            string answer;

            do
            {
                Console.WriteLine("What is one of your favorite things? >>");
                answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have other favorite things? (Yes or No) >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Random rand = new Random();
            int randomIndex = rand.Next(0, favoriteThings.Count);

            string randomThing = favoriteThings[randomIndex];

            Console.WriteLine($"Your favorite thing is {randomThing}.");
        }
    }
}
