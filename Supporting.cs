using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_4
{
    public class TicTacToeBoard
    {
        public void PrintBoard(string[,] board)
        {
            Console.Clear();
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   ", board[0, 0], board[0,1], board[0,2]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   ", board[1, 0], board[1,1], board[1,2]);
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}   |  {1}   ", board[2, 0], board[2,1], board[2,2]);
            Console.WriteLine("      |      |     ");
        }

        public static string Winner(string[,] board, int turns)
        {
            // Creating a loop to check for possible winners by rows
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1]) && (board[i, 1] == board[i, 2]) && (board[i, 0] != " "))
                {
                    return $"{board[0, i]} is the winner!!";
                }
            }

            // Creating a loop to check for possible winner by columns
            for (int i = 0; i < 3; i++)
            {
                // Checking to see if there was a winner by columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != " ")
                {
                    return $"{board[0, i]} is the winner!!";
                }
            }

            // Checking to see if there was a winner by diagonal
            if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]) && (board[0, 0] != " "))
            {
                return $"{board[0, 0]} is the winner!!";
            }
            if ((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]) && (board[0, 2] != " "))
            {
                return $"{board[0, 2]} is the winner!!";
            }
            
            // Return nothing if there is no winner
            return null;
        }

  

    }
}

// Receive the "board" array from the driver class

// Contain the method that prints the board based on the information passed to it

/* Contain a method that receives the game board array as input and returns if there is a winner
 and who it was */