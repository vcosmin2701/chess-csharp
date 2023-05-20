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
			Exit = false; 
		}

		public bool Exit { get; set; }

	}
}
