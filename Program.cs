using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();

builder.AddGameStoreDb();

var app = builder.Build();

app.MigrateDB();

app.MapGamesEndpoints();
app.MapGenresEndpoints();

app.Run();
