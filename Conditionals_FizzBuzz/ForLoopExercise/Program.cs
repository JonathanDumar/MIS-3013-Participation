using System;

namespace ForLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //counting to 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //for (int i = 3; i <= 1000 ; i+= 3)
            {
               // Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("Blast Off");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
