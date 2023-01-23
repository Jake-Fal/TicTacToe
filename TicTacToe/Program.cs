using System;
// Jake Falagrady, Emma Engstrom, Michael Chase, Cameron Wilson 
namespace TicTacToe
{
    class Program
    {
        // main driver class
        static void Main(string[] args)
        {
            // welcome users
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            // initialize array 
            int[] board = new int[9];
            // loop through 9 guesses
            for (int i = 0; i < 8; i++)
            {
                if board[i] != 0 && board[i] != 1{
                // even numbers are player 1's guesses
                if (i % 2 == 0)
                {
                    Console.WriteLine("Player 1, it's your turn! Guess a number 1-9 (representing the tic-tac-toe squares): ");
                    temp = parse.Int(Console.ReadLine());
                    board[temp] = 0
                }
                else
                {
                    Console.WriteLine("Player 2, it's your turn! Guess a number 1-9 (representing the tic-tac-toe squares): ");
                    temp = parse.Int(Console.ReadLine());
                    board[temp] = 1
                }
            else
                    {
                Console.WriteLine("Sorry that square is already marked with " + parse.String(board[i]));
                i = i - 1 
                    }
            }
            // call the display board and check winner methods
            //displayBoard(board);
            //checkWinner(board);

            // check the bools returned by checkWinner() and display to user 
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
           // }
           // Console.WriteLine("Thanks for playing!")
        }

    }
}
}
