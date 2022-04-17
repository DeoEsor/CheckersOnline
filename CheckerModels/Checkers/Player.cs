using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.Serialization;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ConvertToAutoProperty
namespace Models.Checkers
{
	public partial class Player : ISerializable, IDeserializationCallback
	{
		private Guid _id;
		private string _name;

		public Color Color;
		
		public ObservableCollection<Checker> Checkers;

		public Player()
		{
			//Checkers.CollectionChanged += CheckersOnCollectionChanged;
		}
		public string Name
		{
			get => _name;
			set => _name = value;
		}
		public Guid Id
		{
			get => _id;
			internal init => _id = value;
		}
		private void CheckersOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{

				case NotifyCollectionChangedAction.Add:
					break;
				case NotifyCollectionChangedAction.Remove:
					break;
				case NotifyCollectionChangedAction.Replace:
					break;
				case NotifyCollectionChangedAction.Move:
					break;
				case NotifyCollectionChangedAction.Reset:
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

	}
}
