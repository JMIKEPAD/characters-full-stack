namespace CharactersApi.Models;

/// <summary>
/// Rappresenta un'arma del personaggio.
/// Ogni arma modifica le abilità del personaggio.
/// </summary>
public class Weapon
{
    public string Name { get; set; } = "";

    public SkillSet Skills { get; set; } = new();
}