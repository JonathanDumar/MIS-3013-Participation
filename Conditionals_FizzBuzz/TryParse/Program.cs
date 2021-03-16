using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "55s";
            int realNumber;

            if (int.TryParse(number, out realNumber) == true)
            {
                Console.WriteLine("Good number");
            }
            else
            {
                Console.WriteLine("Bad number");
            }

            String s = new String("55s");
            Random randNum = new Random();

            int x= randNum.Next(1, 9);


        }
    }
}
