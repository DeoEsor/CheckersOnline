using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
namespace Models.Checkers
{
	public class Board : IEnumerable<Cell>
	{
		private readonly Cell[,] _area;

		public Checker this[int row, int column]
		{
			get => _area[row, column].Checker;
			set => _area[row, column].Checker = value;
		}

		public Board(int dimension)
		{
			_area = new Cell[dimension, dimension];
			for (var i = 0; i < _area.GetLength(0); i++)
				for (var j = 0; j < _area.GetLength(1); j++)
					_area[i, j] = new Cell(new Vector2(i,j),
						GetColor(i,j));
			
		}

		public static Color GetColor(int i, int j)
		{
			if (i % 2 == 0)
				return j % 2 == 0 ? Color.White : Color.Black;
			return j % 2 == 0 ? Color.Black : Color.White;
		}

		public IEnumerator<Cell> GetEnumerator() 
			=> _area.Cast<Cell>().GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() 
			=> _area.GetEnumerator();
	}
}
