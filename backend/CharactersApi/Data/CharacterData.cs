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
            LinkPortrait = "../assets/portraits/portrait_meliodas.png",
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
            LinkPortrait = "../assets/portraits/portrait_escanor.png",
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
                        AttackName ="Fendente spietato",
                        AttackDescription = "infligge danni pari al 202% dell'attacco, 1° hit: 20%, 2° hit: 23%, 3° hit: 35%, 4° hit: 54%, 5° hit: 70%",
                        CountdownSpecial = 13.5,// controllare in game
                        SpecialName = "Sole condensato",
                        SpecialDescription = "Immune alle reazioni e riduce del 30% del danno preso mentre mantiene la posa. Infligge danni pari a 150%/170%/202% dell'attacco in base al livello di carica. Un attacco pienamente caricato su un nemico con esplosione di fuoco attiva infligge un danno addizionale pari al 17% degli HP rimanenti",
                        SpecialStatusDescription = "",
                        CountdownNormal = 15, // controllare in game
                        NormalName = "Linea orgogliosa",
                        NormalDescription = "Infligge danni pari a un 279% dell'attacco, quindi guadagna 2 accumulo/i di punto solare addizionali per 20 sec. (Massimo: 12 volte)",
                        NormalStatusDescription = "Punto solare: aumenta i danni fuoco di un 3% e i ps massimi di un 1.5% per ogni 1 accumulo/i. Quanbdo viene raggiunta la quantità massima di accumuli, rimuove punto solare e ottiene bagliore per 15s|Bagliore: rirpristina un 10% dei ps massimi la prima volta che viene concesso l'effetto. Aumenta i danni fuoco di un 50% e i ps massimi dell'eroe di un 25%, e riduce i danni subiti di un 20%. Ottieni sole calante per 10s quando bagliore viene rimosso.| Sole calante: riduce i ps massimi dell'eroe di un 25% mantenendo invariati i ps massimi",
                        TagName = "Arriva il sole",
                        TagDescription = "infligge danni pari a un 138% dell'attacco", 
                        CountdownUltimate = 10,// controllare in game
                        UsageMagicUltimate = 3,// controllare in game
                        UltimateName = "Fuoco purificatore",
                        UltimateDescription = "Il primo colpo infligge danni pari al 397% dell'attacco, e un danno aggiuntivo pari al 30% degli HP rimanenti quando si attacca un nemico con eplosione di fuoco attiva. L'attacco consuma tutta la barra magica, aumenta il danno del 100% fino al 500% in base a quanti punti utilizizzati. Dopo infliggi un danno pari al 2% del danno ai nemici nel range ogni 0.2 sec per 2 sec. Usando un attacco combinato con la mossa finale dell'eroe aumenta gli HP max del 30% per 20sec",
                        UltimateStatusDescription = ""
                    }
                },

                new Weapon
                {
                    Name = "Spadone",
                    Element = "Sacro",
                    Skills = new SkillSet
                    {
                        PassiveName = "Guida della luce",
                        PassiveDescription = "Aumenta i DnT degli alleati del 150%. Quando attacca nemici bruciati, aumenta i danni inflitti del 30% per ogni accumulo/i. Diminuisce i danni presi dai nemici bruciati del 15%",
                        PassiveStatusDescription = "",
                        AttackName = "Orbita solare",
                        AttackDescription = "infligge danni pari al 168% dell'attacco. 50% di infliggere bruciatura per 20sec (Massimo: 5 volte), 1° hit: 26%, 2° hit: 28%, 3° hit: 40%, 4° hit: 74%",
                        AttackStatusDescription = "Bruciatura: infliggi danni da fuoco pari al 3% dell'attacco ogni 1 sec. Diminuisci la difesa del 0.15% ogni volta che la bruciatura infligge danno. (Massimo: 100 volte)",
                        CountdownSpecial = 25.8, //controllare in game
                        SpecialName = "Impatto solare",
                        SpecialDescription = "Infligge danni pari a un 173% dell'attacco. Quando attacchi un nemico bruciato, infliggi 1 accumulo/i di indebolimento per ogni accumulo/i di bruciatura sul target per 40sec. (Massimo: 5 volte)",
                        SpecialStatusDescription = "Indebolimento: aumenta i DnT ricevuti del 5%. (Massimo: 5 volte)",
                        CountdownNormal = 27, //controllare in game
                        NormalName = "Sole Crudele",
                        NormalDescription = "Infliggi danni pari ad un 289% dell'attacco, riduci l'intervallo di attivazione del danno da bruciatura del 50% per 15 sec",
                        TagName = "Raggio solare",
                        TagDescription = "Infliggi danni pari al 143% dell'attacco",
                        TagStatusDescription = "",
                        CountdownUltimate = 10,//controllare in game
                        UsageMagicUltimate = 3,//controllare in game
                        UltimateName = "Sole nascente",
                        UltimateDescription = "Infliggi danni pari al 390% dell'attacco. Quando si attacca un nemico bruciato, aumenta il danno del 3% per ogni 1 accumulo/i di riduzione della difesa da bruciatura",
                        UltimateStatusDescription = "Bruciatura: infliggi danni da fuoco pari al 3% dell'attacco ogni 1 sec. Diminuisci la difesa del 0.15% ogni volta che la bruciatura infligge danno. (Massimo: 100 volte)"
                    }
                },
                new Weapon
                {
                    Name = "Spada e scudo",
                    Element = "Fuoco",
                    Skills = new SkillSet
                    {
                        PassiveName = "Protezione solare",
                        PassiveDescription = "Ottiene un accumulo/i di preriscaldato ogni secondo che una barriera è attiva",
                        PassiveStatusDescription = "Preriscaldato: aumenta la difesa.| Surriscaldato: aumenta i danni inflitti pari a un 170% della difesa, rimuovi 3 accumulo/i di preriscaldato, quindi aumenta la resistenza al fuoco del 30% per 20 sec.",
                        AttackName = "Marchio del sole",
                        AttackDescription = "Infligge danni pari ad un 86% della difesa, 1° hit: 13%, 2° hit: 15%, 3° hit: 22%, 4° hit: 36% [Surriscaldato] infligge danni pari ad un 100% della difesa, 1° hit: 15%, 2° hit: 17%, 3° hit: 26%, 4° hit: 42%",
                        CountdownSpecial = 20, //controllare in game
                        SpecialName = "SAssalto solare",
                        SpecialDescription = "Concede a tutti gli eroi Barriera di fuoco pari ad un 210% della difesa per 20 sec, quindi infliggi danni pari ad un 110% della difesa. [Surriscaldato] infliggi danni pari ad un 125% della difesa, rimuovi 2 accumulo/i di preriscaldato, quindi aumenta il danno da fuoco di tutti gli alleati del 25% per 20 sec.",
                        SpecialStatusDescription = "Barriera di fuoco: infligge danni pari ad un 15% della difesa ai nemici vici ogni 0.5 sec",
                        CountdownNormal = 32, // controllare in game
                        NormalName = "Fiamme opprimenti",
                        NormalDescription = "Infligge danni pari a un 145% della difesa, quindi attira i nemici per 10 sec. [Surriscaldato] infliggi danni pari ad un 170% della difesa, rimuovi 3 accumulo/i di preriscaldato, quindi riduci la resistenza al fuoco del 30% per 20 sec.",
                        TagName = "Colpo maestoso",
                        TagDescription = "infligge danni pari a un 65% della difesa.",
                        TagStatusDescription = "",
                        CountdownUltimate = 10, // controllare in game
                        UsageMagicUltimate = 3, // controllare in game
                        UltimateName = "Giudizio celeste - Surriscaldamento",
                        UltimateDescription = "Guadagni surriscaldato per 20 sec e infliggi danni pari ad un 210% della difesa. [Surriscaldato] infligge danni pari ad un 240% della difesa, rimuovi 5 accumulo/i di preriscaldato, infliggi danni aggiuntivi pari ad un 300% della difesa, quindi rimuovi surriscaldato ",
                        UltimateStatusDescription = ""
                    }
                }
            ]
        },
        new Character
        {
            Id = 3,
            Rarity = "SSR",
            LinkPortrait = "../assets/portraits/portrait_daisy.png",
            Name = "Daisy",
            AdventureSkillName = "Tocco dell'artigiano",
            AdventureSkillDescription = "Sblocca progetti di crafting esclusivi nel banco da lavoro e espande la coda per i crafting consecutivi (effetto attivo appena si ottiene l'eroe)",
            Weapons =
            [
                new Weapon
                {
                    Name = "Scudo e spada",
                    Element = "Terra",
                    Skills = new SkillSet
                    {
                        PassiveName = "Il mio amico Domby",
                        PassiveDescription = "Aumenta l'effetto carica magica dell'eroe del 50%. [Daisy e Domby]: Diventa immune alle reazioni. Guadagna carica energia per 20 sec consumando 50 dall'indicatore di magia ogni 0.5 sec",
                        PassiveStatusDescription = "Carica energia: Aumenta il danno dell'attacco supremo del 2% quando [Daisy e Domby] è attivo. (Massimo: 30 volte)",
                        AttackName = "Tecnica segreta delle fate: wild swings",
                        AttackDescription = "infligge danni pari al 156% dell'attacco, 1° hit: 23%, 2° hit: 25%, 3° hit: 41%, 4° hit: 67% [Daisy e Domby] infligge danni pari al 198% dell'attacco e ciascuno nemico colpito riduce il tempo di recupero dell'attacco speciale di 2 sec, 1° hit: 29%, 2° hit: 31%, 3° hit: 51%, 4° hit: 87%",
                        CountdownSpecial = 12,
                        SpecialName = "Bloccalo Domby",
                        SpecialDescription = "diminuisce i danni subiti del 90% e guadagnia carica energia per 20 sec quando viene colpita mentre la posizione viene mantenuta. Mantenere la posizione per 3 sec garantisce all'eroe 5 stack(s) di carica energia, e l'indicatore magico viene ripristinato di 500 per 20 sec",
                        SpecialStatusDescription = "Carica energia: Aumenta il danno dell'attacco supremo del 2% quando [Daisy e Domby] è attivo. (Massimo: 30 volte)",
                        CountdownNormal = 15, 
                        NormalName = "Aiutami Domby",
                        NormalDescription = "Attiva [Daisy e Domby], [Daisy e Domby] infligge danni pari al 253% di attacco quindi rimuovi [Daisy e Domby]",
                        TagName = "Ecco che arriva Daisy",
                        TagDescription = "infligge danni pari a un 160% dell'attacco", 
                        CountdownUltimate = 10,
                        UsageMagicUltimate = 3,
                        UltimateName = "Andate via",
                        UltimateDescription = "Infligge danni pari a un 319% dell'attacco, infliggi fata della terra sul nemico per 20 secondi, quindi guadagna 5 stack(s) di carica energie per 20 sec. [Daisy e Domby] Infligge danni pari al 150% dell'attacco, Quando carica energia è al massimo della sua pila, ogni colpo sul nemico con esplosione di terra attiva infligge inoltre danni pari al 75% di attacco, quindi carica energia viene rimosso. Ogni colpo consuma 100 dell'indicatore magico per aumentare i danni del 10%",
                        UltimateStatusDescription = "Fata della terra: aumenta i danni ricevuti dall'eroe del 30%.|Carica energia: Aumenta il danno dell'attacco supremo del 2% quando [Daisy e Domby] è attivo. (Massimo: 30 volte)"
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
            LinkPortrait = "../assets/portraits/portrait_diane.png",
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
            LinkPortrait = "../assets/portraits/portrait_drake.png",
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
            LinkPortrait = "../assets/portraits/portrait_elaine.png",
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
            LinkPortrait = "../assets/portraits/portrait_guila.png",
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
            LinkPortrait = "../assets/portraits/portrait_jericho.png",
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
            LinkPortrait = "../assets/portraits/portrait_king.png",
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
            LinkPortrait = "../assets/portraits/portrait_manny.png",
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
            LinkPortrait = "../assets/portraits/portrait_bug.png",
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
            LinkPortrait = "../assets/portraits/portrait_dreydrin.png",
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
            LinkPortrait = "../assets/portraits/portrait_dreyfus.png",
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
        new Character
        {
            Id = 14,
            Rarity = "SSR",
            LinkPortrait = "../assets/portraits/portrait_elizabeth.png",
            Name = "Elizabeth",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Libro",
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
                    Name = "Bastone",
                    Element = "Vento",
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
            Id = 15,
            Rarity = "SSR",
            LinkPortrait = "../assets/portraits/portrait_merlin.png",
            Name = "Merlin",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Libro",
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
                    Name = "Bacchetta",
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
                    Name = "Bastone",
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
            Id = 16,
            Rarity = "SSR",
            LinkPortrait = "../assets/portraits/portrait_clotho.png",
            Name = "Clotho",
            AdventureSkillName = "Acume del capitano",
            AdventureSkillDescription = "Consente i salti doppi e di camminare sulle pareti",
            Weapons =
            [
                new Weapon
                {
                    Name = "Stocco",
                    Element = "Vento",
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
                    Name = "Bastone",
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
    };
}