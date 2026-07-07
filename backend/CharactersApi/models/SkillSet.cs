namespace CharactersApi.Models;

/// <summary>
/// Set di abilità legate a UNA specifica arma.
/// </summary>
public class SkillSet
{
    public double PassiveCountDOwn{ get; set; }
    public string PassiveName { get; set; } = "";
    public string PassiveDescription { get; set; } = "";
    public string PassiveStatusDescription { get; set; } = "";
    public string AttackName { get; set; } = "";
    public string AttackDescription { get; set; } = "";
    public string AttackStatusDescription { get; set; } = "";
    public double CountdownSpecial {get; set;}
    public string SpecialName { get; set; } = "";
    public string SpecialDescription { get; set; } = "";
    public string SpecialStatusDescription {get; set;} = "";
    public double CountdownNormal {get; set;}
    public string NormalName { get; set; } = "";
    public string NormalDescription { get; set; } = "";
    public string NormalStatusDescription { get; set; } = "";
    public string TagName { get; set; } = "";
    public string TagDescription { get; set; } = "";
    public string TagStatusDescription { get; set; } = "";
    public double CountdownUltimate {get; set;}
    public int UsageMagicUltimate {get; set;}
    public string UltimateName { get; set; } = "";
    public string UltimateDescription { get; set; } = "";
    public string UltimateStatusDescription {get; set;} = "";
}