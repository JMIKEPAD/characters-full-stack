namespace CharactersApi.Models;

/// <summary>
/// Set di abilità legate a UNA specifica arma.
/// </summary>
public class SkillSet
{
    public string Passive { get; set; } = "";
    public string Attack { get; set; } = "";
    public string Normal { get; set; } = "";
    public string Special { get; set; } = "";
    public string Tag { get; set; } = "";
    public string Ultimate { get; set; } = "";
}