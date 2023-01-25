using System;
using System.Linq;

public class GameBoard
{
	public static char[] board;
	public GameBoard(char[] newBoard) // constructor
	{
		board = newBoard;
	}
	public void displayBoard()
    {
		Console.WriteLine("     |     |     ");
		Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
		Console.WriteLine("_____|_____|_____");
		Console.WriteLine("     |     |     ");
		Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
		Console.WriteLine("_____|_____|_____");	   			 		   
		Console.WriteLine("     |     |     ");	   			 		   
		Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
		Console.WriteLine("     |     |     ");
	}

	public string checkWinner()
    {
		char winner;
		
		if (board[0] == board[1] && board[0] == board[2]) // check for 1st horizontal row
		{
			winner = board[0];
        }
		else if (board[3] == board[4] && board[5] == board[3]) // check for 2nd horizontal row
        {
			winner = board[3];
		}
		else if (board[6] == board[7] && board[6] == board[8]) // check for 3rd horizontal row
		{
			winner = board[6];
		}
		else if (board[0] == board[3] && board[0] == board[6]) // check for 1st vertical row
		{
			winner = board[0];
		}
		else if (board[1] == board[4] && board[7] == board[1]) // check for 2nd vertical row
		{
			winner = board[1];
		}
		else if (board[2] == board[5] && board[8] == board[3]) // check for 3rd vertical row
		{
			winner = board[2];
		}
		else if (board[0] == board[4] && board[8] == board[0]) // check for 1st diagonal row
		{
			winner = board[0];
		}
		else if (board[2] == board[4] && board[6] == board[2]) // check for 2nd diagonal row
		{
			winner = board[2];
		}
		else // if no winner has been found
        {
			if (board.Contains(' ')) // there are still spaces on the board
            {
				return "No winner yet";
            }
			else // no more spaces
            {
				return "Cat's scratch";
            }
        }
		if (winner == 'X')
        {
			return "Player 1 won";
        }
		else if (winner == 'O')
        {
			return "Player 2 won";
        }
		return "No winner yet";
	}
}
