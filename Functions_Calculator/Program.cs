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


            DeveloperInformation(devName, className, date);
            string userChoice = " ";
            double solution = 0;


            do
            {
                Console.WriteLine("\nWhat type of calculation would you like to perform? (Addition, Subtraction, Multiplication, or Division) >>");
                string calcType = Console.ReadLine().ToLower();

                double val1;
                double val2;
                

                if (userChoice.ToLower()[0] == 'b')
                {
                    val1 = solution;

                }
                else
                {
                    Console.WriteLine("Please enter the first value >>");
                    string answer1 = Console.ReadLine();
                    double.TryParse(answer1, out val1);
                }

                Console.WriteLine("Please enter the second value >>");
                string answer2 = Console.ReadLine();
                double.TryParse(answer2, out val2);


                if (calcType[0] == 'a')
                {
                    solution = Add(val1, val2);
                    Console.WriteLine($"The answer is {solution}.");
                }
                else if (calcType[0] == 's')
                {
                    solution = Subtract(val1, val2);
                    Console.WriteLine($"The answer is {solution}.");
                }
                else if (calcType[0] == 'm')
                {
                    solution = Multiply(val1, val2);
                    Console.WriteLine($"The answer is {solution}.");
                }
                else if (calcType[0] == 'd')
                {
                    solution = Divide(val1, val2);
                    Console.WriteLine($"The answer is {solution}.");
                }
                else
                {
                    Console.WriteLine("Sorry, you cannot perform that type of calculation. Goodbye.");
                    Environment.Exit(100);
                }

                Console.WriteLine("\nDo you want to (A) perform a new calculation, (B) use the result of your previous calculation as " +
                                    "the first value in another caluclation, or (C) stop the application? >>");
                userChoice = Console.ReadLine();


            } while (userChoice.ToLower()[0] != 'c');





         
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
            Console.WriteLine(devMessage);
            
        }

    }
}
