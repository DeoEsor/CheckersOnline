using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using UserDBServer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
var app = builder.Build();

app.MapGrpcService<GreeterService>();
app.Run();
