using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            /*introduction();*/
            char player = 'X';
            char[,] board = new char[3, 3];
            bool gameOver = false;

            // Intializing Board function
            Intialize(board);

           /* board[0, 0] = player;
            player = 'O';
            board[2, 2] = player;
            player = 'X';*/

            Print(board); // Loads board for user input

            // Game plays until winner/loser/tie
            while (gameOver == false) // Ask about this part
            {
                
                              
                Console.Write("Please enter row:");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter column:");
                int col = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine(" row: " + row + " col: " + col);

                board[row, col] = player; // places X by player choice

                if (player == 'X')
                {

                    if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2]) // Across Board for X player
                    {
                        Console.WriteLine("Player X has won the game!");
                        gameOver = true;
                        Console.ReadKey();
                        break;
                    }

                    if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])  // Down Board for X Player
                    {
                        Console.WriteLine("Player X has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1]) // Middle Down
                    {
                        Console.WriteLine("Player X has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2]) // Right Down
                    {
                        Console.WriteLine("Player X has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 2] && player == board[1, 1] && player == board[2, 2])
                    {
                        Console.WriteLine("Player X has won the game!");
                        Console.ReadKey();
                    }

                    if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                    {
                        Console.WriteLine("Player X has won the game!");
                        Console.ReadKey();

                    }

                }
                

            if (player == 'O')
                {
                    if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2]) // Across Board for O player
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();
                        break;
                    }

                    if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])  // Down Board for O Player
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1]) // Middle Down
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2]) // Right Down
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();

                    }

                    if (player == board[0, 2] && player == board[1, 1] && player == board[2, 2])
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();
                    }

                    if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                    {
                        Console.WriteLine("Player O has won the game!");
                        Console.ReadKey();
                       }
                  


                    }


             player = ChangeTurn(player); // changes to O

                
                Print(board); // calling method 
                /*Console.Read(); */
            }
        }

        static char ChangeTurn(char currentPlayer) //  change into function for call
        {
            
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }




       /* public static void introduction()
        {
            Console.Title = ("Tic Tac Toe, Yo");
            Console.WriteLine("Welcome to Tic Tac Toe, Yo");
            Console.WriteLine("Press any key to continue");
        }*/

        static void Intialize(char[,] board) // Intializing Board -> called into function
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }


        //Printing Board
         static void Print(char[,] board)
        {
            /*Console.Write(" 0 1 2 ");*/
            for (int row = 0; row < 3; row++)
            {
                   
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }

        }


               
    }

    
}


/*
INPUT VALIDATION for ENTER NUMBER 
if {
int row =! 0 && int row != 1 && int row != 2 
}
*/