using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Multiplier = 7.777;
            double num1;
            double num2;
            double num3;


            Console.WriteLine("Please enter the first number >>");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number >>");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the third number >>");
            num3 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2 + num3;

            Console.WriteLine("The sum of the numbers >> " + sum.ToString("N3"));

            Console.WriteLine("Your sum multiplied by our magic number is " + sum * Multiplier);
        }
    }
}
