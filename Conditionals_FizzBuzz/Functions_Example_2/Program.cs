using System;

namespace Functions_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer;
            do
            {
                Console.WriteLine("Please enter your grade >>");
                answer = Console.ReadLine();

                string lg = ConvertGradeToLetterGrade(Convert.ToDouble(answer));

                Console.WriteLine($"Congratulations, you have a {lg}!");
                
                Console.WriteLine("Do you want to convert another grade? (Yes or No");
                answer = Console.ReadLine().ToLower();

            } while (answer[1] == 'y');
            


        }


        /// <summary>
        /// Converts a number grade to a letter grade
        /// </summary>
        /// <param name="grade"> A double representing the number grade</param>
        /// <returns> The letter grade</returns>
        static string ConvertGradeToLetterGrade(double grade)
        {
            string letter = "";

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else if (grade >= 0)
            {
                letter = "F";
            }
            else
            {
                letter = "N/A";
            }



            return letter;
        }

    }
}
