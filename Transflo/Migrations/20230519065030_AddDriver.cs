using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Transflo.Migrations
{
    /// <inheritdoc />
    public partial class AddDriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "d.emilang8187@aol.edu", "DaquanCarpenter", "EmiLang", "1-385-662-6735" },
                    { 2, "m_signemeyers@yahoo.couk", "MichaelBattle", "SigneMeyers", "1-291-196-0252" },
                    { 3, "l-jadenkirkland4541@protonmail.edu", "JadenKirkland", "LillithBurt", "1-106-494-2935" },
                    { 4, "oliviakennedyhavivacarr5881@yahoo.com", "OliviaKennedy", "HavivaCarr", "1-955-465-1148" },
                    { 5, "silashampton-emeraldcastillo3347@outlook.com", "SilasHampton", "EmeraldCastillo", "1-768-533-1262" },
                    { 6, "e-bakerhensley@google.couk", "BakerHensley", "EvelynHewitt", "1-661-244-2344" },
                    { 7, "molliestewartaaronmueller@hotmail.org", "AaronMueller", "MollieStewart", "1-340-657-6271" },
                    { 8, "c-fatimaanderson@icloud.com", "FatimaAnderson", "CameronMejia", "1-412-570-4345" },
                    { 9, "lbreeatkins2793@yahoo.com", "LuneaRollins", "BreeAtkins", "1-789-773-5167" },
                    { 10, "b-indiafinch9502@protonmail.couk", "BertHorton", "IndiaFinch", "1-244-431-4333" },
                    { 11, "n-maririchmond9959@google.ca", "NehruRobles", "MariRichmond", "(317) 248-7118" },
                    { 12, "s_inezstein@icloud.org", "ShannonPayne", "InezStein", "1-855-264-2510" },
                    { 13, "k_kessieknapp1410@outlook.edu", "KeeganRoberson", "KessieKnapp", "(896) 552-8732" },
                    { 14, "sgracespears@google.org", "SukiShelton", "GraceSpears", "(372) 621-5439" },
                    { 15, "larissabarnett-vladimirhawkins@google.couk", "VladimirHawkins", "LarissaBarnett", "1-957-331-3663" },
                    { 16, "a.kelsiepetersen@aol.com", "AileeMckay", "KelsiePetersen", "1-477-118-0177" },
                    { 17, "derekgibson.jeanettesosa6229@aol.com", "DerekGibson", "JeanetteSosa", "1-311-513-6023" },
                    { 18, "smaxinesmall4906@aol.couk", "SageGomez", "MaxineSmall", "(546) 620-0682" },
                    { 19, "penelopeburns.kaiavila8611@hotmail.net", "KaiAvila", "PenelopeBurns", "1-927-363-8715" },
                    { 20, "pearlbyrd_sydneepetersen214@aol.couk", "SydneePetersen", "PearlByrd", "1-423-275-5341" },
                    { 21, "rinanguyen.jilliancline@outlook.ca", "RinaNguyen", "JillianCline", "(382) 101-7627" },
                    { 22, "i.mercedesconner@outlook.org", "MercedesConner", "IrisCruz", "(216) 773-8211" },
                    { 23, "keelydavidsonhakeemchapman@aol.ca", "HakeemChapman", "KeelyDavidson", "(424) 597-5604" },
                    { 24, "kchavabishop6766@protonmail.couk", "KeikoVillarreal", "ChavaBishop", "(386) 353-9018" },
                    { 25, "w.maceysawyer2335@hotmail.net", "MaceySawyer", "WhitneyMullins", "(484) 746-7982" },
                    { 26, "laceywilkinson.quinlanjoseph5642@aol.net", "QuinlanJoseph", "LaceyWilkinson", "(564) 992-4461" },
                    { 27, "elianaodonnell_lukelynn@hotmail.ca", "LukeLynn", "ElianaOdonnell", "1-335-563-5450" },
                    { 28, "t.linusmcfadden@hotmail.edu", "LinusMcfadden", "TeeganGarrett", "(101) 766-0358" },
                    { 29, "a.lesterholder@google.net", "LesterHolder", "AspenGoodwin", "(884) 816-3536" },
                    { 30, "n.roannaconley@google.net", "NissimMalone", "RoannaConley", "1-208-403-1931" },
                    { 31, "jaquelynhouse_illanabarron9995@google.org", "IllanaBarron", "JaquelynHouse", "1-475-723-4516" },
                    { 32, "alexaatkinson-kylanwest4601@google.org", "KylanWest", "AlexaAtkinson", "(345) 388-2751" },
                    { 33, "gwendolynmarks-bevisvazquez1093@protonmail.com", "BevisVazquez", "GwendolynMarks", "1-590-439-7588" },
                    { 34, "georgiaguzman-justinpeck@icloud.couk", "JustinPeck", "GeorgiaGuzman", "(771) 364-8503" },
                    { 35, "vmiriamperry@icloud.net", "MiriamPerry", "VirginiaArmstrong", "1-784-170-4050" },
                    { 36, "r.adeleneal@icloud.com", "RyderSears", "AdeleNeal", "1-474-456-1915" },
                    { 37, "heatherrobinson-mageeelliott@google.edu", "MageeElliott", "HeatherRobinson", "1-679-602-4215" },
                    { 38, "j.hannaingram458@icloud.org", "HannaIngram", "JessicaLeon", "(441) 538-6524" },
                    { 39, "khumcgee8799@google.ca", "HuMcgee", "KarinaStephens", "(815) 287-4631" },
                    { 40, "j_quynnbean@icloud.edu", "JamesonCarey", "QuynnBean", "(359) 559-8501" },
                    { 41, "dbrynnesoto@yahoo.couk", "DahliaSosa", "BrynneSoto", "1-712-588-5516" },
                    { 42, "orenromero-orlagillespie@protonmail.org", "OrenRomero", "OrlaGillespie", "(276) 687-2822" },
                    { 43, "arsenionguyen-mayaguerra@protonmail.ca", "ArsenioNguyen", "MayaGuerra", "(327) 854-2601" },
                    { 44, "medgedean_tallulahcardenas1854@outlook.org", "TallulahCardenas", "MedgeDean", "(267) 252-1466" },
                    { 45, "bradleygreer.yuributler4506@icloud.edu", "BradleyGreer", "YuriButler", "(877) 555-2367" },
                    { 46, "n_odetteallen@icloud.ca", "NicholeEngland", "OdetteAllen", "1-575-818-6726" },
                    { 47, "d_heatherduffy2681@outlook.net", "HeatherDuffy", "DesireeBerg", "1-412-500-8115" },
                    { 48, "judithstuart_shanaschmidt@hotmail.com", "ShanaSchmidt", "JudithStuart", "1-312-534-6742" },
                    { 49, "signelawson_kenyonmorrow5250@yahoo.com", "KenyonMorrow", "SigneLawson", "(378) 486-0126" },
                    { 50, "e-ursahayden@yahoo.net", "ElianaLevy", "UrsaHayden", "(561) 576-7311" },
                    { 51, "z_jolenefarmer@hotmail.edu", "ZephaniaPeters", "JoleneFarmer", "(743) 457-0562" },
                    { 52, "nellemcintyre-courtneybradford@hotmail.edu", "CourtneyBradford", "NelleMcintyre", "1-718-531-1560" },
                    { 53, "sopolinebradley.kaioconnor8798@yahoo.org", "Kaiconnor", "SopolineBradley", "(310) 668-7703" },
                    { 54, "n.dexterbaird4112@yahoo.edu", "DexterBaird", "NatalieStout", "(693) 222-4362" },
                    { 55, "beverlycannonrandallmartinez@outlook.net", "RandallMartinez", "BeverlyCannon", "1-847-644-3606" },
                    { 56, "akirestinrichard1812@google.com", "KirestinRichard", "AlisaDickerson", "1-486-506-6749" },
                    { 57, "h-nevadaknapp@icloud.org", "HopRivers", "NevadaKnapp", "1-367-757-8767" },
                    { 58, "madonnaflorestylerday1957@aol.ca", "TylerDay", "MadonnaFlores", "(687) 467-6296" },
                    { 59, "i_ainsleyolsen9030@aol.couk", "Indira", "AinsleyOlsen", "(617) 670-8520" },
                    { 60, "h_erinbullock792@hotmail.couk", "ErinBullock", "HaleyTravis", "1-374-119-7643" },
                    { 61, "abasiagutierrez5823@outlook.couk", "BasiaGutierrez", "AprilBoyd", "1-262-474-9411" },
                    { 62, "ahardingbarlow4576@icloud.com", "HardingBarlow", "AnnGonzales", "1-375-877-4494" },
                    { 63, "ufaithmorrow@aol.com", "UptonBarrett", "FaithMorrow", "1-354-827-8548" },
                    { 64, "colettekeith.sylvestercrawford6797@outlook.edu", "SylvesterCrawford", "ColetteKeith", "1-771-288-6916" },
                    { 65, "serenalangleycalistashaw@hotmail.net", "CalistaShaw", "SerenaLangley", "1-435-421-7578" },
                    { 66, "sarahmeadows_gillianvincent@aol.edu", "SarahMeadows", "GillianVincent", "1-365-876-3854" },
                    { 67, "m.rhodabrennan@icloud.net", "MayBowen", "RhodaBrennan", "1-422-751-8916" },
                    { 68, "l_lilliancarlson7672@hotmail.org", "LilahBooker", "LillianCarlson", "1-831-936-2515" },
                    { 69, "i-kimmoran@yahoo.ca", "IgnaciaCooper", "Kim", "1-580-713-7085" },
                    { 70, "s.brittanytyler@protonmail.edu", "Simon", "Brittany", "(315) 850-4861" },
                    { 71, "k-darrylball7785@protonmail.couk", "Kylan", "Darryl", "1-315-791-5630" },
                    { 72, "k.sachaschneider@protonmail.ca", "Sacha", "Kylee", "(289) 655-5743" },
                    { 73, "ddanielbyers@aol.org", "Daniel", "Dora", "(787) 210-4312" },
                    { 74, "m.kerryparks@aol.net", "Margaret", "Kerry", "(865) 555-7723" },
                    { 75, "kirstenmccoyraeoneil@aol.ca", "Rae", "Kirsten", "1-424-763-8233" },
                    { 76, "n.blakealvarez2060@yahoo.com", "Blake", "Neve", "1-547-559-4581" },
                    { 77, "s.biancarocha851@yahoo.org", "Simone", "Bianca", "1-931-645-7474" },
                    { 78, "fkimpetersen6582@outlook.edu", "Fallon", "Kim", "(402) 769-8920" },
                    { 79, "winifredbrennan-risamcfadden@icloud.com", "Risa", "Winifred", "(303) 578-8781" },
                    { 80, "j.ivorymontgomery@aol.net", "Jaden", "Ivory", "1-615-435-6512" },
                    { 81, "harriettyson-fultoncarrillo@google.com", "Fulton", "Harriet", "1-577-403-4430" },
                    { 82, "lisandrasanchez.germanesanchez@outlook.com", "Lisandra", "Germane", "(448) 558-8797" },
                    { 83, "guywebster-deniseburns@google.com", "Guy", "Denise", "(548) 250-1527" },
                    { 84, "ezoerocha@outlook.com", "Eaton", "Zoe", "(304) 855-6088" },
                    { 85, "utawalton.destinyhaynes@icloud.com", "Uta", "Destiny", "(183) 386-5388" },
                    { 86, "tmadonnagraham5497@yahoo.edu", "Thomas", "Madonna", "1-918-878-4536" },
                    { 87, "warrencruz.teegansosa@aol.edu", "Warren", "Teegan", "(768) 403-7136" },
                    { 88, "msandrasolomon9088@google.net", "Maxwell", "Sandra", "1-619-660-6168" },
                    { 89, "noelallen_meganmatthews@hotmail.com", "Megan", "Noel", "(765) 341-6786" },
                    { 90, "tanneoliver7309@aol.com", "Tara", "Anne", "(516) 552-7857" },
                    { 91, "r_deaconkline@protonmail.com", "Deacon", "Rana", "1-397-464-7587" },
                    { 92, "kelliepark-viviandouglas@aol.couk", "Vivian", "Kellie", "(386) 348-2252" },
                    { 93, "o-dairosales5824@icloud.couk", "Orli", "Dai", "1-711-512-6036" },
                    { 94, "nelletalley_gavinjones@outlook.edu", "Gavin", "Nelle", "1-254-484-2138" },
                    { 95, "zephreaton-rileyhensley1459@aol.com", "Zephr", "Riley", "1-163-596-4606" },
                    { 96, "n_xylakey9554@google.org", "Nolan", "Xyla", "(880) 381-8869" },
                    { 97, "melyssamosleynoelleadams4313@outlook.couk", "Melyssa", "Noelle", "1-613-821-6621" },
                    { 98, "pvedahull@aol.edu", "Phelan", "Veda", "(563) 872-0273" },
                    { 99, "mdaracombs9158@protonmail.edu", "Madaline", "Dara", "(458) 590-3565" },
                    { 100, "l_lenoreatkinson@protonmail.net", "Lani", "Lenore", "1-623-338-7621" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
