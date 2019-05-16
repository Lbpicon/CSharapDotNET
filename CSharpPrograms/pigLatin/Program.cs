using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MakePigLatin(str));
            string input = Console.ReadLine();
            // Translate the word to Pig Latin
            string convertedWord = ToPigLatin(input);
            Console.WriteLine(convertedWord);
        }

        public static void ToPigLatin (string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool startWithVowel = false;
            bool endWithVowel = false;
            bool foundVowel = false;

            for (int i = 0; i < vowels.Length - 1; i++)
            {
                string currentVowel = vowels[i].ToString();

            }
        }
        
    }
}
