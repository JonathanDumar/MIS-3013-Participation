using System;

namespace DoWhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int LuckyNumber;

            
            
            Console.WriteLine("Please enter your lucky number >>");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out LuckyNumber) == false)
            {
                Console.WriteLine("You entered an invalid integer. Please try again");
                answer = Console.ReadLine();
            }

            Console.WriteLine("You entered a valid number!");

        }
    }
}
