using System;

namespace PriceCalcProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double weight;
            double quote;
            double hazardousCost;
            double netTotal;
            double discount;
            double total;
            string answer;

            do
            {
                Console.WriteLine("Please enter the number of miles >>");
                answer = Console.ReadLine();
                //miles = Convert.ToDouble(Console.ReadLine());
                bool isSuccessfull = double.TryParse(answer, out miles);

                if (isSuccessfull == false)
                {
                    Console.WriteLine("Your entry is invalid");

                    //return;
                    Environment.Exit(-1);
                }

                Console.WriteLine("Please enter the weight of your shipment in lbs >>");
                answer = Console.ReadLine();
                //miles = Convert.ToDouble(Console.ReadLine());
                //bool isSuccessfull = double.TryParse(answer, out weight);

                if (double.TryParse(answer, out weight) == false)
                {
                    Console.WriteLine("Your entry is invalid");

                    //return;
                    Environment.Exit(-2);
                }

                Console.WriteLine("Does your shipment contain hazardous material? yes or no?");
                answer = Console.ReadLine();

                quote = 0.55 * miles * 0.73 * weight;

                if (answer.ToLower() == "yes")
                {
                    hazardousCost = 0.15 * weight;
                }
                else
                {
                    hazardousCost = 0;
                }

                netTotal = quote + hazardousCost;
                

                if (miles < 150 && weight > 500)
                {
                    discount = 0.10 * netTotal;
                }
                else
                {
                    discount = 0;
                }

                total = netTotal - discount;

                Console.WriteLine("Quote:\t\t" + quote.ToString("C"));

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hazardous Cost:\t" + hazardousCost.ToString("C"));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Discount:\t" + discount.ToString("C"));
                            
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Total:\t\t" + total.ToString("C"));

                
                Console.WriteLine("\nDo you want to enter another shipment? yes or no? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Console.WriteLine("\nGoodbye!");


            
            


            Console.ReadKey();
        }
    }
}
