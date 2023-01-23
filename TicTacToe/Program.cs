using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            string[] board = new string[9];
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Player 1 Guess: ");
                    board[i] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Player 2 Guess: ");
                    board[i] = Console.ReadLine();
                }
            }
            //displayBoard(board);
            //checkWinner(board);

            //bool hasWinner, winnerIsPlayer1 = checkWinner();

            //if (hasWinner == true)
            //{
              //  if (winnerIsPlayer1 == true)
                //{
                  //  Console.WriteLine("Player 1 wins!");
                //}
               // else
                //{
                  //  Console.WriteLine("Player 2 wins!");
                //}
            //}
            //else
            //{
              //  Console.WriteLine("It was a tie.");
            }
        }

    }
}
}
