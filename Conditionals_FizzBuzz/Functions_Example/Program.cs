using System;
using System.Collections.Generic;

namespace Functions_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> GPAs = new List<double>();
            List<double> ItemPrices = new List<double>();
            string response = "";

            while (response != "no")
            {
                double GPA = ValidateInputAsDouble("Please enter a GPA >>");

                Console.WriteLine("Do you want to enter another GPA");
                response = Console.ReadLine();
            }

            response = "";

            while (response != "no")
            {
                double itemPrice = ValidateInputAsDouble("Please enter the price >>");

                Console.WriteLine("Do you want to enter another price? >>");
                response = Console.ReadLine();

                bool repeatQuestion = repeatRequest();
            }

        }

        private static bool repeatRequest()
        {
            string answer;
            bool shouldContinue;
            Console.WriteLine("Do you want ot enter another value? (yes or no) >>");
            answer = Console.ReadLine();

            while (answer.ToLower() != "no" && answer.ToLower() != "yes")
            {
                Console.WriteLine("You must answer yes or no. \nTry again >>");
                answer = Console.ReadLine();
            }

            if (answer.ToLower() == "no")
            {
                shouldContinue = false;
                return false;
            }
            else
            {
                shouldContinue = true;
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        static double ValidateInputAsDouble(string message)
        {
            string answer;
            double value;
            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();


            } while (double.TryParse(answer, out value) == false);

            return value;
        }

    }   
}
