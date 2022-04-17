using System;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Reddis
{
	public sealed class Reddis
	{
		public IDatabase Database = null;
		
		readonly ConnectionMultiplexer _redis = null;
		
		public async Task<TimeSpan> GetPong()
			=> await Database.PingAsync();

		public static Reddis CreateInstance(ConfigurationOptions options)
			=> new Reddis(options);

		private Reddis(ConfigurationOptions options)
		{
			_redis = 
				ConnectionMultiplexer.
					Connect(options);
			
			Database = _redis.GetDatabase();
		}
	}
}
