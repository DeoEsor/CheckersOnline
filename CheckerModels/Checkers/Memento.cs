using System;
using System.Numerics;
// ReSharper disable MemberCanBePrivate.Global
namespace Models.Checkers
{
	public class Memento
	{
		public Guid Guid;
		private GameHistory _gameHistory = null!;
		public Checker Checker;

		public Vector2 Step;

		public int Round;
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="checker">Checker before step</param>
		/// <param name="step">Change of step</param>
		/// <param name="round">Current Round</param>
		private Memento(Checker checker, Vector2 step, int round)
		{
			Guid = Guid.NewGuid();
			Checker = checker;
			Step = step;
			Round = round;
		}
		public static Memento CreateInstance(Checker checker, Vector2 step, int round)
		{
			return new Memento(checker, step, round);
		}

		public override string ToString()
			=> $"{Checker.Color} : {Checker.Position} -> {Step}";
	}
}
