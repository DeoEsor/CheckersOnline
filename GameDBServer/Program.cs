using GameDBServer;
using GameDBServer.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using Unity;
using Unity.Microsoft.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

IWebHostBuilder CreateWebHostBuilder(string[] args) =>
	WebHost.CreateDefaultBuilder(args)
		.UseUnityServiceProvider()
		.UseStartup<Startup>();

builder.Services.AddGrpc();
var redisConnection = await ConnectionMultiplexer.ConnectAsync("127.0.0.1:6379");
var redisDatabase = redisConnection.GetDatabase();
var app = builder.Build();

app.MapGrpcService<GamesHolderService>();
app.Run();
