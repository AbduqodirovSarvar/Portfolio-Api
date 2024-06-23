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
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialNetworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialNetworks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CountyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountyId",
                        column: x => x.CountyId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    AboutMe = table.Column<string>(type: "text", nullable: true),
                    PhotoName = table.Column<string>(type: "text", nullable: true),
                    ResumeName = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    UIThemeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCertificates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CertificateUrl = table.Column<string>(type: "text", nullable: true),
                    Credential = table.Column<string>(type: "text", nullable: true),
                    Issued = table.Column<DateOnly>(type: "date", nullable: false),
                    CertificateFileName = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCertificates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEducations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationId = table.Column<Guid>(type: "uuid", nullable: false),
                    From = table.Column<DateOnly>(type: "date", nullable: false),
                    To = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEducations_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEducations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserExperiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    From = table.Column<DateOnly>(type: "date", nullable: true),
                    To = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserExperiences_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExperiences_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExperiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExperiences_WorkTypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "WorkTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    LevelId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UrlSrc = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: true),
                    PhotoName = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSocialNetworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SocialNetworkId = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocialNetworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSocialNetworks_SocialNetworks_SocialNetworkId",
                        column: x => x.SocialNetworkId,
                        principalTable: "SocialNetworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSocialNetworks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserProjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NameUz = table.Column<string>(type: "text", nullable: true),
                    NameEn = table.Column<string>(type: "text", nullable: true),
                    NameRu = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DescriptionUz = table.Column<string>(type: "text", nullable: true),
                    DescriptionEn = table.Column<string>(type: "text", nullable: true),
                    DescriptionRu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_UserProjects_UserProjectId",
                        column: x => x.UserProjectId,
                        principalTable: "UserProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhotoName = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("3052d949-5cfe-48fa-8be1-09f5b28ed669"), null, false, "Japan", "Japan", "Япония", "Yaponiya" },
                    { new Guid("32f0bf21-9280-4ec2-8bfa-0ee6828fe630"), null, false, "India", "India", "Индия", "Hindiston" },
                    { new Guid("367d1ae3-c434-4f50-9ace-c6ad11cc937b"), null, false, "Turkmenistan", "Turkmenistan", "Туркменистан", "Turkmaniston" },
                    { new Guid("3d91a53d-efe3-4cd7-ac84-351c89dc98ab"), null, false, "South Korea", "South Korea", "Южная Корея", "Janubiy Koreya" },
                    { new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Kazakhstan", "Kazakhstan", "Казахстан", "Qozog'iston" },
                    { new Guid("8f7b4afa-3365-45fc-b8de-1fab8cc3ae5c"), null, false, "Kyrgyzstan", "Kyrgyzstan", "Киргизия", "Qirg'iziston" },
                    { new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Uzbekistan", "Uzbekistan", "Узбекистан", "O'zbekiston" },
                    { new Guid("9d7f485e-2ffa-4836-b663-59495bfe7ae6"), null, false, "Vietnam", "Vietnam", "Вьетнам", "Vyetnam" },
                    { new Guid("aa068354-422e-4b9d-b532-8c804765d606"), null, false, "Indonesia", "Indonesia", "Индонезия", "Indoneziya" },
                    { new Guid("d1421225-c430-4f9c-a325-c2e6de210450"), null, false, "Tajikistan", "Tajikistan", "Таджикистан", "Tojikiston" },
                    { new Guid("e39e0351-b0f3-4845-a36b-51631c4140f3"), null, false, "China", "China", "Китай", "Xitoy" },
                    { new Guid("f0971cd0-b8db-4f7a-ae39-b9debf689819"), null, false, "Turkey", "Turkey", "Турция", "Turkiya" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("ae5e078e-2749-4181-b968-96320e976c61"), null, false, "Russian", "Russian", "Русский", "Ruscha" },
                    { new Guid("b6d53881-1149-4bfd-abf8-1baf741df770"), null, false, "Uzbek", "Uzbek", "Узбекский", "O'zbekcha" },
                    { new Guid("e9886a4a-8915-4d28-bec0-641c79882c66"), null, false, "English", "English", "Английский", "Inglizcha" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("16e364b5-31ca-48ca-8ece-e46feb5ec20f"), null, "Basic understanding of the language with limited vocabulary and simple grammar.", "Basic understanding of the language with limited vocabulary and simple grammar.", "Основное понимание языка с ограниченным словарным запасом и простой грамматикой.", "O'z tilini boshlang'ich darajada o'rganish, chegaraviy so'zlashish va oddiy grammatikaga ega bo'lish.", false, "Beginner", "Beginner", "Начинающий", "Boshlang'ich" },
                    { new Guid("2cb41146-06be-4095-b3e4-d59cc055efdc"), null, "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Можете понять основные моменты понятных стандартных вводов по знакомым вопросам. Можете составить простой связанный текст по темам, которые вам знакомы или интересны лично.", "Odatiy masalalar haqida bayonotdan foydalanib, asosiy nuqtalarni tushunish mumkin. Odatiy yoki shaxsiy qiziq mavzularida bog'liq oddiy bog'lanishgan matnlarni yaratish mumkin.", false, "Intermediate", "Intermediate", "Средний", "O'rta" },
                    { new Guid("6508bb79-c7fc-4966-8eac-ac7551627a40"), null, "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Можете понять широкий круг требовательных, длинных текстов и распознать неявное значение. Можете выражать идеи бегло и спонтанно без явного поиска выражений.", "Murakkab va uzun matnlarning keng tarqalgan qatorini tushunish va zimmasiz manoni aniqlash mumkin. Ideyalarni boshqarish uchun shifobaxsh va spantane so'zlashish, tushunarli talab qilmaydi.", false, "Advanced", "Advanced", "Продвинутый", "Yuqori" },
                    { new Guid("a0bcbbc7-3496-4717-993d-eaefda72fe7a"), null, "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Основное понимание повседневных выражений и простых фраз. Можете представиться и задать базовые вопросы о личной информации.", "Kundalik ifodalar va oddiy iboralar o'rnating. O'zingizni tanishtirishingiz va shaxsiy ma'lumotlaringiz haqida oddiy savollar berishingiz mumkin.", false, "Elementary", "Elementary", "Начальный", "O'rtacha" },
                    { new Guid("ec2dc7de-88c3-4299-8959-7482968a07cc"), null, "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Имеет полное владение языком, включая идиоматические выражения и разговорную речь. Говорит на языке бегло и точно.", "Istiqlolik va umumiy gaplashishdagi ona tili hisoblanadi, so'zlashishga ishonch keltiradi.", false, "Native", "Native", "Родной", "Ona tili" },
                    { new Guid("ed1150ef-d3b7-4640-8679-abc6d715315e"), null, "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Можете понять основные идеи сложного текста по конкретным и абстрактным темам. Можете взаимодействовать с определенной степенью беглости и спонтанности, что делает регулярное общение с носителями языка возможным без напряжения для обеих сторон.", "Aniq yoki abstrakt mavzularda kompleks matnlarning asosiy o'zini tushunish mumkin. Huddi shaxsiyatli so'zlashish va spantane so'zlashish darajasida soddalik bilan amalga oshirish mumkin, bu esa har ikki taraf uchun ham zo'ravon bo'lishsiz mumkin.", false, "Upper-Intermediate", "Upper-Intermediate", "Выше среднего", "Yuqori o'rta" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("016b41fc-cab3-4922-b5ea-a7c18eceb52c"), null, "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Проектирует пользовательские интерфейсы и интерфейсы пользователя для цифровых продуктов для улучшения удовлетворенности пользователя.", "Foydalanuvchi tajribalarini va raqamli mahsulotlar uchun foydalanuvchi interfeyslarini dizayn qilish, foydalanuvchining qoniqishini oshirish.", false, "UX/UI Designer", "UX/UI Designer", "Дизайнер UX/UI", "UX/UI dizayneri" },
                    { new Guid("2fe942d6-7ea0-4855-9a57-cf7db1d92a54"), null, "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Мониторит и защищает компьютерные системы и сети организации от киберугроз и атак.", "Tashkilotning kompyuter tizimlarini va tarmoqlarini onlayn xavf va hujumlaridan himoya qilish va nazorat qilish.", false, "IT Security Analyst", "IT Security Analyst", "Аналитик информационной безопасности", "IT Xavfsizlik tahliliy" },
                    { new Guid("4794e6a2-586f-4b9b-bee3-6194e1eef03e"), null, "Builds and maintains the client-side of web applications.", "Builds and maintains the client-side of web applications.", "Строит и поддерживает клиентскую часть веб-приложений.", "Veb ilovalarning mijoz tomonini yaratish va saqlash.", false, "Frontend Developer", "Frontend Developer", "Фронтенд разработчик", "Frontend dasturchi" },
                    { new Guid("7db3193d-e0f8-401f-b82e-a6a66e2efca1"), null, "Designs, implements, and manages data communication networks such as LANs and WANs.", "Designs, implements, and manages data communication networks such as LANs and WANs.", "Проектирует, внедряет и управляет сетями передачи данных, такими как LAN и WAN.", "Mahalliy tarmoqlar (LAN) va keng sahalar (WAN) kabi ma'lumotlar almashish tarmoqlarini dizayn qilish, amalga oshirish va boshqarish.", false, "Network Engineer", "Network Engineer", "Сетевой инженер", "Tarmoq muhandisi" },
                    { new Guid("a95d6e8e-4f91-4cd9-846a-39ec0830c0c4"), null, "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Планирует, организует и контролирует IT проекты, обеспечивая их выполнение в срок, в рамках бюджета и в соответствии с требованиями организации.", "IT loyihalarini rejalashtirish, tashkil etish va boshqarish vaqti, byudjeti va tashkilot talablari bilan mos keladiganligini ta'minlash.", false, "IT Project Manager", "IT Project Manager", "Менеджер IT проектов", "IT loyihalash boshqaruvi" },
                    { new Guid("b46b6d89-133f-4797-bcaa-91e7ce172026"), null, "Analyzes complex data sets to help organizations make informed decisions.", "Analyzes complex data sets to help organizations make informed decisions.", "Анализирует сложные наборы данных, чтобы помочь организациям принимать обоснованные решения.", "Tashkilotlarga ma'lumotlardan foydalanishda yordam berish uchun murakkab ma'lumot to'plamlarini tahlil qiladi.", false, "Data Scientist", "Data Scientist", "Специалист по анализу данных", "Ma'lumot olimi" },
                    { new Guid("b9e643fb-73e6-479c-a107-ea284c43227c"), null, "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Обеспечивает техническую поддержку и устранение неполадок для IT систем и конечных пользователей в организации.", "Tashkilot ichidagi IT tizimlari va foydalanuvchilar uchun texnik yordam va muammolar hal qilishni ta'minlash.", false, "IT Support Specialist", "IT Support Specialist", "Специалист по поддержке IT", "IT qo'llab-quvvat mutaxassis" },
                    { new Guid("bcc5a145-c58b-47c8-8519-f0d5933c4967"), null, "Develops and maintains the server-side logic of web applications.", "Develops and maintains the server-side logic of web applications.", "Разрабатывает и поддерживает серверную логику веб-приложений.", "Veb ilovalar server tomonidagi logikasini rivojlantirish va saqlash.", false, "Backend Developer", "Backend Developer", "Бэкенд разработчик", "Backend dasturchi" },
                    { new Guid("e1778088-b432-4a7b-8b6f-f1d38bbc8200"), null, "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Управляет и поддерживает базы данных организации, обеспечивая безопасность, целостность и доступность данных.", "Tashkilotning ma'lumotlar bazasini boshqarish va saqlash, ma'lumotlarni xavfsizligini, integritetini va mavjudligini ta'minlashdan mas'ul.", false, "Database Administrator", "Database Administrator", "Администратор баз данных", "Ma'lumotlar bazasi administratori" },
                    { new Guid("f1d915c7-7658-4a3e-9432-877160fd54a5"), null, "Responsible for maintaining and managing computer systems and networks within an organization.", "Responsible for maintaining and managing computer systems and networks within an organization.", "Ответственен за поддержание и управление компьютерными системами и сетями в организации.", "Tashkilot ichidagi kompyuter tizimlari va tarmoqlarni saqlash va boshqarishdan mas'ul.", false, "System Administrator", "System Administrator", "Системный администратор", "Tizim administratori" },
                    { new Guid("ff89880b-5320-43b6-9f4f-a88e46518daf"), null, "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Комбинирует разработку программного обеспечения (Dev) и операции IT (Ops), обеспечивая непрерывную интеграцию и доставку программного обеспечения.", "Dastur ishlab chiqarish (Dev) va IT operatsiyalari (Ops)ni birlashtirib, dasturiy ta'minotlarni doimiy integratsiyasi va taqdimoti ta'minlash.", false, "DevOps Engineer", "DevOps Engineer", "Инженер DevOps", "DevOps muhandisi" }
                });

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("4925a494-e019-4281-956a-e413d6c607a9"), null, false, "Thread", "Thread", "Thread", "Thread" },
                    { new Guid("62a2cc4a-10f7-4dae-9e96-f08ffea0d6a2"), null, false, "GitHub", "GitHub", "GitHub", "GitHub" },
                    { new Guid("669e99e6-be64-4f16-a0b3-ea776a0d0556"), null, false, "WhatsUp", "WhatsApp", "WhatsApp", "WhatsUp" },
                    { new Guid("8035dfdc-b624-41e3-b15f-a414cad63972"), null, false, "Twitter", "Twitter", "Твиттер", "Twitter" },
                    { new Guid("894c2ab5-0024-4975-877c-0500d461535c"), null, false, "Imo", "Imo", "Imo", "Imo" },
                    { new Guid("9df342f6-c144-4e61-8852-f4cad2095e8d"), null, false, "Skype", "Skype", "Skype", "Skype" },
                    { new Guid("a04ef71e-c3b6-4f4e-9175-7f7bc99d480e"), null, false, "Instagram", "Instagram", "Инстаграм", "Instagram" },
                    { new Guid("b4908f42-1acd-4d3a-9d3d-35bdee721c5f"), null, false, "Telegram", "Telegram", "Телеграм", "Telegram" },
                    { new Guid("bd6e8f4d-f019-40de-bed6-0302daec3ad2"), null, false, "LinkedIn", "LinkedIn", "LinkedIn", "LinkedIn" },
                    { new Guid("ed22a426-117b-473b-afc5-9b99a703e9af"), null, false, "GitLab", "GitLab", "GitLab", "GitLab" },
                    { new Guid("f09fa424-de4d-47df-9b54-30ce9d05cf73"), null, false, "Zoom", "Zoom", "Zoom", "Zoom" }
                });

            migrationBuilder.InsertData(
                table: "WorkTypes",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("0c3f849e-fd87-4ee2-a909-6b7a4316d2ab"), null, "Employee works from a location other than the office.", "Employee works from a location other than the office.", "Сотрудник работает не в офисе, а на удаленной основе.", "Ishchi ofisdan boshqa joydan ishlaydi.", false, "Remote", "Remote", "Удаленная работа", "Masofaviy" },
                    { new Guid("30a73bc1-816a-4057-a20a-77c335062f80"), null, "Employee works a standard number of hours per week as defined by the employer.", "Employee works a standard number of hours per week as defined by the employer.", "Сотрудник работает стандартное количество часов в неделю, определенное работодателем.", "Ishchi ish haftada ish joyi tomonidan belgilangan standart soatlar bo'yicha ishlaydi.", false, "Full-time", "Full-time", "Полный рабочий день", "To'la vaqti" },
                    { new Guid("e6ba724e-289b-41e9-8dc4-cc728a3d3e13"), null, "Employee works fewer hours than a full-time employee.", "Employee works fewer hours than a full-time employee.", "Сотрудник работает меньше часов, чем на полный рабочий день.", "Ishchi to'la vaqtli ishchidan kam soat ishlaydi.", false, "Part-time", "Part-time", "Неполный рабочий день", "Qisman ish" },
                    { new Guid("f9cabcd8-83de-4082-a47e-f0145da4d18a"), null, "A student or trainee who works in a company to gain work experience.", "A student or trainee who works in a company to gain work experience.", "Студент или стажер, который работает в компании для получения опыта работы.", "Ish tajribasini olish uchun kompaniyada ishlovchi talaba yoki o'quvchi.", false, "Intern", "Intern", "Стажер", "Stajyor" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountyId", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("07b67e15-c929-46e2-a99a-7ac99b572a07"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Kokshetau", "Kokshetau", "Кокшетау", "Kokshetau" },
                    { new Guid("098620f2-293a-4168-b609-d2797f70845c"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Nur-Sultan", "Nur-Sultan", "Нур-Султан", "Nur-Sultan" },
                    { new Guid("0f6e4451-9776-4510-83e0-ff88d56619f6"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Aktau", "Aktau", "Актау", "Aktau" },
                    { new Guid("11f1a887-a0c2-4565-94bf-aa208c2ef2ab"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Samarkand", "Samarkand", "Самарканд", "Samarqand" },
                    { new Guid("157e7898-0f9f-4fce-bc75-4f5fe4b451e0"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Bekobod", "Bekobod", "Бекобод", "Bekobod" },
                    { new Guid("3e9d70ea-4ba2-4d25-9b5c-bbe51dee1014"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Atyrau", "Atyrau", "Атырау", "Atyrau" },
                    { new Guid("41b5da6c-b6d8-4625-9505-8ddf75ca45df"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Temirtau", "Temirtau", "Темиртау", "Temirtau" },
                    { new Guid("468ddb5e-aaf0-4523-ac7e-11e3b57b2a08"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Margilan", "Margilan", "Маргилан", "Marg'ilon" },
                    { new Guid("4b616841-c6b2-4a2f-981c-43e4c704ddfd"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Jizzakh", "Jizzakh", "Джизак", "Jizzax" },
                    { new Guid("5b401895-effe-46e0-92af-228ac682ed63"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Chirchiq", "Chirchiq", "Чирчик", "Chirchiq" },
                    { new Guid("614d3978-715c-4edd-a126-a7f0b7e7354c"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Olmaliq", "Olmaliq", "Олмалиқ", "Olmaliq" },
                    { new Guid("8552eb55-afdc-435e-94a9-bc034eb28e69"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Termez", "Termez", "Термез", "Termiz" },
                    { new Guid("8a9de801-bbde-4095-9126-ef8bf488569c"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Qarshi", "Qarshi", "Карши", "Qarshi" },
                    { new Guid("8be69d5f-c6d3-4805-b2c8-3336ed0acbe0"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Pavlodar", "Pavlodar", "Павлодар", "Pavlodar" },
                    { new Guid("8c966490-2d2c-4755-a911-fb8491d177a6"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Karaganda", "Karaganda", "Караганда", "Karaganda" },
                    { new Guid("8d16fd06-f513-41f2-b283-8165d546c6bb"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Urgench", "Urgench", "Ургенч", "Urganch" },
                    { new Guid("8d473061-e350-40eb-9211-d9ef45980dc3"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Almaty", "Almaty", "Алматы", "Almaty" },
                    { new Guid("9fee7094-1d23-4226-8f90-eae6ffec14d8"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Kyzyl-Orda", "Kyzyl-Orda", "Кызылорда", "Kyzyl-Orda" },
                    { new Guid("a381e74a-ffcf-404d-b8a1-b9ebd37d0460"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Oral", "Oral", "Уральск", "Oral" },
                    { new Guid("a4ef6984-a30a-4ee5-bfbb-680c1b9d8d23"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Ust-Kamenogorsk", "Ust-Kamenogorsk", "Усть-Каменогорск", "Ust-Kamenogorsk" },
                    { new Guid("a6b5f06d-4725-4e00-a329-39be7d47211f"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Kyzylorda", "Kyzylorda", "Кызылорда", "Kyzylorda" },
                    { new Guid("acffa505-fdf9-4f9e-8162-dc7ec0a793e9"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Balqash", "Balqash", "Балхаш", "Balqash" },
                    { new Guid("ad2fae84-2313-4a30-a22d-df1b51b5aa2a"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Kostanay", "Kostanay", "Костанай", "Kostanay" },
                    { new Guid("af3110ad-1569-4c19-8405-0f7061e7a772"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Taraz", "Taraz", "Тараз", "Taraz" },
                    { new Guid("b6f3bc97-ed80-449b-b369-685274a813c4"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Shahrisabz", "Shahrisabz", "Шахрисабз", "Shahrisabz" },
                    { new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Tashkent", "Tashkent", "Ташкент", "Toshkent" },
                    { new Guid("bd8f3087-8b1d-47b0-aec2-834fdc755e0e"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Semey", "Semey", "Семей", "Semey" },
                    { new Guid("c36f74ed-6aaa-408f-95eb-fa2675112934"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Aktobe", "Aktobe", "Актобе", "Aktobe" },
                    { new Guid("c433408d-620b-46a9-b8e8-1527387331a7"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Kokand", "Kokand", "Коканд", "Qo'qon" },
                    { new Guid("c435e426-4018-41df-bd6d-56a94109cfc3"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Petropavl", "Petropavl", "Петропавловск", "Petropavl" },
                    { new Guid("cd0af469-4189-4734-9bb6-84d8453f85de"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Navoiy", "Navoiy", "Навоий", "Navoiy" },
                    { new Guid("cdd23826-33b3-49b3-ad38-9e33c7250171"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Bukhara", "Bukhara", "Бухара", "Buxoro" },
                    { new Guid("d7f8d5c4-ef59-456f-83e1-bf5a7f06dece"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Andijan", "Andijan", "Андижан", "Andijon" },
                    { new Guid("e662aafc-54c2-488c-8447-f31a9f386b48"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Shymkent", "Shymkent", "Шымкент", "Shymkent" },
                    { new Guid("e79c22d3-4fb8-4be1-84b3-fff530aaf60e"), new Guid("510a01df-dded-4781-8103-38824ed14e21"), null, false, "Taldykorgan", "Taldykorgan", "Талдыкорган", "Taldykorgan" },
                    { new Guid("e9d33853-2636-4b3f-9667-42589642ec58"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Namangan", "Namangan", "Наманган", "Namangan" },
                    { new Guid("ece17692-ede6-4aa3-a0fe-836066c7f558"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Fergana", "Fergana", "Фергана", "Farg'ona" },
                    { new Guid("edc99ae8-2353-42bc-b734-0fabf57204c6"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Angren", "Angren", "Ангрен", "Angren" },
                    { new Guid("f6c401c4-1ff7-4b7f-8a7f-9c3d3e2ef012"), new Guid("9d531d67-3d24-44aa-a02f-30513adad0bd"), null, false, "Nukus", "Nukus", "Нукус", "Nukus" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("097d238f-93cd-469a-89e4-4f346e494a50"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel — это международная компания по разработке программного обеспечения, предоставляющая полный цикл разработки ПО, QA и тестирования.", "Exadel global dasturiy injinerlik kompaniyasi, to'liq tsikl dasturiy ta'minot, QA va sinov xizmatlari taqdim etadi.", false, "EXADEL", "EXADEL", "EXADEL", "EXADEL" },
                    { new Guid("30e1eaab-3bef-404a-8dd9-59008d7e1738"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition — международный поставщик услуг по разработке программного обеспечения, QA и консалтинга с акцентом на передовые технологии.", "ITransition yuqori texnologiyalar ustida qurilgan dasturlar va ilovalarni rivojlantirish, QA va konsalting xizmatlari taqdim etuvchi global kompaniyadir.", false, "ITransition", "ITransition", "ITransition", "ITransition" },
                    { new Guid("7a9a5101-989a-49fb-9439-7ac0e3951026"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB — это компания по разработке программного обеспечения и IT-консалтингу, специализирующаяся на разработке веб и мобильных приложений.", "BePro-DEVHUB veb va mobil ilovalar dasturlashida ihtisoslashgan dasturiy ta'minot va IT konsalting kompaniyasidir.", false, "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB" },
                    { new Guid("9e8178aa-3469-4956-bf53-60db317920b8"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems — ведущий мировой поставщик цифровой платформенной инженерии и разработки программного обеспечения.", "EPAM Systems dunyoning eng yuqori darajadagi raqamli platforma injenerlik va dasturlash xizmatlari taqdim etuvchi global tajribali kompaniyadir.", false, "EPAM", "EPAM", "EPAM", "EPAM" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("8e83594e-9bd8-4422-93bd-be021c8bdeef"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "IT-академия «Наджот Таълим» - образовательное учреждение в Узбекистане, специализирующееся на образовании и тренинге в области информационных технологий.", "Najot Ta'lim IT Akademiyasi O'zbekistonda IT ta'limi va tayyorlash sohasiga ixtisoslashgan ta'lim muassasasi.", false, "Najot Ta'lim IT Academy", "Najot Ta'lim IT Academy", "IT-академия «Наджот Таълим»", "Najot Ta'lim IT Akademiyasi" },
                    { new Guid("c3631370-fe0b-4a79-9f10-daa2f734710b"), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Ташкентский университет информационных технологий (ТАТУ) является ведущим образовательным учреждением в Узбекистане, специализирующимся в области ИТ и смежных направлений.", "Toshkent axborot texnologiyalari universiteti (TATU) O'zbekistonda IT va undan qo'shimcha sohalar bo'yicha yetakchi ta'lim muassasasi hisoblanadi.", false, "Tashkent University of Information Technologies", "Tashkent University of Information Technologies", "Ташкентский университет информационных технологий", "Toshkent axborot texnologiyalari universiteti" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AboutMe", "Birthday", "CityId", "CreatedById", "Email", "EmailConfirmed", "Firstname", "Gender", "IsDeleted", "Lastname", "Middlename", "PasswordHash", "Phone", "PhotoName", "PositionId", "ResumeName", "UIThemeId" },
                values: new object[] { new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b"), "I am a junior Software Engineer. Skilled and curious young software engineer with 1.5 years of experience in building robust systems using .NET Core on backend and React, Typescript on frontend. Wants to design solid architecture and clean code. Good understanding of object oriented programming and fast learning.", new DateOnly(2002, 3, 16), new Guid("b71ce9ac-9663-45ac-a1c4-4d6bf75c1859"), null, "abduqodirovsarvar.2002@gmail.com", true, "Sarvarbek", 1, false, "Abduqodirov", "Xasan o'g'li", "hnCh7L+J7zhoRIEK6JSlWxRyPG5tWobtZxAFZO/5RwwQ6YK9oKQIm17KFOdH7U1nBt9QXjz7kRWFTOIAnqmnJg==", "+998932340316", null, new Guid("bcc5a145-c58b-47c8-8519-f0d5933c4967"), null, null });

            migrationBuilder.InsertData(
                table: "UserEducations",
                columns: new[] { "Id", "CreatedById", "EducationId", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("1daba635-2181-4f19-9d8d-5e97cc8aa27d"), null, new Guid("8e83594e-9bd8-4422-93bd-be021c8bdeef"), new DateOnly(2022, 7, 1), false, new DateOnly(2023, 4, 30), new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") },
                    { new Guid("fa239d3b-1ab9-478f-8aa3-d9ba091368f8"), null, new Guid("c3631370-fe0b-4a79-9f10-daa2f734710b"), new DateOnly(2020, 9, 4), false, new DateOnly(2024, 6, 15), new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") }
                });

            migrationBuilder.InsertData(
                table: "UserSocialNetworks",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "SocialNetworkId", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("0ee71b3e-4a35-41bb-aba0-8795260ad2a7"), null, false, new Guid("62a2cc4a-10f7-4dae-9e96-f08ffea0d6a2"), "https://github.com/AbduqodirovSarvar", new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") },
                    { new Guid("97728540-bbef-46d1-a05a-65c495bb596e"), null, false, new Guid("b4908f42-1acd-4d3a-9d3d-35bdee721c5f"), "https://t.me/Sarvarbek_Abduqodirov", new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") },
                    { new Guid("adbbd6c1-5b12-4f91-8aca-cddf08dcdbd0"), null, false, new Guid("ed22a426-117b-473b-afc5-9b99a703e9af"), "https://gitlab.com/Abduqodirov_Sarvar", new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") },
                    { new Guid("e99a96ce-92aa-40d8-aaaf-5ebe44197e59"), null, false, new Guid("bd6e8f4d-f019-40de-bed6-0302daec3ad2"), "https://www.linkedin.com/in/abduqodirov-sarvarbek/", new Guid("d02ec0e4-d41c-4ce8-a615-3f9eb160e69b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountyId",
                table: "Cities",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_NameUz_NameRu_NameEn",
                table: "Cities",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId_Name_NameEn_NameUz_NameRu_Description_Desc~",
                table: "Companies",
                columns: new[] { "CityId", "Name", "NameEn", "NameUz", "NameRu", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz" });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name_NameUz_NameRu_NameEn",
                table: "Countries",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CityId_Name_NameEn_NameUz_NameRu_Description_Des~",
                table: "Educations",
                columns: new[] { "CityId", "Name", "NameEn", "NameUz", "NameRu", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz" });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Name_NameUz_NameRu_NameEn",
                table: "Languages",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Description_DescriptionUz_DescriptionRu_DescriptionEn",
                table: "Levels",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Name_NameUz_NameRu_NameEn",
                table: "Levels",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Description_DescriptionUz_DescriptionRu_Descripti~",
                table: "Positions",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Name_NameUz_NameRu_NameEn",
                table: "Positions",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Description_DescriptionUz_DescriptionRu_DescriptionEn",
                table: "Skills",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Name_NameUz_NameRu_NameEn",
                table: "Skills",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserProjectId",
                table: "Skills",
                column: "UserProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialNetworks_Name_NameUz_NameRu_NameEn",
                table: "SocialNetworks",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Themes_Name_NameUz_NameRu_NameEn",
                table: "Themes",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCertificates_Description_DescriptionUz_DescriptionRu_De~",
                table: "UserCertificates",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCertificates_Name_NameUz_NameRu_NameEn",
                table: "UserCertificates",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCertificates_UserId",
                table: "UserCertificates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEducations_EducationId",
                table: "UserEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEducations_UserId",
                table: "UserEducations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExperiences_CompanyId",
                table: "UserExperiences",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExperiences_PositionId",
                table: "UserExperiences",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExperiences_UserId",
                table: "UserExperiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExperiences_WorkTypeId",
                table: "UserExperiences",
                column: "WorkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_LanguageId",
                table: "UserLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_LevelId",
                table: "UserLanguages",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_UserId_LanguageId",
                table: "UserLanguages",
                columns: new[] { "UserId", "LanguageId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_Description_DescriptionUz_DescriptionRu_Descri~",
                table: "UserProjects",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_Name_NameUz_NameRu_NameEn",
                table: "UserProjects",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserProjects_UserId",
                table: "UserProjects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionId",
                table: "Users",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_UserId_SkillId",
                table: "UserSkills",
                columns: new[] { "UserId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialNetworks_SocialNetworkId",
                table: "UserSocialNetworks",
                column: "SocialNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialNetworks_Url",
                table: "UserSocialNetworks",
                column: "Url",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSocialNetworks_UserId_SocialNetworkId",
                table: "UserSocialNetworks",
                columns: new[] { "UserId", "SocialNetworkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTypes_Description_DescriptionUz_DescriptionRu_Descripti~",
                table: "WorkTypes",
                columns: new[] { "Description", "DescriptionUz", "DescriptionRu", "DescriptionEn" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTypes_Name_NameUz_NameRu_NameEn",
                table: "WorkTypes",
                columns: new[] { "Name", "NameUz", "NameRu", "NameEn" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "UserCertificates");

            migrationBuilder.DropTable(
                name: "UserEducations");

            migrationBuilder.DropTable(
                name: "UserExperiences");

            migrationBuilder.DropTable(
                name: "UserLanguages");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "UserSocialNetworks");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialNetworks");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
