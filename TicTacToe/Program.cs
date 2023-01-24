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
            char[] board = new char[" "," "," "," "," "," "," "," "," "];
            // loop through 9 guesses
            for (int i = 0; i < 8; i++)
            {
                // even numbers are player 1's guesses
                if (i % 2 == 0)
                {
                    // let player one guess a square, determine the square is empty, if so, mark with an 'X'
                    Console.WriteLine("Player 1, it's your turn! Guess a number 1-9 (representing the tic-tac-toe squares): ");
                    temp = parse.Int(Console.ReadLine());
                    if board[temp] != "X" && board[i] != "O" {
                    board[temp] = "X";
                }
                   else
                    {
                // if the square is marked, decrement the counter to reset the guess
                Console.WriteLine("Sorry that square is already marked with " + board[i]);
                i = i - 1;
                    }

                    }
                else
                {
                    // player two guesses, check square, mark sqaure with 'O'
                    Console.WriteLine("Player 2, it's your turn! Guess a number 1-9 (representing the tic-tac-toe squares): ");
                    temp = parse.Int(Console.ReadLine());
                       if board[temp] != "X" && board[i] != "O" {
                    board[temp] = "O";
                }
                  else
                    {
                // if square is filled, notify user and decrement counter
                Console.WriteLine("Sorry that square is already marked with " + board[i]);
                i = i - 1 
                    }


            }
            // call the display board method
            displayBoard();
                
            // check the string returned by checkWinner() and display to user 
            string winString = checkWinner();
                if winString != "No winner yet"{
                Console.WriteLine(winString);
                        }
                else
                {
                    break;
                }

                }

            // thank user and exit program
            Console.WriteLine("Thanks for playing!")

    }
}
}
