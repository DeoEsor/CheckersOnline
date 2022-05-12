using GamesHolder;
using Grpc.Core;

namespace GameDBServer.Services;

public class GamesHolderService : GamesHolder.GamesHolder.GamesHolderBase
{
    public override Task<AddGameReply> AddGame(AddGameRequest request, ServerCallContext context)
    {
        return base.AddGame(request, context);
    }

    public override Task<GetGameReply> GetGame(GetGameRequest request, ServerCallContext context)
    {
        return base.GetGame(request, context);
    }

    public override Task<GetUserGamesReply> GetGameByUser(GetUserGamesRequest request, ServerCallContext context)
    {
        return base.GetGameByUser(request, context);
    }
}