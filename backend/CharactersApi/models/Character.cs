namespace CharactersApi.Models;

/// <summary>
/// Personaggio principale.
/// Le sue abilità cambiano in base all'arma,
/// tranne l'abilità avventura.
/// </summary>
public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    // abilità che NON cambia mai
    public string AdventureSkill { get; set; } = "";

    public List<Weapon> Weapons { get; set; } = new();
}