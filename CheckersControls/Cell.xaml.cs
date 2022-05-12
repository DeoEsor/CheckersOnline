using System.Drawing;
using System.Numerics;
using System.Windows.Controls;
using Models.Checkers;

namespace CheckersControls
{
	public partial class Cell : UserControl
	{
		public Cell(Board board,int x, int y, Color color)
		{
			Model = new Models.Checkers.Cell(board,new Vector2(x, y), color);
			InitializeComponent();
		}

		private Models.Checkers.Cell _model;
		public Models.Checkers.Cell Model
		{
			get => _model;
			set => _model = value;
		}
	}
}

