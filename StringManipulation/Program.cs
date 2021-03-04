using System;

namespace StringManipulation
{
    class Program
    {

        static string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, " +
            "and the universe trying to build bigger and better idiots. So far, the universe is winning.";

        static void Main(string[] args)
        {
            Console.WriteLine(sentence);

            string searchWord;
            string replaceWord;

            Console.WriteLine("\nWhat word do you want to search for in the above sentence to replace?");
            searchWord = Console.ReadLine();

           
            bool validInput = sentence.Contains(searchWord);

            if (validInput == false)
            {
                Console.WriteLine("Sorry, I could not find your word " + searchWord);

                
                for (int i = searchWord.Length-1; i > -1; i--)
                {
                    Console.Write(searchWord[i]);
                }
            }

            else
            {
                Console.WriteLine("\nWhat word do you want to replace it with?");
                replaceWord = Console.ReadLine();

                sentence = sentence.Replace(searchWord, replaceWord);


                Console.WriteLine(sentence);
                //Console.WriteLine(sentence, sentence.Replace(searchWord, replaceWord));

            }









        }
    }
}
