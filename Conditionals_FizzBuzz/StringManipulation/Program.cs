using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string artist = "tAylOr SwIFt";
            //string newValue = artist.ToLower();

            artist = artist.ToLower();

            string artistCAP = artist.ToUpper()[0] + artist.Substring(1, 6) + artist.ToUpper()[7] + artist.Substring(8);

            string realProblem = "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, ariANa gRAndE, bIlLiE eiLiSh";

            string[] artistNames = realProblem.Split(", ");

            for (int i = 0; i < artistNames.Length; i++)
            {

                string tist = artistNames[i].ToLower();
                //int spaceLocation = tist.IndexOf(' ');
                //string artistCAP = tist.ToUpper()[0] + tist.Substring(1, 6) + tist.ToUpper()[7] + tist.Substring(8);

                string[] names = tist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                firstName = firstName.ToUpper()[0] + firstName.Substring(1);
                lastName = lastName.ToUpper()[0] + lastName.Substring(1);

                Console.WriteLine(firstName + " " + lastName);
            }
                                           
                     
        }
    }
}
