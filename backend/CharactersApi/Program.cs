using CharactersApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CharacterService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Servizi (qui più avanti aggiungeremo Swagger, DB ecc.)
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

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

app.Run();