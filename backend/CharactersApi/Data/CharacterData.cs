using CharactersApi.Models;

namespace CharactersApi.Data;

public static class CharacterData
{
    public static List<Character> Characters = new()
    {
        new Character
        {
            Id = 1,
            Name = "Meliodas",
            AdventureSkill = "Esplorazione demoniaca",

            Weapons = new List<Weapon>
            {
                new Weapon
                {
                    Name = "Spada Demoniaca",
                    Skills = new SkillSet
                    {
                        Passive = "Rigenerazione",
                        Attack = "Colpo Oscuro",
                        Normal = "Slash",
                        Special = "Furia Demoniaca",
                        Tag = "Combo alleato",
                        Ultimate = "Re del Demone"
                    }
                },

                new Weapon
                {
                    Name = "Forma Piena",
                    Skills = new SkillSet
                    {
                        Passive = "Potere aumentato",
                        Attack = "Devastazione",
                        Normal = "Attacco base",
                        Special = "Inferno",
                        Tag = "Sinergia",
                        Ultimate = "Apocalisse"
                    }
                }
            }
        }
    };
}