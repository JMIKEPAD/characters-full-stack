using Microsoft.EntityFrameworkCore;
using CharactersApi.Data;
using CharactersApi.Services;
using Database.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CharacterService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Servizi (qui più avanti aggiungeremo Swagger, DB ecc.)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=Data/database.db");
});



var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowAngular");

/// <summary>
/// Tutti i personaggi
/// </summary>
app.MapGet("/characters", (CharacterService service) =>
{
    return service.GetAll();
});

/// <summary>
/// Singolo personaggio
/// </summary>
app.MapGet("/characters/{id}", (CharacterService service, int id) =>
{
    return service.GetById(id);
});

app.MapGet("/db-test", async (AppDbContext db) =>
{
    return "Database collegato!";
});

//test
var databaseService = new DatabaseService();
databaseService.GetTables();

app.Run();