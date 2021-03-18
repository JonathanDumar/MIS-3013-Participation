using System;
using System.Collections.Generic;
using System.IO;

namespace ReadingInCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("SoccerVsFootball.csv");
            List<string> states = new List<string>();
            List<double> soccerScores = new List<double>();
            List<double> footballScores = new List<double>();

            for (int i = 3; i < lines.Length; i++)
            {
                //Region/state, Soccer, Football
                //Alabama,16%,84%
                string line = lines[i];

                //    0       1     2
                //"Alabama","16%","84%"
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);

                string soccerScoreAsString = pieces[1].Remove(pieces[1].Length-1);
                double soccerScore = Convert.ToDouble(soccerScoreAsString) / 100;
                
                soccerScores.Add(soccerScore);

                string footballScoreAsString = pieces[2].Remove(pieces[2].Length - 1);
                double footballScore = Convert.ToDouble(footballScoreAsString) / 100;

                footballScores.Add(footballScore);

            }

            for (int i = 0; i < soccerScores.Count; i++)
            {
                string state = states[i];
                double soccer = soccerScores[i];
                double football = footballScores[i];

                if (soccer > football)
                {
                    Console.WriteLine(state);
                }
            }


            
        }
    }
}
