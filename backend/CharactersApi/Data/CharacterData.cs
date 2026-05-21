using CharactersApi.Models;

namespace CharactersApi.Data;

public static class CharacterData
{
    public static List<Character> Characters = new()
    {
        new Character
        {
            Id = 1,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_meliodas_001.png",
            Name = "Meliodas",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Spada Lunga",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Ascia",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Doppia Spada",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },

        new Character
        {
            Id = 2,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_escanor_001.png",
            Name = "Escanor",
            AdventureSkillName = "Spaccatura nel tempo",
            AdventureSkillDescription = "Con la distorsione spazio-temporale, le statistiche non subiscoino più l'influenza del tempo",
            Weapons =
            [
                new Weapon
                {
                    Name = "Ascia",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Deflagrazione solare",
                        PassiveDescription = "Ottiene 1 accumulo/i di punto solare per 20s quando attacca un nemico senza bagliore o sole calante attivi",
                        PassiveStatusDescription = "Punto solare: aumenta i danni fuoco di un 3% e i ps massimi di un 1.5% per ogni 1 accumulo/i. Quanbdo viene raggiunta la quantità massima di accumuli, rimuove punto solare e ottiene bagliore per 15s|Bagliore: rirpristina un 10% dei ps massimi la prima volta che viene concesso l'effetto. Aumenta i danni fuoco di un 50% e i ps massimi dell'eroe di un 25%, e riduce i danni subiti di un 20%. Ottieni sole calante per 10s quando bagliore viene rimosso.| Sole calante: riduce i ps massimi dell'eroe di un 25% mantenendo invariati i ps massimi",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Spadone",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Spada e scudo",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 3,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_daisy_001.png",
            Name = "Daisy",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Scudo e spada",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Libro",
                    Element = "Elettricità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Bacchetta",
                    Element = "Vento",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 4,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_diane_001.png",
            Name = "Diane",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Ascia",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Guanti",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Nunchaku",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 5,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_drake_001.png",
            Name = "Drake",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Spadone",
                    Element = "Elettricità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Bastone",
                    Element = "Elettricità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Spada lunga",
                    Element = "elettricità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 6,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_elaine_001.png",
            Name = "Elaine",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Bacchetta",
                    Element = "vento",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Bastone",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Libro",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 7,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_guila_001.png",
            Name = "Guila",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Lancia",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Spada e scudo",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 8,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_jericho_001.png",
            Name = "Jericho",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Doppia spada",
                    Element = "Ghiaccio",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Lancia",
                    Element = "Ghiaccio",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Ghiaccio",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 9,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_king_001.png",
            Name = "King",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Bastone",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Libro",
                    Element = "Fisico",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Bacchetta",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 10,
            Rarity = "SSR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_manny_001.png",
            Name = "Manny",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Bastone",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Doppia spada",
                    Element = "Ghiaccio",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Spada lunga",
                    Element = "Ghiaccio",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 11,
            Rarity = "SR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_bug_001.png",
            Name = "Bug",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Ascia",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Doppia spada",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Libro",
                    Element = "Oscurità",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 12,
            Rarity = "SR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_dreydrin_001.png",
            Name = "Dreydrin",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Scudo e spada",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Ascia",
                    Element = "Fisico",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 13,
            Rarity = "SR",
            LinkPortrait = "https://sunderarmor.com/7DSO/Live/portraits/slot_dreyfus_001.png",
            Name = "Dreyfus",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Fisico",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestria della velocità",
                        PassiveDescription = "Riduce la durata di esplosione di oscurità di 2 sec e infligge danni aggiuntivi pari al 200% dell'attacco mette a segno l'abilità normale su un nemico con esplosione di oscurità attiva",
                        PassiveStatusDescription = "",
                        AttackName = "Squarcio oscuro",
                        AttackDescription = "infligge danni pari al 160% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 42%, 4° hit: 68%",
                        CountdownSpecial = 17,
                        SpecialName = "Scatto dell'abisso",
                        SpecialDescription = "Ottiene fretta per 7s e infligge danni pari a un 93% dell'attacco. Azzera il tempo di ricarica quando attacca un nemico con esplosione di oscurità attiva",
                        SpecialStatusDescription = "Fretta: aumenta i danni da maestria della velocità di un 25% e l'attacco di tipo oscurità di un 15%. (Massimo: 2 volte)",
                        CountdownNormal = 27, 
                        NormalName = "Sequenza di attacchi",
                        NormalDescription = "Infligge danni pari a un 286% dell'attacco. Ogni colpo su un nemico con esplosione di oscurità attiva riduce il tempo di ricarica di 2 sec per ogni 1 accumo di fretta",
                        TagName = "Forza oscura",
                        TagDescription = "infligge danni pari a un 133% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Croce ardente",
                        UltimateDescription = "Infligge danni pari a un 449% dell'attacco e attaccare i nemici con esplosione di oscurità attiva aumenta i danni di un 100%. Il colpo finale rimuove l'esplosione di oscurità del bersaglio. Usare un attacco combinato con la mossa suprema dell'eroe come base infligge apertura sul nemico per 20 sec",
                        UltimateStatusDescription = "Apertura: aumenta i danni subiti da maestria della velocità di un 50%"
                    }
                },

                new Weapon
                {
                    Name = "Spada lunga",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dei colpi",
                        PassiveDescription = "Infligge energia demoniaca a un nemico che è già stato colpito da energia demoniaca rimuoverà immediatamente l'effetto di energia demoniaca esistente. Ottiene rilascio infernale per 10 sec ogni volta che energia demoniaca viene rimossa dal nemico. (Massimo: 3 volte)",
                        PassiveStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.| Rilascio infernale: aumenta i danni oscurità di un 30%.",
                        AttackName = "Ascia oscura",
                        AttackDescription = "infligge danni pari al 164% dell'attacco, 1° hit: 24%, 2° hit: 27%, 3° hit: 42%, 4° hit: 71%",
                        CountdownSpecial = 25.8,
                        SpecialName = "Distruzione potente dell'abisso",
                        SpecialDescription = "Infligge danni pari a un 140% / 302% dell'attacco in base al livello di carica. Ogni proiettile di tipo scurità infligge energia demoniaca per 10 sec",
                        SpecialStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownNormal = 27, 
                        NormalName = "Squarcio circolare",
                        NormalDescription = "Si teletrasporta dietro a un nemico colpito da energia demoniaca entro 24m e infligge danni pari a un 134% dell'attacco. Attaccare un nemico colpito da energia demoniaca azzera il tempo di ricarica dell'abilità normale dell'eroe e rimuove energia demoniaca dal nemico.",
                        TagName = "Arco potente",
                        TagDescription = "infligge danni pari a un 134% dell'attacco, poi infligge energia demoniaca",
                        TagStatusDescription = "Energia demoniaca: infligge danni pari a un 120% dell'attacco quando viene rimosso.",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Spirito combattivo demoniaco",
                        UltimateDescription = "Infligge danni pari a un 407% dell'attacco. Azzera il tempo di ricarica di tutte le abilità se l'eroe ha 3 o più accumuli di rilascio infernale",
                        UltimateStatusDescription = ""
                    }
                },
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Maestro dello spirito",
                        PassiveDescription = "Ottiene potere demoniaco per 20 sec mettendo a segno degli attacchi su un nemico con esplosione di oscurità attiva per 5 volta/e mentre potere demoniaco non è attivo",
                        PassiveStatusDescription = "Potere demoniaco: infligge danni pari a un 20% dell'attacco ogni 0.5 sec in un'area intorno all' eroe e infligge fuoco infernale per 10 sec. Aumenta i danni inflitti con potere demoniaco di un 100% quando il bersaglio da la quantità massima di accumuli di fuoco infernale.| Fuoco infernale: riduce la resistenza al critico di un 3% contro gli attacchi dell'utilizzatore. Inoltre, riduce la difesa critica di un 50% quando viene raggiunta la quantità massima di accumuli. (Massimo: 10 volte)",
                        AttackName = "Doppio squarcio oscuro",
                        AttackDescription = "infligge danni pari al 162% dell'attacco, 1° hit: 24%, 2° hit: 26%, 3° hit: 43%, 4° hit: 69%",
                        CountdownSpecial = 20,
                        SpecialName = "Squarcio rapido oscuro",
                        SpecialDescription = "Infligge danni pari a un 160% dell'attacco. Aumenta la durata di esplosione di oscurità di 3 sec con ogni colpo, se potere demoniaco è attivo",
                        SpecialStatusDescription = "",
                        CountdownNormal = 32, 
                        NormalName = "Squarcio ustionante",
                        NormalDescription = "Infligge danni pari a un 267% dell'attacco. Infligge ulteriormente danni pari a un 200% dell'attaccom sui nemici vicini con il colpo finale e ripristina i PS di un 90% dell'attacco se potere demoniaco è attivo.",
                        TagName = "Squarcio a X",
                        TagDescription = "infligge danni pari a un 132% dell'attacco.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Squarcio a X - tempesta di lame",
                        UltimateDescription = "Infligge danni pari a un 411% dell'attacco. Ogni colpo su un nemico affetto da fuoco infernale rimuove 1 Accumolo/i di fuoco infernale e aumenta i danni di un 15%. Il colpo finale risulta in un colpo critico se avviene la rimozione di almeno 1 accumolo/i di fuoco infernale. Usare un attacco combinato con la mossa suprema dell'eroe come base consuma tutti i punti magia, ognuno dei quali aumenta i danni da attacco combinato di un 30% per 10 sec",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        
    };
}