using System;
using System.Collections.Generic;

namespace Collections__statistics__List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();

            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Do you have another grade to enter? yes or no? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] != 'n');

            foreach (var grade in grades)
            {
                //Console.Write(grade);
            }



        }
    }
}
