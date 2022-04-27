
using Microsoft.Practices.Unity.Configuration;
using Unity;
namespace GameDBServer
{
	public class Startup
	{	
		public void ConfigureContainer(IUnityContainer container)
		{
			container.LoadConfiguration();
		}
	}
}
