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
             //Asking for translation
            Console.WriteLine("Enter a word for pig latin translation");
            string input = Console.ReadLine();
            pigLatin(input);
            Console.ReadLine();
          
        }

        public static string pigLatin(string input)
        {
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'A','E','I','O','U' }; //vowels upper case and lowercase
            int firstVowel = input.IndexOfAny(chars);
            if (firstVowel == -1)

            {
                char[] charsy = { 'y', 'Y' };
                int yAsAVowel = input.IndexOfAny(charsy);
                return input.Substring(yAsAVowel) + input.Substring(0, yAsAVowel) + "ay";
            }

            else if (firstVowel == 0) // equal == comparison
            {   
                bool lastLetterVowel = input.EndsWith("a") || input.EndsWith("e") || input.EndsWith("i") || input.EndsWith("o") || input.EndsWith("u");
                if (lastLetterVowel == true) //if boolean conditions are true
                {
                    return input.Substring(firstVowel) + input.Substring(0, firstVowel) + "yay";
                }

                else
                {
                    return input.Substring(firstVowel) + input.Substring(0, firstVowel) + "ay";
                }
            }

            else
            {
                return input.Substring(firstVowel) + input.Substring(0, firstVowel) + "yay";
            }
            
            }

            
                                     }

}
    


  /*for (int i = 0; i<vowels.Length - 1; i++)
            {
                string currentVowel = vowels[i].ToString();*/