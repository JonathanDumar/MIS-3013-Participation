using System;

namespace Collections_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randID = new Random();
            string[] studentIds = new string[3];

            for (int i = 0; i < studentIds.Length; i++)
            {
                studentIds[i] = randID.Next(10, 20).ToString();
            }
                        
            double[] studentGPAs = { 3.0, 4.0, 2.7 };

            //for (int i = 0; i < studentIds.Length; i++)
            //{
            //    string id = studentIds[i];
            //    Console.Write($"\t {id}");
            //}

            
            foreach (string id in studentIds)
            {
                Console.WriteLine($"\t {id}");
            }

            Console.WriteLine("Whose GPA do you want to see? >>");
            string idanswer = Console.ReadLine();

            for (int i = 0; i < studentIds.Length; i++)
            {
                if (studentIds[i] == idanswer)
                {
                    double gpa = studentGPAs[i];
                    Console.WriteLine($"{idanswer} has a {gpa.ToString("N2")} GPA.");
                }
            }

        }
    }
}
