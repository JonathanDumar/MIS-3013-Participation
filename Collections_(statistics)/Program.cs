using System;
using System.Collections.Generic;

namespace Collections__statistics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> grades = new Dictionary<double, int>();

            string gradeAns;
            double grade;
            string YesNo = "yes";            
            int mode = 0;

            do
            {
                Console.WriteLine("Please enter your exam grade? >>");
                gradeAns = Console.ReadLine();

                if (double.TryParse(gradeAns, out grade) == false)
                {
                    Console.WriteLine("Invalid input. Goodbye.");
                    Environment.Exit(500);
                }
                else
                {

                    if (grades.ContainsKey(grade) == false)
                    {
                        grades.Add(grade, 1);
                    }
                    else
                    {
                        grades[grade] = grades[grade] + 1;
                    }

                    //grades.Add(grade, x);

                }


                Console.WriteLine("Do you have any other scores to enter? (Yes or No)");
                YesNo = Console.ReadLine();

            } while (YesNo.ToLower() != "no");

            //foreach (var gradeEntry in grades.Values)
            //{
            //    Console.WriteLine(gradeEntry);
            //}

            double max = 0;

            foreach (double key in grades.Keys)
            {
                if (key > max)
                {
                    max = key;
                }
            }


            double min = max;

            foreach (double key in grades.Keys)
            {
                if (key < min)
                {
                    min = key;
                }
            }

            
            foreach (var key in grades.Keys)
            {
                double gradeScore = key;
                if (grades[gradeScore] > mode)
                {
                    mode = grades[gradeScore];
                }
            }

            foreach(var key in grades.Keys)
            {
                double gradeScore = key;
                if (grades[gradeScore] == mode)
                {
                    Console.WriteLine($"\nThe mode is {gradeScore} which appeared {mode} times.");
                }
            }

            double sum = 0;

            foreach (var key in grades.Keys)
            {
                double gradeScore = key;
                sum = sum + gradeScore;                
            }

            double average = sum / grades.Keys.Count;

            Console.WriteLine($"\nThe average grade is {average.ToString("N2")}");
            Console.WriteLine($"\nThe maximum grade is {max.ToString("N2")}");
            Console.WriteLine($"\nThe minimum grade is {min.ToString("N2")}");



        }
    }
}
