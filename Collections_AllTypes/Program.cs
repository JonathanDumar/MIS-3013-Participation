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
            // Problem 3

            List<double> example = new List<double>();
            Dictionary<string, List<double>> coursegrades = new Dictionary<string, List<double>>();

            coursegrades.Add("MIS3013", new List<double>());
            coursegrades["MIS3013"].Add(0.75);
            coursegrades["MIS3013"].Add(0.95);
            coursegrades["MIS3013"].Add(0.90);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(100);
            MIS3033Grades.Add(95);
            MIS3033Grades.Add(80);
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
              
                Console.WriteLine(sum);
                Console.WriteLine(avg);
            }





        }
    }
}
