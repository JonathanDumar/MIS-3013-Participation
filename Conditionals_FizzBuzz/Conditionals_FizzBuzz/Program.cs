﻿using System;

namespace Conditionals_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 101); //
            int divisableBy3Remainder = randomNbr % 3;
            bool isDivisibleBy3 = divisableBy3Remainder == 0;
            randomNbr = 9;

            if (randomNbr % 3 == 0 && randomNbr % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (randomNbr % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNbr % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                Console.WriteLine(randomNbr);
            }

        }
    }
}
