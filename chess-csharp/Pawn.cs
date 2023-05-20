using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_csharp
{
	public class Pawn
	{
		public const char PAWN_SYMBOL_LIGHT = 'P'; // PAWN LIGHT
		public const char PAWN_SYMBOL_DARK = '\u00B6'; // PAWN DARK
		public const char SPACE = ' ';
		public static char[,] pawns;

		public Pawn()
		{
			pawns = new char[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
			InitPawn();
		}

		private void InitPawn()
		{
			for (int rows = 0; rows < ChessBoard.DIMENSION; rows++)
			{
				for (int cols = 0; cols < ChessBoard.DIMENSION; cols++)
				{
					if (rows == ChessBoard.DIMENSION - 7)
					{
						pawns[rows, cols] = PAWN_SYMBOL_LIGHT;
					}else if(rows == ChessBoard.DIMENSION - 2)
					{
						pawns[rows, cols] = PAWN_SYMBOL_DARK;
					}
					else
					{
						pawns[rows, cols] = SPACE;
					}
				}
			}
		}
	}
}
