using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(34)", maxLength: 34, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    Education_CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserProjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CertificateUrl = table.Column<string>(type: "text", nullable: true),
                    Credential = table.Column<string>(type: "text", nullable: true),
                    Issued = table.Column<DateOnly>(type: "date", nullable: true),
                    CertificateFileName = table.Column<string>(type: "text", nullable: true),
                    UserProject_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    UrlSrc = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    UserProject_PhotoName = table.Column<string>(type: "text", nullable: true),
                    CountyId = table.Column<Guid>(type: "uuid", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Firstname = table.Column<string>(type: "text", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: true),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: true),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    AboutMe = table.Column<string>(type: "text", nullable: true),
                    PhotoName = table.Column<string>(type: "text", nullable: true),
                    ResumeName = table.Column<string>(type: "text", nullable: true),
                    User_CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    UIThemeId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserEducation_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    EducationId = table.Column<Guid>(type: "uuid", nullable: true),
                    From = table.Column<DateOnly>(type: "date", nullable: true),
                    To = table.Column<DateOnly>(type: "date", nullable: true),
                    UserExperience_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserExperience_PositionId = table.Column<Guid>(type: "uuid", nullable: true),
                    WorkTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserExperience_From = table.Column<DateOnly>(type: "date", nullable: true),
                    UserExperience_To = table.Column<DateOnly>(type: "date", nullable: true),
                    UserLanguage_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true),
                    LevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserSkill_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserSkill_PhotoName = table.Column<string>(type: "text", nullable: true),
                    UserSocialNetwork_UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    SocialNetworkId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserSocialNetwork_Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_CityId",
                        column: x => x.CityId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_CountyId",
                        column: x => x.CountyId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_EducationId",
                        column: x => x.EducationId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Education_CityId",
                        column: x => x.Education_CityId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_LevelId",
                        column: x => x.LevelId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PositionId",
                        column: x => x.PositionId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_SkillId",
                        column: x => x.SkillId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_SocialNetworkId",
                        column: x => x.SocialNetworkId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserEducation_UserId",
                        column: x => x.UserEducation_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserExperience_PositionId",
                        column: x => x.UserExperience_PositionId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserExperience_UserId",
                        column: x => x.UserExperience_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserLanguage_UserId",
                        column: x => x.UserLanguage_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserProjectId",
                        column: x => x.UserProjectId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserProject_UserId",
                        column: x => x.UserProject_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserSkill_UserId",
                        column: x => x.UserSkill_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserSocialNetwork_UserId",
                        column: x => x.UserSocialNetwork_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_User_CityId",
                        column: x => x.User_CityId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("01753ef1-9be5-43f7-ba3a-fb822ad87982"), null, "SocialNetwork", false, "LinkedIn", "LinkedIn", "LinkedIn", "LinkedIn" },
                    { new Guid("02833fc8-089a-4d98-bde5-99a6b06498c9"), null, "Country", false, "Vietnam", "Vietnam", "Вьетнам", "Vyetnam" },
                    { new Guid("047611bf-1804-4c4e-8110-47074b55849c"), null, "Country", false, "Turkey", "Turkey", "Турция", "Turkiya" },
                    { new Guid("1237d6d9-5c71-4810-bdb9-d886a6a2ffd7"), null, "Country", false, "Indonesia", "Indonesia", "Индонезия", "Indoneziya" },
                    { new Guid("131db6e1-cec9-4e2a-a174-5d6407e11309"), null, "SocialNetwork", false, "Thread", "Thread", "Thread", "Thread" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("13384688-5d0e-433f-a1a3-0c22dbd77726"), null, "Develops and maintains the server-side logic of web applications.", "Develops and maintains the server-side logic of web applications.", "Разрабатывает и поддерживает серверную логику веб-приложений.", "Veb ilovalar server tomonidagi logikasini rivojlantirish va saqlash.", "Position", false, "Backend Developer", "Backend Developer", "Бэкенд разработчик", "Backend dasturchi" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("142d9be6-049a-4335-8d87-f470edde2c3c"), null, "Language", false, "English", "English", "Английский", "Inglizcha" },
                    { new Guid("1434e50f-5652-4798-840e-4d540379073e"), null, "Country", false, "China", "China", "Китай", "Xitoy" },
                    { new Guid("1aaf684b-5535-486b-b21d-bf252bdb18ab"), null, "SocialNetwork", false, "Imo", "Imo", "Imo", "Imo" },
                    { new Guid("22185df5-b9ea-4030-8cd6-627f873f01fe"), null, "Language", false, "Russian", "Russian", "Русский", "Ruscha" },
                    { new Guid("2af3c7b1-6d60-443d-8cbc-251a4beda498"), null, "SocialNetwork", false, "GitHub", "GitHub", "GitHub", "GitHub" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("2f31407e-7a81-4ec6-9993-db2ba1524435"), null, "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Можете понять основные моменты понятных стандартных вводов по знакомым вопросам. Можете составить простой связанный текст по темам, которые вам знакомы или интересны лично.", "Odatiy masalalar haqida bayonotdan foydalanib, asosiy nuqtalarni tushunish mumkin. Odatiy yoki shaxsiy qiziq mavzularida bog'liq oddiy bog'lanishgan matnlarni yaratish mumkin.", "Level", false, "Intermediate", "Intermediate", "Средний", "O'rta" },
                    { new Guid("3016022d-c3a8-462f-8361-44254450d058"), null, "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Мониторит и защищает компьютерные системы и сети организации от киберугроз и атак.", "Tashkilotning kompyuter tizimlarini va tarmoqlarini onlayn xavf va hujumlaridan himoya qilish va nazorat qilish.", "Position", false, "IT Security Analyst", "IT Security Analyst", "Аналитик информационной безопасности", "IT Xavfsizlik tahliliy" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("3680e7df-36db-48e1-a3ae-7b208e40da4c"), null, "SocialNetwork", false, "Zoom", "Zoom", "Zoom", "Zoom" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("371598e2-1296-46ea-af9a-dd94de551d35"), null, "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Можете понять основные идеи сложного текста по конкретным и абстрактным темам. Можете взаимодействовать с определенной степенью беглости и спонтанности, что делает регулярное общение с носителями языка возможным без напряжения для обеих сторон.", "Aniq yoki abstrakt mavzularda kompleks matnlarning asosiy o'zini tushunish mumkin. Huddi shaxsiyatli so'zlashish va spantane so'zlashish darajasida soddalik bilan amalga oshirish mumkin, bu esa har ikki taraf uchun ham zo'ravon bo'lishsiz mumkin.", "Level", false, "Upper-Intermediate", "Upper-Intermediate", "Выше среднего", "Yuqori o'rta" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "Country", false, "Kazakhstan", "Kazakhstan", "Казахстан", "Qozog'iston" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("4f5fd2f2-7057-4c20-ae4c-a4173cbe1936"), null, "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Можете понять широкий круг требовательных, длинных текстов и распознать неявное значение. Можете выражать идеи бегло и спонтанно без явного поиска выражений.", "Murakkab va uzun matnlarning keng tarqalgan qatorini tushunish va zimmasiz manoni aniqlash mumkin. Ideyalarni boshqarish uchun shifobaxsh va spantane so'zlashish, tushunarli talab qilmaydi.", "Level", false, "Advanced", "Advanced", "Продвинутый", "Yuqori" },
                    { new Guid("52f59e3e-3767-45d7-b385-e267f6c4a55b"), null, "A student or trainee who works in a company to gain work experience.", "A student or trainee who works in a company to gain work experience.", "Студент или стажер, который работает в компании для получения опыта работы.", "Ish tajribasini olish uchun kompaniyada ishlovchi talaba yoki o'quvchi.", "WorkType", false, "Intern", "Intern", "Стажер", "Stajyor" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("56064f79-822e-4049-a520-0fbe7f735677"), null, "Country", false, "Turkmenistan", "Turkmenistan", "Туркменистан", "Turkmaniston" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("5613ba01-5e26-48b4-a568-c18294cf940a"), null, "Employee works from a location other than the office.", "Employee works from a location other than the office.", "Сотрудник работает не в офисе, а на удаленной основе.", "Ishchi ofisdan boshqa joydan ishlaydi.", "WorkType", false, "Remote", "Remote", "Удаленная работа", "Masofaviy" },
                    { new Guid("588c3b5e-5d09-49f2-bc4f-7f62dd9229dd"), null, "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Планирует, организует и контролирует IT проекты, обеспечивая их выполнение в срок, в рамках бюджета и в соответствии с требованиями организации.", "IT loyihalarini rejalashtirish, tashkil etish va boshqarish vaqti, byudjeti va tashkilot talablari bilan mos keladiganligini ta'minlash.", "Position", false, "IT Project Manager", "IT Project Manager", "Менеджер IT проектов", "IT loyihalash boshqaruvi" },
                    { new Guid("5980ce07-e74d-42e1-911c-bb8be7a6ecae"), null, "Employee works fewer hours than a full-time employee.", "Employee works fewer hours than a full-time employee.", "Сотрудник работает меньше часов, чем на полный рабочий день.", "Ishchi to'la vaqtli ishchidan kam soat ishlaydi.", "WorkType", false, "Part-time", "Part-time", "Неполный рабочий день", "Qisman ish" },
                    { new Guid("5a7ceb84-e379-4c93-9f79-e9524a474078"), null, "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Управляет и поддерживает базы данных организации, обеспечивая безопасность, целостность и доступность данных.", "Tashkilotning ma'lumotlar bazasini boshqarish va saqlash, ma'lumotlarni xavfsizligini, integritetini va mavjudligini ta'minlashdan mas'ul.", "Position", false, "Database Administrator", "Database Administrator", "Администратор баз данных", "Ma'lumotlar bazasi administratori" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("5ebe6791-072a-49bf-9c0e-32ea1cc7786a"), null, "Language", false, "Uzbek", "Uzbek", "Узбекский", "O'zbekcha" },
                    { new Guid("66fbc0d6-d5de-413d-9a65-0f14d0cd728c"), null, "Country", false, "India", "India", "Индия", "Hindiston" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("6ba06e7d-2f65-4aa6-9d6a-847b272df340"), null, "Designs, implements, and manages data communication networks such as LANs and WANs.", "Designs, implements, and manages data communication networks such as LANs and WANs.", "Проектирует, внедряет и управляет сетями передачи данных, такими как LAN и WAN.", "Mahalliy tarmoqlar (LAN) va keng sahalar (WAN) kabi ma'lumotlar almashish tarmoqlarini dizayn qilish, amalga oshirish va boshqarish.", "Position", false, "Network Engineer", "Network Engineer", "Сетевой инженер", "Tarmoq muhandisi" },
                    { new Guid("706a544c-131e-44e3-9509-b5c9e34b4b19"), null, "Basic understanding of the language with limited vocabulary and simple grammar.", "Basic understanding of the language with limited vocabulary and simple grammar.", "Основное понимание языка с ограниченным словарным запасом и простой грамматикой.", "O'z tilini boshlang'ich darajada o'rganish, chegaraviy so'zlashish va oddiy grammatikaga ega bo'lish.", "Level", false, "Beginner", "Beginner", "Начинающий", "Boshlang'ich" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("71fe90b6-15ff-4170-bbbe-b85445f21ab8"), null, "SocialNetwork", false, "Instagram", "Instagram", "Инстаграм", "Instagram" },
                    { new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "Country", false, "Uzbekistan", "Uzbekistan", "Узбекистан", "O'zbekiston" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("7d7e10a3-6711-440b-8cae-f42804eabcb7"), new Guid("00000000-0000-0000-0000-000000000000"), null, "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems — ведущий мировой поставщик цифровой платформенной инженерии и разработки программного обеспечения.", "EPAM Systems dunyoning eng yuqori darajadagi raqamli platforma injenerlik va dasturlash xizmatlari taqdim etuvchi global tajribali kompaniyadir.", "Company", false, "EPAM", "EPAM", "EPAM", "EPAM" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("825c1d49-7e85-4370-9589-9e81c1e739f1"), null, "SocialNetwork", false, "Telegram", "Telegram", "Телеграм", "Telegram" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("8ac56ceb-327c-4aac-89b7-3d9f49664578"), null, "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Обеспечивает техническую поддержку и устранение неполадок для IT систем и конечных пользователей в организации.", "Tashkilot ichidagi IT tizimlari va foydalanuvchilar uchun texnik yordam va muammolar hal qilishni ta'minlash.", "Position", false, "IT Support Specialist", "IT Support Specialist", "Специалист по поддержке IT", "IT qo'llab-quvvat mutaxassis" },
                    { new Guid("8e0f1d00-3848-49a4-8f7a-509203e94013"), null, "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Основное понимание повседневных выражений и простых фраз. Можете представиться и задать базовые вопросы о личной информации.", "Kundalik ifodalar va oddiy iboralar o'rnating. O'zingizni tanishtirishingiz va shaxsiy ma'lumotlaringiz haqida oddiy savollar berishingiz mumkin.", "Level", false, "Elementary", "Elementary", "Начальный", "O'rtacha" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("aa8ad639-fdcb-4f36-b815-dbf633e133b7"), null, "SocialNetwork", false, "WhatsUp", "WhatsApp", "WhatsApp", "WhatsUp" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("b5f1064e-a1e3-47a8-99c5-eaad6ccc14e4"), new Guid("00000000-0000-0000-0000-000000000000"), null, "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition — международный поставщик услуг по разработке программного обеспечения, QA и консалтинга с акцентом на передовые технологии.", "ITransition yuqori texnologiyalar ustida qurilgan dasturlar va ilovalarni rivojlantirish, QA va konsalting xizmatlari taqdim etuvchi global kompaniyadir.", "Company", false, "ITransition", "ITransition", "ITransition", "ITransition" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("b6da8195-c7c7-470a-a7da-597e85aed801"), null, "SocialNetwork", false, "GitLab", "GitLab", "GitLab", "GitLab" },
                    { new Guid("be2d0cc2-79a5-403b-9341-d625e4478bce"), null, "Country", false, "South Korea", "South Korea", "Южная Корея", "Janubiy Koreya" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("c35e35bd-d254-43e3-985a-81caa58da01a"), null, "Responsible for maintaining and managing computer systems and networks within an organization.", "Responsible for maintaining and managing computer systems and networks within an organization.", "Ответственен за поддержание и управление компьютерными системами и сетями в организации.", "Tashkilot ichidagi kompyuter tizimlari va tarmoqlarni saqlash va boshqarishdan mas'ul.", "Position", false, "System Administrator", "System Administrator", "Системный администратор", "Tizim administratori" },
                    { new Guid("c70dcf80-ba5f-4a3e-9c32-2b56aec296d6"), null, "Employee works a standard number of hours per week as defined by the employer.", "Employee works a standard number of hours per week as defined by the employer.", "Сотрудник работает стандартное количество часов в неделю, определенное работодателем.", "Ishchi ish haftada ish joyi tomonidan belgilangan standart soatlar bo'yicha ishlaydi.", "WorkType", false, "Full-time", "Full-time", "Полный рабочий день", "To'la vaqti" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("cb8453fa-cf95-4b29-abfe-ca460118b052"), null, "SocialNetwork", false, "Twitter", "Twitter", "Твиттер", "Twitter" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("d6fe323f-1349-413d-9b97-999df77d70c3"), null, "Builds and maintains the client-side of web applications.", "Builds and maintains the client-side of web applications.", "Строит и поддерживает клиентскую часть веб-приложений.", "Veb ilovalarning mijoz tomonini yaratish va saqlash.", "Position", false, "Frontend Developer", "Frontend Developer", "Фронтенд разработчик", "Frontend dasturchi" },
                    { new Guid("d7e8c774-3a60-4c5b-b41a-21a887766461"), null, "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Комбинирует разработку программного обеспечения (Dev) и операции IT (Ops), обеспечивая непрерывную интеграцию и доставку программного обеспечения.", "Dastur ishlab chiqarish (Dev) va IT operatsiyalari (Ops)ni birlashtirib, dasturiy ta'minotlarni doimiy integratsiyasi va taqdimoti ta'minlash.", "Position", false, "DevOps Engineer", "DevOps Engineer", "Инженер DevOps", "DevOps muhandisi" },
                    { new Guid("e071de89-7cd4-4ac9-9173-62dfd6229536"), null, "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Проектирует пользовательские интерфейсы и интерфейсы пользователя для цифровых продуктов для улучшения удовлетворенности пользователя.", "Foydalanuvchi tajribalarini va raqamli mahsulotlar uchun foydalanuvchi interfeyslarini dizayn qilish, foydalanuvchining qoniqishini oshirish.", "Position", false, "UX/UI Designer", "UX/UI Designer", "Дизайнер UX/UI", "UX/UI dizayneri" },
                    { new Guid("e826eb35-eeac-40b2-ab1f-4a42fe0026ac"), null, "Analyzes complex data sets to help organizations make informed decisions.", "Analyzes complex data sets to help organizations make informed decisions.", "Анализирует сложные наборы данных, чтобы помочь организациям принимать обоснованные решения.", "Tashkilotlarga ma'lumotlardan foydalanishda yordam berish uchun murakkab ma'lumot to'plamlarini tahlil qiladi.", "Position", false, "Data Scientist", "Data Scientist", "Специалист по анализу данных", "Ma'lumot olimi" },
                    { new Guid("edf5b31d-a35b-4e88-a739-5e54320c2303"), null, "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Имеет полное владение языком, включая идиоматические выражения и разговорную речь. Говорит на языке бегло и точно.", "Istiqlolik va umumiy gaplashishdagi ona tili hisoblanadi, so'zlashishga ishonch keltiradi.", "Level", false, "Native", "Native", "Родной", "Ona tili" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("ee494401-9095-46ea-93c6-f0b67d3a7cd3"), new Guid("00000000-0000-0000-0000-000000000000"), null, "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel — это международная компания по разработке программного обеспечения, предоставляющая полный цикл разработки ПО, QA и тестирования.", "Exadel global dasturiy injinerlik kompaniyasi, to'liq tsikl dasturiy ta'minot, QA va sinov xizmatlari taqdim etadi.", "Company", false, "EXADEL", "EXADEL", "EXADEL", "EXADEL" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("f1aaab0e-fd3a-4b93-bf06-2a926dc6e940"), null, "SocialNetwork", false, "Skype", "Skype", "Skype", "Skype" },
                    { new Guid("fb75ee14-c75e-48af-a099-56c9c41778d2"), null, "Country", false, "Tajikistan", "Tajikistan", "Таджикистан", "Tojikiston" },
                    { new Guid("fd9fe4b7-7c51-405d-bd5d-48d6474706ae"), null, "Country", false, "Japan", "Japan", "Япония", "Yaponiya" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("fe5e6043-644b-424c-91b7-036e420e51cf"), new Guid("00000000-0000-0000-0000-000000000000"), null, "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB — это компания по разработке программного обеспечения и IT-консалтингу, специализирующаяся на разработке веб и мобильных приложений.", "BePro-DEVHUB veb va mobil ilovalar dasturlashida ihtisoslashgan dasturiy ta'minot va IT konsalting kompaniyasidir.", "Company", false, "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("fe637e68-b9ae-49b6-b162-83756d43ff7b"), null, "Country", false, "Kyrgyzstan", "Kyrgyzstan", "Киргизия", "Qirg'iziston" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CountyId", "CreatedById", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("05797799-d737-4b95-a027-05a64326d9ee"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Temirtau", "Temirtau", "Темиртау", "Temirtau" },
                    { new Guid("089e8e8a-a40f-4e36-894b-6c0e62796f91"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Atyrau", "Atyrau", "Атырау", "Atyrau" },
                    { new Guid("186a5475-1344-4697-898e-72bf64bc7bcc"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Olmaliq", "Olmaliq", "Олмалиқ", "Olmaliq" },
                    { new Guid("23d01184-c074-48d3-ac29-1bf6bfebafab"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Samarkand", "Samarkand", "Самарканд", "Samarqand" },
                    { new Guid("264d8795-b9f1-4a2c-abb9-5a58b2182156"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Margilan", "Margilan", "Маргилан", "Marg'ilon" },
                    { new Guid("2720d806-9e3f-4ab6-ac0f-f98627cd0f10"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Pavlodar", "Pavlodar", "Павлодар", "Pavlodar" },
                    { new Guid("2ed77a79-0fbc-43d6-bdc8-e847e6938686"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Kostanay", "Kostanay", "Костанай", "Kostanay" },
                    { new Guid("2efbb53e-9f47-4a91-bda5-d9a1c9ec2a0d"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Navoiy", "Navoiy", "Навоий", "Navoiy" },
                    { new Guid("48485b98-97a4-4763-ab4e-45fa0916bb5d"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Nukus", "Nukus", "Нукус", "Nukus" },
                    { new Guid("4d7d39d7-084d-4d77-81cd-d8ae39ef3b46"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Taraz", "Taraz", "Тараз", "Taraz" },
                    { new Guid("5653c687-5109-4499-8a5b-a9e2a20b7dcd"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Aktau", "Aktau", "Актау", "Aktau" },
                    { new Guid("5fb5d34a-8c8f-40c9-858c-df62c0e90944"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Kyzylorda", "Kyzylorda", "Кызылорда", "Kyzylorda" },
                    { new Guid("627e18e9-e089-436b-9b9c-605601e0cf27"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Bukhara", "Bukhara", "Бухара", "Buxoro" },
                    { new Guid("647e43a0-531e-4e3d-a711-e76232e880b5"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Ust-Kamenogorsk", "Ust-Kamenogorsk", "Усть-Каменогорск", "Ust-Kamenogorsk" },
                    { new Guid("65dcb207-34bf-41d9-986d-f0a3ff8cf38e"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Angren", "Angren", "Ангрен", "Angren" },
                    { new Guid("6c35504e-8c77-41ef-b486-098861d11ca5"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Nur-Sultan", "Nur-Sultan", "Нур-Султан", "Nur-Sultan" },
                    { new Guid("79aaee46-2bf3-4645-905a-5743415e410f"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Semey", "Semey", "Семей", "Semey" },
                    { new Guid("7ac07dbb-f3ac-4431-a566-38962e18325d"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Shymkent", "Shymkent", "Шымкент", "Shymkent" },
                    { new Guid("7d87f413-efd4-4313-8f9a-0d65cd20eb9b"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Namangan", "Namangan", "Наманган", "Namangan" },
                    { new Guid("843bb202-b89f-4f14-87c5-00bfcf8e5971"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Aktobe", "Aktobe", "Актобе", "Aktobe" },
                    { new Guid("8644e508-27de-4862-81a8-a7f326077bed"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Fergana", "Fergana", "Фергана", "Farg'ona" },
                    { new Guid("871b5b9a-f56c-4b7a-9812-657e9b1ea291"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Balqash", "Balqash", "Балхаш", "Balqash" },
                    { new Guid("87dc6e62-ce5b-49b0-91c9-23c9d06e2948"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Kokshetau", "Kokshetau", "Кокшетау", "Kokshetau" },
                    { new Guid("91078b75-15d4-4efb-b75b-e62f02f8fc6b"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Chirchiq", "Chirchiq", "Чирчик", "Chirchiq" },
                    { new Guid("917331bd-0a85-4db7-aed2-4b5f1782589b"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Urgench", "Urgench", "Ургенч", "Urganch" },
                    { new Guid("9805cd14-2a76-44e3-b603-438a791a1588"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Oral", "Oral", "Уральск", "Oral" },
                    { new Guid("9baecd59-6820-4bbb-8fef-47deb23b437c"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Petropavl", "Petropavl", "Петропавловск", "Petropavl" },
                    { new Guid("aa59dfa5-3c04-48cc-8fc1-585036d8193e"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Jizzakh", "Jizzakh", "Джизак", "Jizzax" },
                    { new Guid("b7d6d47f-723c-4f41-b3b5-9e80d2b2ec4a"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Termez", "Termez", "Термез", "Termiz" },
                    { new Guid("b90c3bde-7656-4784-8d36-a8e6c29304f5"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Kyzyl-Orda", "Kyzyl-Orda", "Кызылорда", "Kyzyl-Orda" },
                    { new Guid("baa8ab48-1134-42a3-a8f7-cdf6142c8cd4"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Bekobod", "Bekobod", "Бекобод", "Bekobod" },
                    { new Guid("bfd49bf2-01f2-4d3c-acb5-b2aac2e8b799"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Taldykorgan", "Taldykorgan", "Талдыкорган", "Taldykorgan" },
                    { new Guid("c111ddeb-f701-4a2e-862f-d1e918033997"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Andijan", "Andijan", "Андижан", "Andijon" },
                    { new Guid("c4c0486e-1f36-4e7a-a6c5-b774b366ba4f"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Almaty", "Almaty", "Алматы", "Almaty" },
                    { new Guid("c841ae8d-55da-4cf0-b977-6325db5cdbe0"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Qarshi", "Qarshi", "Карши", "Qarshi" },
                    { new Guid("c990d2b3-8295-487d-bb55-ed4ae081be4d"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Kokand", "Kokand", "Коканд", "Qo'qon" },
                    { new Guid("dea64ab9-38ac-4946-8e57-59d20b3d9826"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Tashkent", "Tashkent", "Ташкент", "Toshkent" },
                    { new Guid("e845d41c-d99a-4e30-a65f-a92f44cb105d"), new Guid("47d43abb-bc32-4d71-8b3b-dc2e77f4c987"), null, "City", false, "Karaganda", "Karaganda", "Караганда", "Karaganda" },
                    { new Guid("fd24566b-b37b-4f0e-8285-4ebe22fcd9a3"), new Guid("774cdeef-2ec6-452b-8b77-786d123383a2"), null, "City", false, "Shahrisabz", "Shahrisabz", "Шахрисабз", "Shahrisabz" }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "Education_CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("036ea1e2-9572-49df-9dd3-73eb175e99aa"), new Guid("dea64ab9-38ac-4946-8e57-59d20b3d9826"), null, "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "IT-академия «Наджот Таълим» - образовательное учреждение в Узбекистане, специализирующееся на образовании и тренинге в области информационных технологий.", "Najot Ta'lim IT Akademiyasi O'zbekistonda IT ta'limi va tayyorlash sohasiga ixtisoslashgan ta'lim muassasasi.", "Education", false, "Najot Ta'lim IT Academy", "Najot Ta'lim IT Academy", "IT-академия «Наджот Таълим»", "Najot Ta'lim IT Akademiyasi" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "AboutMe", "Birthday", "User_CityId", "CreatedById", "Discriminator", "Email", "EmailConfirmed", "Firstname", "Gender", "IsDeleted", "Lastname", "Middlename", "PasswordHash", "Phone", "PhotoName", "PositionId", "ResumeName", "UIThemeId" },
                values: new object[] { new Guid("55ae23c0-2852-460f-b918-eb40a6687c70"), "I am a junior Software Engineer. Skilled and curious young software engineer with 1.5 years of experience in building robust systems using .NET Core on backend and React, Typescript on frontend. Wants to design solid architecture and clean code. Good understanding of object oriented programming and fast learning.", new DateOnly(2002, 3, 16), new Guid("dea64ab9-38ac-4946-8e57-59d20b3d9826"), null, "User", "abduqodirovsarvar.2002@gmail.com", true, "Sarvarbek", 1, false, "Abduqodirov", "Xasan o'g'li", "hnCh7L+J7zhoRIEK6JSlWxRyPG5tWobtZxAFZO/5RwwQ6YK9oKQIm17KFOdH7U1nBt9QXjz7kRWFTOIAnqmnJg==", "+998932340316", null, new Guid("00000000-0000-0000-0000-000000000000"), null, null });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "Education_CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "Discriminator", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[] { new Guid("8adfdfe0-54b2-4840-9d90-5ca527ca7512"), new Guid("dea64ab9-38ac-4946-8e57-59d20b3d9826"), null, "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Ташкентский университет информационных технологий (ТАТУ) является ведущим образовательным учреждением в Узбекистане, специализирующимся в области ИТ и смежных направлений.", "Toshkent axborot texnologiyalari universiteti (TATU) O'zbekistonda IT va undan qo'shimcha sohalar bo'yicha yetakchi ta'lim muassasasi hisoblanadi.", "Education", false, "Tashkent University of Information Technologies", "Tashkent University of Information Technologies", "Ташкентский университет информационных технологий", "Toshkent axborot texnologiyalari universiteti" });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "SocialNetworkId", "UserSocialNetwork_Url", "UserSocialNetwork_UserId" },
                values: new object[,]
                {
                    { new Guid("08c34f4e-df60-481f-839c-03229139481b"), null, "UserSocialNetwork", false, new Guid("2af3c7b1-6d60-443d-8cbc-251a4beda498"), "https://github.com/AbduqodirovSarvar", new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") },
                    { new Guid("13224e19-0471-48e0-86ee-9368af808598"), null, "UserSocialNetwork", false, new Guid("825c1d49-7e85-4370-9589-9e81c1e739f1"), "https://t.me/Sarvarbek_Abduqodirov", new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") }
                });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "EducationId", "From", "IsDeleted", "To", "UserEducation_UserId" },
                values: new object[] { new Guid("1bf11bb3-0aee-49c4-be76-6ae88c378c5f"), null, "UserEducation", new Guid("8adfdfe0-54b2-4840-9d90-5ca527ca7512"), new DateOnly(2020, 9, 4), false, new DateOnly(2024, 6, 15), new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "SocialNetworkId", "UserSocialNetwork_Url", "UserSocialNetwork_UserId" },
                values: new object[] { new Guid("4a7ada3d-afe2-4fa5-81c1-cbb8e4657004"), null, "UserSocialNetwork", false, new Guid("b6da8195-c7c7-470a-a7da-597e85aed801"), "https://gitlab.com/Abduqodirov_Sarvar", new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "EducationId", "From", "IsDeleted", "To", "UserEducation_UserId" },
                values: new object[] { new Guid("5c1d4ef7-4023-49e3-b1e1-ebd7a1ec2b89"), null, "UserEducation", new Guid("036ea1e2-9572-49df-9dd3-73eb175e99aa"), new DateOnly(2022, 7, 1), false, new DateOnly(2023, 4, 30), new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") });

            migrationBuilder.InsertData(
                table: "BaseEntity",
                columns: new[] { "Id", "CreatedById", "Discriminator", "IsDeleted", "SocialNetworkId", "UserSocialNetwork_Url", "UserSocialNetwork_UserId" },
                values: new object[] { new Guid("cda4d3ab-03ed-40da-90ba-a05d472c1dc3"), null, "UserSocialNetwork", false, new Guid("01753ef1-9be5-43f7-ba3a-fb822ad87982"), "https://www.linkedin.com/in/abduqodirov-sarvarbek/", new Guid("55ae23c0-2852-460f-b918-eb40a6687c70") });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CityId",
                table: "BaseEntity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CompanyId",
                table: "BaseEntity",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CountyId",
                table: "BaseEntity",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Description_DescriptionUz_DescriptionRu_Descript~",
                table: "BaseEntity",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Education_CityId",
                table: "BaseEntity",
                column: "Education_CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_EducationId",
                table: "BaseEntity",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Email",
                table: "BaseEntity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_LanguageId",
                table: "BaseEntity",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_LevelId",
                table: "BaseEntity",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Name_NameUz_NameRu_NameEn",
                table: "BaseEntity",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Phone",
                table: "BaseEntity",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PositionId",
                table: "BaseEntity",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_SkillId",
                table: "BaseEntity",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_SocialNetworkId",
                table: "BaseEntity",
                column: "SocialNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_User_CityId",
                table: "BaseEntity",
                column: "User_CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserEducation_UserId",
                table: "BaseEntity",
                column: "UserEducation_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserExperience_PositionId",
                table: "BaseEntity",
                column: "UserExperience_PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserExperience_UserId",
                table: "BaseEntity",
                column: "UserExperience_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserLanguage_UserId_LanguageId",
                table: "BaseEntity",
                columns: new[] { "UserLanguage_UserId", "LanguageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserProject_UserId",
                table: "BaseEntity",
                column: "UserProject_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserProjectId",
                table: "BaseEntity",
                column: "UserProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserSkill_UserId_SkillId",
                table: "BaseEntity",
                columns: new[] { "UserSkill_UserId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserSocialNetwork_Url",
                table: "BaseEntity",
                column: "UserSocialNetwork_Url",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserSocialNetwork_UserId_SocialNetworkId",
                table: "BaseEntity",
                columns: new[] { "UserSocialNetwork_UserId", "SocialNetworkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_WorkTypeId",
                table: "BaseEntity",
                column: "WorkTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntity");
        }
    }
}
