using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using Models.Annotations;
namespace Models.Checkers
{
	public class GameHistory : INotifyPropertyChanged
	{
		private Guid _id;
		 
		public Guid Id
		{
			get => _id;
			init => _id = value;
		}
		public Memento State
		{
			get => _state;
			set
			{
				_state = value;
				OnPropertyChanged();
			}
		}

		private Memento _state;

		public List<Memento> States;
		
		public void SetMemento(Memento memento)=>State = memento;
		
		public Memento Remember(Checker checker, Vector2 step, int round)
		{
			var memento = Checkers.Memento.CreateInstance(checker, step, round);
			States.Add(memento);
			return memento;
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
