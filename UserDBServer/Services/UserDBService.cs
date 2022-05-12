using System.Threading.Tasks;
using Authenticator;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using UserDBServer;
namespace UserDBServer.Services
{
	public class UserDbService : Authenticator.Authenticator.AuthenticatorBase
	{
		public override Task<AuthenticatorReply> Authenticate(AuthenticatorRequest request, ServerCallContext context)
		{
			return base.Authenticate(request, context); 
		}

		public override Task<PersonalDataReply> GetPersonalData(PersonalDataRequest request, ServerCallContext context)
		{
			return base.GetPersonalData(request, context);
		}
	}
}