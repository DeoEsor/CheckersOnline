using System;
using System.Runtime.Serialization;
namespace Models.Checkers
{
	public partial class Checker
	{
		internal Checker(SerializationInfo info, StreamingContext context)
		{
			Owner = new Player(info, context);

			Type = (CheckerType)info.GetByte("Type");
		}
		
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{}
		
		[OnSerialized]
		private void OnSerialized(StreamingContext context)
		{}
		
		[OnDeserializing]
		private void OnDeserializing(StreamingContext context)
		{}
		
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{}
		
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{}
		
		void IDeserializationCallback.OnDeserialization(object? sender)
		{}
	}
}
