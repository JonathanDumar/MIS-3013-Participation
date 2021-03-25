using System;
using System.Collections.Generic;

namespace Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();

            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 3.5);

            foreach (var studentID in students.Keys)
            {
                Console.Write($"\t {studentID}");   
            }

            Console.WriteLine("\nWhose GPA do you want to see? >>");
            string idAnswer = Console.ReadLine();

            if (students.ContainsKey(idAnswer) == true)
            {
                Console.WriteLine($"{idAnswer} has a {students[idAnswer].ToString("N2")} GPA.");
            }
            else
            {
                Console.WriteLine("Invalid student ID.");
                Environment.Exit(1);
            }
        }
    }
}
