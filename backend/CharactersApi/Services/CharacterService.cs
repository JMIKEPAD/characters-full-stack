using CharactersApi.Data;
using CharactersApi.Models;

namespace CharactersApi.Services;

public class CharacterService
{
    /// <summary>
    /// Restituisce tutti i personaggi
    /// </summary>
    public List<Character> GetAll()
    {
        return CharacterData.Characters;
    }

    /// <summary>
    /// Restituisce un personaggio specifico
    /// </summary>
    public Character? GetById(int id)
    {
        return CharacterData.Characters
            .FirstOrDefault(c => c.Id == id);
    }

    
}