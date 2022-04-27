using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.Serialization;
namespace Models.Checkers
{
	public sealed partial class Checker :  ICloneable
	{
		public CheckerType Type;

		public Player Owner;

		public Vector2 Position;

		public Color Color => Owner.Color;

		public static Checker CreateInstance(Player player, Vector2 pos, CheckerType checkerType = CheckerType.Common)
		{
			return new Checker()
			{
				Owner = player,
				Position = pos,
				Type = checkerType
			};
		}

		internal Checker(){}

		public object Clone()
		{
			return new Checker()
			{
				Owner = this.Owner,
				Type = this.Type,
				Position = this.Position
			};
		}
	}
}
