using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towershannoi
{
    class Program
    {
        static void Main(string[] args)
        {
            introduction();

          
            Console.Read();
        }
    }
}

static void introduction()
{   // introduction
    Console.WriteLine("Ready to play Towers of Hannoi? Enter your name.");
    string name = Console.ReadLine();
    Console.WriteLine("Hi {0}, Let's play. Press any 'P' key to continue.", name);
    string play = "P";
    play = play.ToUpper(); // any input is automatically capitalized
}