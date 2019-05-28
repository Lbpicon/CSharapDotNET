using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findlongestword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the longest string.");

            //Prompt usre to enter long sentense
            Console.WriteLine("Enter a sentence and I will find the longest word in it");
            // Store user's sentence
            string userSentence = Console.ReadLine().Trim();

            //Logic
            //1. Split the sentence into individual words
            string[] userWords = userSentence.Split(' ');

            //2.Remove punctuation
            //2.1 We need a char array for all punctuation symbols
            char[] punctuation = new char[] { ',', '.', '!', '?', ':', '"', ';' };
            //2.2 Let us loop through the words array and remove punctuation from each word
            string longestWord = "";
            string tempWord = "";
            int wordLength = 0;

            for (int = 0; int < punctuation.Length; int++)
            {
                tempWord = word
            }


        }
    }
}
