using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using Models.Annotations;
namespace Models.Checkers
{
	public sealed class Cell : INotifyPropertyChanged
	{
		private Color color;
		private Checker checker = null!;
		private Vector2 position;

		public Cell(Vector2 pos, Color color)
		{
			Color = color;
			Position = pos;
		}
		public Vector2 Position
		{
			get => position;
			set
			{
				position = value;
				OnPropertyChanged();
			}
		}
		public Checker Checker
		{
			get => checker;
			set
			{
				checker = value;
				OnPropertyChanged();
			}
		}
		public Color Color
		{
			get => color;
			set => color = value;
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null!)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
