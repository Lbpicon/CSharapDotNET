using System;

namespace TicTacToe
{
    class Program
    {


        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {"   ", "   ", "   "},
            new string[] {"   ", "   ", "   "},
            new string[] {"   ", "   ", "   "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        #region
        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int col = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int col)
        {
           if playerTurn == 

        }
         { 
            
        
            
            
        }




        }
        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            // your code goes here

            return false;
        }

        public static bool VerticalWin()
        {
            // your code goes here

            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here

            return false;
        }
        #endregion
        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join(" | ", board[0]));
            Console.WriteLine("  ----------");
            Console.WriteLine("1 " + String.Join(" | ", board[1]));
            Console.WriteLine("  ----------");
            Console.WriteLine("2 " + String.Join(" | ", board[2]));
        }

        public static void BoardLayout()
        {
            for (int j=0; j < 3; j++)
            {
                Console.WriteLine("|");
            for (int k=0; k < 3; k++)
                {
                    Console.Write("| X ");
                }
            }
        }
        


        }
    }


/*for (int i=0; i<3; i++)
 { console.write("| ");
 }
 Console.WriteLine("|");
 }

   Console.WriteLine("-------");*/