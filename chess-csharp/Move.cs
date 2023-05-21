using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_csharp
{
	public class Move : Pawn
	{
		//Coordinates of the pawn we want to move
		private int targetX;
		private int targetY;
		private int destinationX;
		private int destinationY;
	

		public Move()
		{
			targetX = 0;
			targetY = 0;
			destinationX = 0;
			destinationY = 0;
			PlayerTurn = 1;
			Exit = false; 
		}

		public bool Exit { get; set; }
		private int PlayerTurn { get; set; }

		public void MakeMove()
		{
			double distancePawn = Math.Sqrt(Math.Pow(targetX - destinationX, 2) - Math.Pow(targetY - destinationY, 2));
			switch (PlayerTurn)
			{
				case 1:
					Console.WriteLine("Light's TURN. Please select light pawn.(P)");
					getInput();
					if (!Exit)
					{
						rearangePawns();
					}
					PlayerTurn = 2;
					break;
				case 2:
					Console.WriteLine($"Dark's TURN. Please select dark pawn.({'\u00B6'})");
					getInput();
					if (!Exit)
					{
						rearangePawns();
					}
					PlayerTurn = 1;
					break;
				default:
					Console.WriteLine("Something went wrong");
					break;
			}
		}

		private void getInput()
		{
			Console.WriteLine("Enter Target's X axis");
			Exit = validateInput(int.TryParse(Console.ReadLine(), out targetX));

			if (!Exit)
			{
				Console.WriteLine("Enter Target's Y axis");
				Exit = validateInput(int.TryParse(Console.ReadLine(), out targetX));
			}

			if (!Exit)
			{
				Console.WriteLine("Enter Destination's X axis");
				Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationX));
			}

			if (!Exit)
			{
				Console.WriteLine("Enter Destination's Y axis");
				Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationY));
			}

		}

		private bool validateInput(bool parsed)
		{
			bool error = false;
			

			if (!parsed)
			{
				error = true;
			}else if(targetX < 0 || targetY < 0 || destinationX < 0 || destinationY < 0) {
				error = true;
			}else if(targetX > ChessBoard.DIMENSION-1 || targetY > ChessBoard.DIMENSION - 1 ||
				destinationX > ChessBoard.DIMENSION - 1 || destinationY > ChessBoard.DIMENSION - 1)
			{
				error = true;
			}

			if (error)
			{
				Console.WriteLine("Invalid input. Exiting program now.");
			}

			return error;
		}

		private void rearangePawns()
		{
			pawns[destinationX, destinationY] = pawns[targetX, targetY];
			pawns[targetX, targetY] = SPACE;
		}

		private void ValidatePawnMoveRule(int x, int y, int xd, int yd)
		{
			double distance = Math.Sqrt(Math.Pow(xd - x, 2) - Math.Pow(yd - y, 2));
			for (int i = 0; i < ChessBoard.DIMENSION; i++)
			{
				for (int j = 0; j < ChessBoard.DIMENSION; j++)
				{
					if (distance > 2 && (x == ChessBoard.DIMENSION - 7 && y == ChessBoard.DIMENSION - 7))
					{
						Console.WriteLine("Illegal move for a pawn from initial position");
						break;
					}
					else if (distance > 2 && (x == ChessBoard.DIMENSION - 2 && y == ChessBoard.DIMENSION - 2))
					{
						Console.WriteLine("Illegal move for a pawn from initial position");
						break;
					}
				}
			}
		}
	}
}
