using System;

namespace Functions_Calculator
{
    class Program
    {
        const string devName = "Jonathan Dumar";
        const string className = "MIS 3013";
        const string date = "April 1, 2021";

        static void Main(string[] args)
        {


            Console.WriteLine("What type of calculation do you want to perform?");
            string operation = Console.ReadLine();






        }

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;

            return sum;
        }

        static double Subtract(double val1, double val2)
        {
            double difference = val1 - val2;

            return difference;
        }

        static double Multiply(double val1, double val2)
        {
            double product = val1*val2;

            return product;
        }

        static double Divide(double val1, double val2)
        {
            double quotient = val1/val2;

            return quotient;
        }

        static void DeveloperInformation(string devName, string className, string date)
        {
            string devMessage = $"{devName} wrote this application for {className} on {date}";

            
        }

    }
}
