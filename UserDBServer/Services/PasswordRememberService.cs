using Authenticator;
using Grpc.Core;

namespace UserDBServer.Services;

public class PasswordRememberService : Authenticator.RememberPassword.RememberPasswordBase
{
    public override Task<RememberPasswordReply> RememberPassword(RememberPasswordRequest request, ServerCallContext context)
    {
        return base.RememberPassword(request, context);
    }
}