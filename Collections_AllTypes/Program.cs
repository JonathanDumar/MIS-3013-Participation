using System;
using System.Collections.Generic;

namespace Collections_AllTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            // Problem 2
            List<double> prob2Grades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("What is your grade? >>");
                answer = Console.ReadLine();

                prob2Grades.Add(Convert.ToDouble(answer));

                Console.WriteLine("Do you have another grade to enter? (yes or no?)>>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');


            // Problem 3
            #region
            List<double> example = new List<double>();
            Dictionary<string, List<double>> coursegrades = new Dictionary<string, List<double>>();

            coursegrades.Add("MIS3013", new List<double>());
            coursegrades["MIS3013"].Add(0.75);
            coursegrades["MIS3013"].Add(0.95);
            coursegrades["MIS3013"].Add(0.90);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(1.00);
            MIS3033Grades.Add(0.95);
            MIS3033Grades.Add(0.80);
            coursegrades.Add("MIS3033", MIS3033Grades);

            coursegrades.Add("HON2000", new List<double>());
            coursegrades["HON2000"].Add(0.75);
            coursegrades["HON2000"].Add(0.95);
            coursegrades["HON2000"].Add(0.88);





            foreach (string courseCode in coursegrades.Keys)
            {
                double sum = 0;

                List<double> grades = coursegrades[courseCode];
                foreach (var value in grades)
                {
                    sum = sum + value;
                }
                Console.WriteLine(courseCode);
                
                double avg = sum / grades.Count;
              
                Console.WriteLine($"{avg.ToString("P")}");
            }
            #endregion




        }
    }
}
