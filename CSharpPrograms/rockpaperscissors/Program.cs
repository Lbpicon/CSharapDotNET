using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart = "Y";

            while (restart == "Y")
            {

                //user chooses rock, paper, or scissors
                Console.WriteLine("Choose your fate. Rock , Paper, or Scissors?");
                string weapon = Console.ReadLine();
                weapon = weapon.ToLower(); // any input is automatically lowercase


                Random generator = new Random();
                int randomNumber = generator.Next(0, 3);

                if (randomNumber == 0)
                {
                    if (weapon == "paper")
                    { Console.WriteLine("it's a tie"); }

                    else if (weapon == "rock")
                    { Console.WriteLine("you win"); }
                    else if (weapon == "scissors")
                    { Console.WriteLine("you lost"); }
                    else
                    { Console.WriteLine("you must pick rock, paper, or scissors!!"); }
                }


                else if (randomNumber == 1)
                {
                    if (weapon == "rock")
                    { Console.WriteLine("it's a tie"); }

                    else if (weapon == "scissors")
                    { Console.WriteLine(" You win"); }

                    else if (weapon == "paper")
                    { Console.WriteLine("u lose- womp-womp"); }

                    else
                    { Console.WriteLine("you must pick rock, paper, scissors!"); }
                }
                else if (randomNumber == 2)
                {
                    if (weapon == "scissors")
                    { Console.WriteLine("it's a tie"); }

                    else if (weapon == "rock")
                    { Console.WriteLine("You lose - womp-womp"); }

                    else if (weapon == "paper")
                    { Console.WriteLine("You win!!!"); }

                    else
                    {
                        Console.WriteLine("you must pick rock, paper, or scissors!");
                    }



                }
                // w int[] score = new int[z];
                // score[0] = score[0] +1;
                // score[1] = score[1] +1;
                // Console.WriteLine("user score is "+ score[0]);
                Console.WriteLine("Do you want to play again? Y or N");
                restart = Console.ReadLine();
                restart = restart.ToUpper(); //statement

                
                while (restart != "Y" && restart != "N") /*expression*/ {
                    Console.WriteLine("You must choose Y or N.");
                    restart = Console.ReadLine();
                }
            }
        }
    }
}
            
       
