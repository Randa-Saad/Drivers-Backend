using Microsoft.EntityFrameworkCore;
using Transflo.Models;

namespace Transflo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TblDriver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TblDriver>().HasData(
                 new TblDriver
                 {
                     Id = 1,
                     FirstName = "DaquanCarpenter",
                     LastName = "EmiLang",
                     Email = "d.emilang8187@aol.edu",
                     PhoneNumber = "1-385-662-6735"
                 },
                 new TblDriver
                 {
                     Id = 2,
                     FirstName = "MichaelBattle",
                     LastName = "SigneMeyers",
                     Email = "m_signemeyers@yahoo.couk",
                     PhoneNumber = "1-291-196-0252"
                 },
                 new TblDriver
                 {
                     Id = 3,
                     FirstName = "JadenKirkland",
                     LastName = "LillithBurt",
                     Email = "l-jadenkirkland4541@protonmail.edu",
                     PhoneNumber = "1-106-494-2935"
                 },
                 new TblDriver
                 {
                     Id = 4,
                     FirstName = "OliviaKennedy",
                     LastName = "HavivaCarr",
                     Email = "oliviakennedyhavivacarr5881@yahoo.com",
                     PhoneNumber = "1-955-465-1148"
                 },
                 new TblDriver
                 {
                     Id = 5,
                     FirstName = "SilasHampton",
                     LastName = "EmeraldCastillo",
                     Email = "silashampton-emeraldcastillo3347@outlook.com",
                     PhoneNumber = "1-768-533-1262"
                 },
                 new TblDriver
                 {
                     Id = 6,
                     FirstName = "BakerHensley",
                     LastName = "EvelynHewitt",
                     Email = "e-bakerhensley@google.couk",
                     PhoneNumber = "1-661-244-2344"
                 },
                 new TblDriver
                 {
                     Id = 7,
                     FirstName = "AaronMueller",
                     LastName = "MollieStewart",
                     Email = "molliestewartaaronmueller@hotmail.org",
                     PhoneNumber = "1-340-657-6271"
                 },
                 new TblDriver
                 {
                     Id = 8,
                     FirstName = "FatimaAnderson",
                     LastName = "CameronMejia",
                     Email = "c-fatimaanderson@icloud.com",
                     PhoneNumber = "1-412-570-4345"
                 },
                 new TblDriver
                 {
                     Id = 9,
                     FirstName = "LuneaRollins",
                     LastName = "BreeAtkins",
                     Email = "lbreeatkins2793@yahoo.com",
                     PhoneNumber = "1-789-773-5167"
                 },
                 new TblDriver
                 {
                     Id = 10,
                     FirstName = "BertHorton",
                     LastName = "IndiaFinch",
                     Email = "b-indiafinch9502@protonmail.couk",
                     PhoneNumber = "1-244-431-4333"
                 },
                 new TblDriver
                 {
                     Id = 11,
                     FirstName = "NehruRobles",
                     LastName = "MariRichmond",
                     Email = "n-maririchmond9959@google.ca",
                     PhoneNumber = "(317) 248-7118"
                 },
                 new TblDriver
                 {
                     Id = 12,
                     FirstName = "ShannonPayne",
                     LastName = "InezStein",
                     Email = "s_inezstein@icloud.org",
                     PhoneNumber = "1-855-264-2510"
                 },
                 new TblDriver
                 {
                     Id = 13,
                     FirstName = "KeeganRoberson",
                     LastName = "KessieKnapp",
                     Email = "k_kessieknapp1410@outlook.edu",
                     PhoneNumber = "(896) 552-8732"
                 },
                 new TblDriver
                 {
                     Id = 14,
                     FirstName = "SukiShelton",
                     LastName = "GraceSpears",
                     Email = "sgracespears@google.org",
                     PhoneNumber = "(372) 621-5439"
                 },
                 new TblDriver
                 {
                     Id = 15,
                     FirstName = "VladimirHawkins",
                     LastName = "LarissaBarnett",
                     Email = "larissabarnett-vladimirhawkins@google.couk",
                     PhoneNumber = "1-957-331-3663"
                 },
                 new TblDriver
                 {
                     Id = 16,
                     FirstName = "AileeMckay",
                     LastName = "KelsiePetersen",
                     Email = "a.kelsiepetersen@aol.com",
                     PhoneNumber = "1-477-118-0177"
                 }, new TblDriver
                 {
                     Id = 17,
                     FirstName = "DerekGibson",
                     LastName = "JeanetteSosa",
                     Email = "derekgibson.jeanettesosa6229@aol.com",
                     PhoneNumber = "1-311-513-6023"
                 }, new TblDriver
                 {
                     Id = 18,
                     FirstName = "SageGomez",
                     LastName = "MaxineSmall",
                     Email = "smaxinesmall4906@aol.couk",
                     PhoneNumber = "(546) 620-0682"
                 }, new TblDriver
                 {
                     Id = 19,
                     FirstName = "KaiAvila",
                     LastName = "PenelopeBurns",
                     Email = "penelopeburns.kaiavila8611@hotmail.net",
                     PhoneNumber = "1-927-363-8715"
                 }, new TblDriver
                 {
                     Id = 20,
                     FirstName = "SydneePetersen",
                     LastName = "PearlByrd",
                     Email = "pearlbyrd_sydneepetersen214@aol.couk",
                     PhoneNumber = "1-423-275-5341"
                 }, new TblDriver
                 {
                     Id = 21,
                     FirstName = "RinaNguyen",
                     LastName = "JillianCline",
                     Email = "rinanguyen.jilliancline@outlook.ca",
                     PhoneNumber = "(382) 101-7627"
                 }, new TblDriver
                 {
                     Id = 22,
                     FirstName = "MercedesConner",
                     LastName = "IrisCruz",
                     Email = "i.mercedesconner@outlook.org",
                     PhoneNumber = "(216) 773-8211"
                 }, new TblDriver
                 {
                     Id = 23,
                     FirstName = "HakeemChapman",
                     LastName = "KeelyDavidson",
                     Email = "keelydavidsonhakeemchapman@aol.ca",
                     PhoneNumber = "(424) 597-5604"
                 }, new TblDriver
                 {
                     Id = 24,
                     FirstName = "KeikoVillarreal",
                     LastName = "ChavaBishop",
                     Email = "kchavabishop6766@protonmail.couk",
                     PhoneNumber = "(386) 353-9018"
                 }, new TblDriver
                 {
                     Id = 25,
                     FirstName = "MaceySawyer",
                     LastName = "WhitneyMullins",
                     Email = "w.maceysawyer2335@hotmail.net",
                     PhoneNumber = "(484) 746-7982"
                 }, new TblDriver
                 {
                     Id = 26,
                     FirstName = "QuinlanJoseph",
                     LastName = "LaceyWilkinson",
                     Email = "laceywilkinson.quinlanjoseph5642@aol.net",
                     PhoneNumber = "(564) 992-4461"
                 }, new TblDriver
                 {
                     Id = 27,
                     FirstName = "LukeLynn",
                     LastName = "ElianaOdonnell",
                     Email = "elianaodonnell_lukelynn@hotmail.ca",
                     PhoneNumber = "1-335-563-5450"
                 }, new TblDriver
                 {
                     Id = 28,
                     FirstName = "LinusMcfadden",
                     LastName = "TeeganGarrett",
                     Email = "t.linusmcfadden@hotmail.edu",
                     PhoneNumber = "(101) 766-0358"
                 }, new TblDriver
                 {
                     Id = 29,
                     FirstName = "LesterHolder",
                     LastName = "AspenGoodwin",
                     Email = "a.lesterholder@google.net",
                     PhoneNumber = "(884) 816-3536"
                 }, new TblDriver
                 {
                     Id = 30,
                     FirstName = "NissimMalone",
                     LastName = "RoannaConley",
                     Email = "n.roannaconley@google.net",
                     PhoneNumber = "1-208-403-1931"
                 }, new TblDriver
                 {
                     Id = 31,
                     FirstName = "IllanaBarron",
                     LastName = "JaquelynHouse",
                     Email = "jaquelynhouse_illanabarron9995@google.org",
                     PhoneNumber = "1-475-723-4516"
                 }, new TblDriver
                 {
                     Id = 32,
                     FirstName = "KylanWest",
                     LastName = "AlexaAtkinson",
                     Email = "alexaatkinson-kylanwest4601@google.org",
                     PhoneNumber = "(345) 388-2751"
                 }, new TblDriver
                 {
                     Id = 33,
                     FirstName = "BevisVazquez",
                     LastName = "GwendolynMarks",
                     Email = "gwendolynmarks-bevisvazquez1093@protonmail.com",
                     PhoneNumber = "1-590-439-7588"
                 }, new TblDriver
                 {
                     Id = 34,
                     FirstName = "JustinPeck",
                     LastName = "GeorgiaGuzman",
                     Email = "georgiaguzman-justinpeck@icloud.couk",
                     PhoneNumber = "(771) 364-8503"
                 }, new TblDriver
                 {
                     Id = 35,
                     FirstName = "MiriamPerry",
                     LastName = "VirginiaArmstrong",
                     Email = "vmiriamperry@icloud.net",
                     PhoneNumber = "1-784-170-4050"
                 }, new TblDriver
                 {
                     Id = 36,
                     FirstName = "RyderSears",
                     LastName = "AdeleNeal",
                     Email = "r.adeleneal@icloud.com",
                     PhoneNumber = "1-474-456-1915"
                 }, new TblDriver
                 {
                     Id = 37,
                     FirstName = "MageeElliott",
                     LastName = "HeatherRobinson",
                     Email = "heatherrobinson-mageeelliott@google.edu",
                     PhoneNumber = "1-679-602-4215"
                 }, new TblDriver
                 {
                     Id = 38,
                     FirstName = "HannaIngram",
                     LastName = "JessicaLeon",
                     Email = "j.hannaingram458@icloud.org",
                     PhoneNumber = "(441) 538-6524"
                 }, new TblDriver
                 {
                     Id = 39,
                     FirstName = "HuMcgee",
                     LastName = "KarinaStephens",
                     Email = "khumcgee8799@google.ca",
                     PhoneNumber = "(815) 287-4631"
                 }, new TblDriver
                 {
                     Id = 40,
                     FirstName = "JamesonCarey",
                     LastName = "QuynnBean",
                     Email = "j_quynnbean@icloud.edu",
                     PhoneNumber = "(359) 559-8501"
                 }, new TblDriver
                 {
                     Id = 41,
                     FirstName = "DahliaSosa",
                     LastName = "BrynneSoto",
                     Email = "dbrynnesoto@yahoo.couk",
                     PhoneNumber = "1-712-588-5516"
                 }, new TblDriver
                 {
                     Id = 42,
                     FirstName = "OrenRomero",
                     LastName = "OrlaGillespie",
                     Email = "orenromero-orlagillespie@protonmail.org",
                     PhoneNumber = "(276) 687-2822"
                 }, new TblDriver
                 {
                     Id = 43,
                     FirstName = "ArsenioNguyen",
                     LastName = "MayaGuerra",
                     Email = "arsenionguyen-mayaguerra@protonmail.ca",
                     PhoneNumber = "(327) 854-2601"
                 }, new TblDriver
                 {
                     Id = 44,
                     FirstName = "TallulahCardenas",
                     LastName = "MedgeDean",
                     Email = "medgedean_tallulahcardenas1854@outlook.org",
                     PhoneNumber = "(267) 252-1466"
                 }, new TblDriver
                 {
                     Id = 45,
                     FirstName = "BradleyGreer",
                     LastName = "YuriButler",
                     Email = "bradleygreer.yuributler4506@icloud.edu",
                     PhoneNumber = "(877) 555-2367"
                 }, new TblDriver
                 {
                     Id = 46,
                     FirstName = "NicholeEngland",
                     LastName = "OdetteAllen",
                     Email = "n_odetteallen@icloud.ca",
                     PhoneNumber = "1-575-818-6726"
                 }, new TblDriver
                 {
                     Id = 47,
                     FirstName = "HeatherDuffy",
                     LastName = "DesireeBerg",
                     Email = "d_heatherduffy2681@outlook.net",
                     PhoneNumber = "1-412-500-8115"
                 }, new TblDriver
                 {
                     Id = 48,
                     FirstName = "ShanaSchmidt",
                     LastName = "JudithStuart",
                     Email = "judithstuart_shanaschmidt@hotmail.com",
                     PhoneNumber = "1-312-534-6742"
                 }, new TblDriver
                 {
                     Id = 49,
                     FirstName = "KenyonMorrow",
                     LastName = "SigneLawson",
                     Email = "signelawson_kenyonmorrow5250@yahoo.com",
                     PhoneNumber = "(378) 486-0126"
                 }, new TblDriver
                 {
                     Id = 50,
                     FirstName = "ElianaLevy",
                     LastName = "UrsaHayden",
                     Email = "e-ursahayden@yahoo.net",
                     PhoneNumber = "(561) 576-7311"
                 }, new TblDriver
                 {
                     Id = 51,
                     FirstName = "ZephaniaPeters",
                     LastName = "JoleneFarmer",
                     Email = "z_jolenefarmer@hotmail.edu",
                     PhoneNumber = "(743) 457-0562"
                 }, new TblDriver
                 {
                     Id = 52,
                     FirstName = "CourtneyBradford",
                     LastName = "NelleMcintyre",
                     Email = "nellemcintyre-courtneybradford@hotmail.edu",
                     PhoneNumber = "1-718-531-1560"
                 }, new TblDriver
                 {
                     Id = 53,
                     FirstName = "Kaiconnor",
                     LastName = "SopolineBradley",
                     Email = "sopolinebradley.kaioconnor8798@yahoo.org",
                     PhoneNumber = "(310) 668-7703"
                 }, new TblDriver
                 {
                     Id = 54,
                     FirstName = "DexterBaird",
                     LastName = "NatalieStout",
                     Email = "n.dexterbaird4112@yahoo.edu",
                     PhoneNumber = "(693) 222-4362"
                 }, new TblDriver
                 {
                     Id = 55,
                     FirstName = "RandallMartinez",
                     LastName = "BeverlyCannon",
                     Email = "beverlycannonrandallmartinez@outlook.net",
                     PhoneNumber = "1-847-644-3606"
                 }, new TblDriver
                 {
                     Id = 56,
                     FirstName = "KirestinRichard",
                     LastName = "AlisaDickerson",
                     Email = "akirestinrichard1812@google.com",
                     PhoneNumber = "1-486-506-6749"
                 }, new TblDriver
                 {
                     Id = 57,
                     FirstName = "HopRivers",
                     LastName = "NevadaKnapp",
                     Email = "h-nevadaknapp@icloud.org",
                     PhoneNumber = "1-367-757-8767"
                 }, new TblDriver
                 {
                     Id = 58,
                     FirstName = "TylerDay",
                     LastName = "MadonnaFlores",
                     Email = "madonnaflorestylerday1957@aol.ca",
                     PhoneNumber = "(687) 467-6296"
                 }, new TblDriver
                 {
                     Id = 59,
                     FirstName = "Indira",
                     LastName = "AinsleyOlsen",
                     Email = "i_ainsleyolsen9030@aol.couk",
                     PhoneNumber = "(617) 670-8520"
                 }, new TblDriver
                 {
                     Id = 60,
                     FirstName = "ErinBullock",
                     LastName = "HaleyTravis",
                     Email = "h_erinbullock792@hotmail.couk",
                     PhoneNumber = "1-374-119-7643"
                 }, new TblDriver
                 {
                     Id = 61,
                     FirstName = "BasiaGutierrez",
                     LastName = "AprilBoyd",
                     Email = "abasiagutierrez5823@outlook.couk",
                     PhoneNumber = "1-262-474-9411"
                 }, new TblDriver
                 {
                     Id = 62,
                     FirstName = "HardingBarlow",
                     LastName = "AnnGonzales",
                     Email = "ahardingbarlow4576@icloud.com",
                     PhoneNumber = "1-375-877-4494"
                 }, new TblDriver
                 {
                     Id = 63,
                     FirstName = "UptonBarrett",
                     LastName = "FaithMorrow",
                     Email = "ufaithmorrow@aol.com",
                     PhoneNumber = "1-354-827-8548"
                 }, new TblDriver
                 {
                     Id = 64,
                     FirstName = "SylvesterCrawford",
                     LastName = "ColetteKeith",
                     Email = "colettekeith.sylvestercrawford6797@outlook.edu",
                     PhoneNumber = "1-771-288-6916"
                 }, new TblDriver
                 {
                     Id = 65,
                     FirstName = "CalistaShaw",
                     LastName = "SerenaLangley",
                     Email = "serenalangleycalistashaw@hotmail.net",
                     PhoneNumber = "1-435-421-7578"
                 }, new TblDriver
                 {
                     Id = 66,
                     FirstName = "SarahMeadows",
                     LastName = "GillianVincent",
                     Email = "sarahmeadows_gillianvincent@aol.edu",
                     PhoneNumber = "1-365-876-3854"
                 }, new TblDriver
                 {
                     Id = 67,
                     FirstName = "MayBowen",
                     LastName = "RhodaBrennan",
                     Email = "m.rhodabrennan@icloud.net",
                     PhoneNumber = "1-422-751-8916"
                 }, new TblDriver
                 {
                     Id = 68,
                     FirstName = "LilahBooker",
                     LastName = "LillianCarlson",
                     Email = "l_lilliancarlson7672@hotmail.org",
                     PhoneNumber = "1-831-936-2515"
                 }, new TblDriver
                 {
                     Id = 69,
                     FirstName = "IgnaciaCooper",
                     LastName = "Kim",
                     Email = "i-kimmoran@yahoo.ca",
                     PhoneNumber = "1-580-713-7085"
                 }, new TblDriver
                 {
                     Id = 70,
                     FirstName = "Simon",
                     LastName = "Brittany",
                     Email = "s.brittanytyler@protonmail.edu",
                     PhoneNumber = "(315) 850-4861"
                 }, new TblDriver
                 {
                     Id = 71,
                     FirstName = "Kylan",
                     LastName = "Darryl",
                     Email = "k-darrylball7785@protonmail.couk",
                     PhoneNumber = "1-315-791-5630"
                 }, new TblDriver
                 {
                     Id = 72,
                     FirstName = "Sacha",
                     LastName = "Kylee",
                     Email = "k.sachaschneider@protonmail.ca",
                     PhoneNumber = "(289) 655-5743"
                 }, new TblDriver
                 {
                     Id = 73,
                     FirstName = "Daniel",
                     LastName = "Dora",
                     Email = "ddanielbyers@aol.org",
                     PhoneNumber = "(787) 210-4312"
                 }, new TblDriver
                 {
                     Id = 74,
                     FirstName = "Margaret",
                     LastName = "Kerry",
                     Email = "m.kerryparks@aol.net",
                     PhoneNumber = "(865) 555-7723"
                 }, new TblDriver
                 {
                     Id = 75,
                     FirstName = "Rae",
                     LastName = "Kirsten",
                     Email = "kirstenmccoyraeoneil@aol.ca",
                     PhoneNumber = "1-424-763-8233"
                 }, new TblDriver
                 {
                     Id = 76,
                     FirstName = "Blake",
                     LastName = "Neve",
                     Email = "n.blakealvarez2060@yahoo.com",
                     PhoneNumber = "1-547-559-4581"
                 }, new TblDriver
                 {
                     Id = 77,
                     FirstName = "Simone",
                     LastName = "Bianca",
                     Email = "s.biancarocha851@yahoo.org",
                     PhoneNumber = "1-931-645-7474"
                 }, new TblDriver
                 {
                     Id = 78,
                     FirstName = "Fallon",
                     LastName = "Kim",
                     Email = "fkimpetersen6582@outlook.edu",
                     PhoneNumber = "(402) 769-8920"
                 }, new TblDriver
                 {
                     Id = 79,
                     FirstName = "Risa",
                     LastName = "Winifred",
                     Email = "winifredbrennan-risamcfadden@icloud.com",
                     PhoneNumber = "(303) 578-8781"
                 }, new TblDriver
                 {
                     Id = 80,
                     FirstName = "Jaden",
                     LastName = "Ivory",
                     Email = "j.ivorymontgomery@aol.net",
                     PhoneNumber = "1-615-435-6512"
                 }, new TblDriver
                 {
                     Id = 81,
                     FirstName = "Fulton",
                     LastName = "Harriet",
                     Email = "harriettyson-fultoncarrillo@google.com",
                     PhoneNumber = "1-577-403-4430"
                 }, new TblDriver
                 {
                     Id = 82,
                     FirstName = "Lisandra",
                     LastName = "Germane",
                     Email = "lisandrasanchez.germanesanchez@outlook.com",
                     PhoneNumber = "(448) 558-8797"
                 }, new TblDriver
                 {
                     Id = 83,
                     FirstName = "Guy",
                     LastName = "Denise",
                     Email = "guywebster-deniseburns@google.com",
                     PhoneNumber = "(548) 250-1527"
                 }, new TblDriver
                 {
                     Id = 84,
                     FirstName = "Eaton",
                     LastName = "Zoe",
                     Email = "ezoerocha@outlook.com",
                     PhoneNumber = "(304) 855-6088"
                 }, new TblDriver
                 {
                     Id = 85,
                     FirstName = "Uta",
                     LastName = "Destiny",
                     Email = "utawalton.destinyhaynes@icloud.com",
                     PhoneNumber = "(183) 386-5388"
                 }, new TblDriver
                 {
                     Id = 86,
                     FirstName = "Thomas",
                     LastName = "Madonna",
                     Email = "tmadonnagraham5497@yahoo.edu",
                     PhoneNumber = "1-918-878-4536"
                 }, new TblDriver
                 {
                     Id = 87,
                     FirstName = "Warren",
                     LastName = "Teegan",
                     Email = "warrencruz.teegansosa@aol.edu",
                     PhoneNumber = "(768) 403-7136"
                 }, new TblDriver
                 {
                     Id = 88,
                     FirstName = "Maxwell",
                     LastName = "Sandra",
                     Email = "msandrasolomon9088@google.net",
                     PhoneNumber = "1-619-660-6168"
                 }, new TblDriver
                 {
                     Id = 89,
                     FirstName = "Megan",
                     LastName = "Noel",
                     Email = "noelallen_meganmatthews@hotmail.com",
                     PhoneNumber = "(765) 341-6786"
                 }, new TblDriver
                 {
                     Id = 90,
                     FirstName = "Tara",
                     LastName = "Anne",
                     Email = "tanneoliver7309@aol.com",
                     PhoneNumber = "(516) 552-7857"
                 }, new TblDriver
                 {
                     Id = 91,
                     FirstName = "Deacon",
                     LastName = "Rana",
                     Email = "r_deaconkline@protonmail.com",
                     PhoneNumber = "1-397-464-7587"
                 }, new TblDriver
                 {
                     Id = 92,
                     FirstName = "Vivian",
                     LastName = "Kellie",
                     Email = "kelliepark-viviandouglas@aol.couk",
                     PhoneNumber = "(386) 348-2252"
                 }, new TblDriver
                 {
                     Id = 93,
                     FirstName = "Orli",
                     LastName = "Dai",
                     Email = "o-dairosales5824@icloud.couk",
                     PhoneNumber = "1-711-512-6036"
                 }, new TblDriver
                 {
                     Id = 94,
                     FirstName = "Gavin",
                     LastName = "Nelle",
                     Email = "nelletalley_gavinjones@outlook.edu",
                     PhoneNumber = "1-254-484-2138"
                 }, new TblDriver
                 {
                     Id = 95,
                     FirstName = "Zephr",
                     LastName = "Riley",
                     Email = "zephreaton-rileyhensley1459@aol.com",
                     PhoneNumber = "1-163-596-4606"
                 }, new TblDriver
                 {
                     Id = 96,
                     FirstName = "Nolan",
                     LastName = "Xyla",
                     Email = "n_xylakey9554@google.org",
                     PhoneNumber = "(880) 381-8869"
                 }, new TblDriver
                 {
                     Id = 97,
                     FirstName = "Melyssa",
                     LastName = "Noelle",
                     Email = "melyssamosleynoelleadams4313@outlook.couk",
                     PhoneNumber = "1-613-821-6621"
                 }, new TblDriver
                 {
                     Id = 98,
                     FirstName = "Phelan",
                     LastName = "Veda",
                     Email = "pvedahull@aol.edu",
                     PhoneNumber = "(563) 872-0273"
                 }, new TblDriver
                 {
                     Id = 99,
                     FirstName = "Madaline",
                     LastName = "Dara",
                     Email = "mdaracombs9158@protonmail.edu",
                     PhoneNumber = "(458) 590-3565"
                 }, new TblDriver
                 {
                     Id = 100,
                     FirstName = "Lani",
                     LastName = "Lenore",
                     Email = "l_lenoreatkinson@protonmail.net",
                     PhoneNumber = "1-623-338-7621"
                 });
        }
                  
    }
}
