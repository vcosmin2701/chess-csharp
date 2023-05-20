using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace chess_csharp
{
	public class ChessBoard
	{
		private string[,] chessBoard;
		public const int DIMENSION = 8;

		private Move move;

		public ChessBoard()
		{
			move = new Move();
			chessBoard = new string[DIMENSION, DIMENSION];
			ChessBoardHorizontalSymbol = "+---";
			ChessBoardVerticalSymbol = "|  ";
		}

		public void displayChessBoard()
		{
			while (!move.Exit)
			{
				Console.Clear();
				Console.WriteLine("    0   1   2   3   4   5   6   7");
				for(int rows = 0; rows < DIMENSION; rows++)
				{
					Console.Write("  ");
					for(int cols = 0; cols < DIMENSION; cols++)
					{
						Console.Write(ChessBoardHorizontalSymbol);
					}
					Console.Write("+\n");

					for (int cols = 0; cols < DIMENSION; cols++)
					{
						if(cols == 0)
						{
							Console.Write($"{rows} ");
						}
		
						Console.Write(ChessBoardVerticalSymbol + Pawn.pawns[rows, cols] + " ");
					}
					Console.Write("|\n");
				}

				Console.Write("  ");
				for(int cols = 0; cols < DIMENSION; cols++)
				{
					Console.Write(ChessBoardHorizontalSymbol);
				}

				Console.Write("+\n\n");
			}
		}

		public string ChessBoardHorizontalSymbol { get; set; }
		public string ChessBoardVerticalSymbol { get; set; }
	}
}
