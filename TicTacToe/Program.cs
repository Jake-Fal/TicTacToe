using System;
using static GameBoard;
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
            char[] board = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            // loop through 9 guesses
            for (int i = 0; i < 9; i++)
            {
                // even numbers are player 1's guesses
                if (i % 2 == 0)
                {
                    // let player one guess a square, determine the square is empty, if so, mark with an 'X'
                    Console.WriteLine("Player 1, it's your turn! Guess a number 1-9 (representing the tic-tac-toe squares): ");
                    int temp = Int32.Parse(Console.ReadLine());
                    while (temp < 1 || temp > 9)
                    {
                        Console.WriteLine("Number must be between 1-9. Guess again: ");
                        temp = Int32.Parse(Console.ReadLine());
                    }
                    if ((board[temp-1] != 'X') && (board[temp -1] != 'O')) {
                        board[temp-1] = 'X';
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
                    int temp = Int32.Parse(Console.ReadLine());
                    while (temp < 1 || temp > 9)
                    {
                        Console.WriteLine("Number must be between 1-9. Guess again: ");
                        temp = Int32.Parse(Console.ReadLine());
                    }
                    if (board[temp-1] != 'X' && board[temp-1] != 'O') {
                        board[temp-1] = 'O';
                    }
                    else
                    {
                        // if square is filled, notify user and decrement counter
                        Console.WriteLine("Sorry that square is already marked with " + board[temp-1]);
                        i = i - 1;
                    }


                }
                // create instance of other class
                GameBoard myBoard = new GameBoard(board);
                // call the display board method
                myBoard.displayBoard();

                // check the string returned by checkWinner() and display to user 
                string winString = myBoard.checkWinner();
                if (winString != "No winner yet") {
                    Console.WriteLine(winString);
                    break;
                }
            }

            // thank user and exit program
            Console.WriteLine("Thanks for playing!");

    }
}
}
