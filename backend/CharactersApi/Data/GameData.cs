using CharactersApi.Models;

namespace CharactersApi.Data;

/// <summary>
/// Simula il database dei giochi
/// </summary>
public static class GameData
{
    public static List<Game> Games = new()
    {
        new Game
        {
            id = 1,
            Name = "The Seven Deadly Sins: Origin"
        }
    };
}