using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_csharp
{
	public class Pawn
	{
		public const char PAWN_SYMBOL = 'X';
		public const char SPACE = ' ';
		public static char[,] pawns;

		public Pawn()
		{
			pawns = new char[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
		}

	}
}
