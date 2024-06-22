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
                    { new Guid("0554ad50-0886-42aa-bed6-310d4da148e9"), null, false, "China", "China", "Китай", "Xitoy" },
                    { new Guid("29fd1533-9554-4b14-8f94-9ed7f45ff206"), null, false, "Kyrgyzstan", "Kyrgyzstan", "Киргизия", "Qirg'iziston" },
                    { new Guid("2faddd5c-ab6c-4138-b987-1ed1251684ec"), null, false, "Vietnam", "Vietnam", "Вьетнам", "Vyetnam" },
                    { new Guid("33c7d61b-7c9c-46e5-94ac-b0ad75c92553"), null, false, "South Korea", "South Korea", "Южная Корея", "Janubiy Koreya" },
                    { new Guid("5879b8b7-8375-42ae-a0d5-9119349e731b"), null, false, "Tajikistan", "Tajikistan", "Таджикистан", "Tojikiston" },
                    { new Guid("61d7fb5e-faac-4f4a-b42a-2443d4f88993"), null, false, "Turkey", "Turkey", "Турция", "Turkiya" },
                    { new Guid("760bb371-d778-496e-92d5-4428b5f0c3d0"), null, false, "Turkmenistan", "Turkmenistan", "Туркменистан", "Turkmaniston" },
                    { new Guid("8ada9c69-8bba-485a-aaad-7fa0f1e47ec2"), null, false, "Indonesia", "Indonesia", "Индонезия", "Indoneziya" },
                    { new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Kazakhstan", "Kazakhstan", "Казахстан", "Qozog'iston" },
                    { new Guid("cc71e08d-e67d-4e8b-87f4-4b68e34c4bff"), null, false, "Japan", "Japan", "Япония", "Yaponiya" },
                    { new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Uzbekistan", "Uzbekistan", "Узбекистан", "O'zbekiston" },
                    { new Guid("e6b711c6-12f5-4d1e-bf52-afdbda941acd"), null, false, "India", "India", "Индия", "Hindiston" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("5c07172e-6bcb-443d-b294-496c449a058d"), null, false, "Russian", "Russian", "Русский", "Ruscha" },
                    { new Guid("70535164-0c62-4301-8b5f-9813f66ee6f8"), null, false, "Uzbek", "Uzbek", "Узбекский", "O'zbekcha" },
                    { new Guid("7a261cef-ea9a-420d-81c9-d2347818dbb5"), null, false, "English", "English", "Английский", "Inglizcha" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("381b7747-5ece-47e9-b652-0bcb4bda14b3"), null, "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Can understand a wide range of demanding, longer texts, and recognize implicit meaning. Can express ideas fluently and spontaneously without much obvious searching for expressions.", "Можете понять широкий круг требовательных, длинных текстов и распознать неявное значение. Можете выражать идеи бегло и спонтанно без явного поиска выражений.", "Murakkab va uzun matnlarning keng tarqalgan qatorini tushunish va zimmasiz manoni aniqlash mumkin. Ideyalarni boshqarish uchun shifobaxsh va spantane so'zlashish, tushunarli talab qilmaydi.", false, "Advanced", "Advanced", "Продвинутый", "Yuqori" },
                    { new Guid("3aca9d2c-92a0-4be4-ab3f-02766385881c"), null, "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Can understand the main ideas of complex text on both concrete and abstract topics. Can interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.", "Можете понять основные идеи сложного текста по конкретным и абстрактным темам. Можете взаимодействовать с определенной степенью беглости и спонтанности, что делает регулярное общение с носителями языка возможным без напряжения для обеих сторон.", "Aniq yoki abstrakt mavzularda kompleks matnlarning asosiy o'zini tushunish mumkin. Huddi shaxsiyatli so'zlashish va spantane so'zlashish darajasida soddalik bilan amalga oshirish mumkin, bu esa har ikki taraf uchun ham zo'ravon bo'lishsiz mumkin.", false, "Upper-Intermediate", "Upper-Intermediate", "Выше среднего", "Yuqori o'rta" },
                    { new Guid("7660c0a7-4c9e-4808-adab-e5c1d5a44ac3"), null, "Basic understanding of the language with limited vocabulary and simple grammar.", "Basic understanding of the language with limited vocabulary and simple grammar.", "Основное понимание языка с ограниченным словарным запасом и простой грамматикой.", "O'z tilini boshlang'ich darajada o'rganish, chegaraviy so'zlashish va oddiy grammatikaga ega bo'lish.", false, "Beginner", "Beginner", "Начинающий", "Boshlang'ich" },
                    { new Guid("7f9a0e48-5177-4c05-bff5-9102c1ca7954"), null, "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Basic comprehension of everyday expressions and simple phrases. Can introduce yourself and ask basic questions about personal information.", "Основное понимание повседневных выражений и простых фраз. Можете представиться и задать базовые вопросы о личной информации.", "Kundalik ifodalar va oddiy iboralar o'rnating. O'zingizni tanishtirishingiz va shaxsiy ma'lumotlaringiz haqida oddiy savollar berishingiz mumkin.", false, "Elementary", "Elementary", "Начальный", "O'rtacha" },
                    { new Guid("c9ec08f1-14c8-4b51-9194-848359437939"), null, "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Has a complete command of the language, including idiomatic expressions and colloquialisms. Speaks the language fluently and accurately.", "Имеет полное владение языком, включая идиоматические выражения и разговорную речь. Говорит на языке бегло и точно.", "Istiqlolik va umumiy gaplashishdagi ona tili hisoblanadi, so'zlashishga ishonch keltiradi.", false, "Native", "Native", "Родной", "Ona tili" },
                    { new Guid("e42229d8-9e25-41d1-a098-5f4f5ce4dd95"), null, "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Can understand the main points of clear standard input on familiar matters. Can produce simple connected text on topics that are familiar or of personal interest.", "Можете понять основные моменты понятных стандартных вводов по знакомым вопросам. Можете составить простой связанный текст по темам, которые вам знакомы или интересны лично.", "Odatiy masalalar haqida bayonotdan foydalanib, asosiy nuqtalarni tushunish mumkin. Odatiy yoki shaxsiy qiziq mavzularida bog'liq oddiy bog'lanishgan matnlarni yaratish mumkin.", false, "Intermediate", "Intermediate", "Средний", "O'rta" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("11d91322-144a-4868-8903-154a5fc3c588"), null, "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Manages and maintains an organization's database systems, ensuring data security, integrity, and availability.", "Управляет и поддерживает базы данных организации, обеспечивая безопасность, целостность и доступность данных.", "Tashkilotning ma'lumotlar bazasini boshqarish va saqlash, ma'lumotlarni xavfsizligini, integritetini va mavjudligini ta'minlashdan mas'ul.", false, "Database Administrator", "Database Administrator", "Администратор баз данных", "Ma'lumotlar bazasi administratori" },
                    { new Guid("31697d4a-ac66-4c2d-ae2f-d7255c214f23"), null, "Responsible for maintaining and managing computer systems and networks within an organization.", "Responsible for maintaining and managing computer systems and networks within an organization.", "Ответственен за поддержание и управление компьютерными системами и сетями в организации.", "Tashkilot ichidagi kompyuter tizimlari va tarmoqlarni saqlash va boshqarishdan mas'ul.", false, "System Administrator", "System Administrator", "Системный администратор", "Tizim administratori" },
                    { new Guid("530f0de6-33da-4b36-bb5f-6e51d934545c"), null, "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Designs user experiences and user interfaces for digital products to enhance user satisfaction.", "Проектирует пользовательские интерфейсы и интерфейсы пользователя для цифровых продуктов для улучшения удовлетворенности пользователя.", "Foydalanuvchi tajribalarini va raqamli mahsulotlar uchun foydalanuvchi interfeyslarini dizayn qilish, foydalanuvchining qoniqishini oshirish.", false, "UX/UI Designer", "UX/UI Designer", "Дизайнер UX/UI", "UX/UI dizayneri" },
                    { new Guid("72344a2b-e548-4d71-ac67-e2c9040fd0b3"), null, "Analyzes complex data sets to help organizations make informed decisions.", "Analyzes complex data sets to help organizations make informed decisions.", "Анализирует сложные наборы данных, чтобы помочь организациям принимать обоснованные решения.", "Tashkilotlarga ma'lumotlardan foydalanishda yordam berish uchun murakkab ma'lumot to'plamlarini tahlil qiladi.", false, "Data Scientist", "Data Scientist", "Специалист по анализу данных", "Ma'lumot olimi" },
                    { new Guid("7a1f474f-b5d5-4f63-a897-bf3188a788e7"), null, "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Combines software development (Dev) and IT operations (Ops), ensuring continuous integration and delivery of software.", "Комбинирует разработку программного обеспечения (Dev) и операции IT (Ops), обеспечивая непрерывную интеграцию и доставку программного обеспечения.", "Dastur ishlab chiqarish (Dev) va IT operatsiyalari (Ops)ni birlashtirib, dasturiy ta'minotlarni doimiy integratsiyasi va taqdimoti ta'minlash.", false, "DevOps Engineer", "DevOps Engineer", "Инженер DevOps", "DevOps muhandisi" },
                    { new Guid("bb25d5dc-2004-4df8-a53e-30adf965fec3"), null, "Builds and maintains the client-side of web applications.", "Builds and maintains the client-side of web applications.", "Строит и поддерживает клиентскую часть веб-приложений.", "Veb ilovalarning mijoz tomonini yaratish va saqlash.", false, "Frontend Developer", "Frontend Developer", "Фронтенд разработчик", "Frontend dasturchi" },
                    { new Guid("cc511c47-990f-41c7-a35f-62bd3441260f"), null, "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Provides technical support and troubleshooting for IT systems and end-users within an organization.", "Обеспечивает техническую поддержку и устранение неполадок для IT систем и конечных пользователей в организации.", "Tashkilot ichidagi IT tizimlari va foydalanuvchilar uchun texnik yordam va muammolar hal qilishni ta'minlash.", false, "IT Support Specialist", "IT Support Specialist", "Специалист по поддержке IT", "IT qo'llab-quvvat mutaxassis" },
                    { new Guid("ea88d509-99e6-440c-afe4-0cbae73c7373"), null, "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Plans, organizes, and oversees IT projects, ensuring they are completed on time, within budget, and meet organizational requirements.", "Планирует, организует и контролирует IT проекты, обеспечивая их выполнение в срок, в рамках бюджета и в соответствии с требованиями организации.", "IT loyihalarini rejalashtirish, tashkil etish va boshqarish vaqti, byudjeti va tashkilot talablari bilan mos keladiganligini ta'minlash.", false, "IT Project Manager", "IT Project Manager", "Менеджер IT проектов", "IT loyihalash boshqaruvi" },
                    { new Guid("eb1a1bcb-ff8b-4f1c-8424-96c0a4376c5f"), null, "Develops and maintains the server-side logic of web applications.", "Develops and maintains the server-side logic of web applications.", "Разрабатывает и поддерживает серверную логику веб-приложений.", "Veb ilovalar server tomonidagi logikasini rivojlantirish va saqlash.", false, "Backend Developer", "Backend Developer", "Бэкенд разработчик", "Backend dasturchi" },
                    { new Guid("f0906650-55f9-44e7-8318-2ec280dfa2b1"), null, "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Monitors and protects an organization's computer systems and networks from cyber threats and attacks.", "Мониторит и защищает компьютерные системы и сети организации от киберугроз и атак.", "Tashkilotning kompyuter tizimlarini va tarmoqlarini onlayn xavf va hujumlaridan himoya qilish va nazorat qilish.", false, "IT Security Analyst", "IT Security Analyst", "Аналитик информационной безопасности", "IT Xavfsizlik tahliliy" },
                    { new Guid("f3821cdc-57f1-4e27-b453-83b24e8a801a"), null, "Designs, implements, and manages data communication networks such as LANs and WANs.", "Designs, implements, and manages data communication networks such as LANs and WANs.", "Проектирует, внедряет и управляет сетями передачи данных, такими как LAN и WAN.", "Mahalliy tarmoqlar (LAN) va keng sahalar (WAN) kabi ma'lumotlar almashish tarmoqlarini dizayn qilish, amalga oshirish va boshqarish.", false, "Network Engineer", "Network Engineer", "Сетевой инженер", "Tarmoq muhandisi" }
                });

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("34d78494-8612-415f-816c-7ed967bf527b"), null, false, "LinkedIn", "LinkedIn", "LinkedIn", "LinkedIn" },
                    { new Guid("41c1ccfc-b58c-45b4-8f4d-357888131e11"), null, false, "Twitter", "Twitter", "Твиттер", "Twitter" },
                    { new Guid("58dc40a4-e892-4a2b-ab72-a491b749921c"), null, false, "Imo", "Imo", "Imo", "Imo" },
                    { new Guid("646618d5-1034-4f2d-b86f-9db45374916a"), null, false, "Telegram", "Telegram", "Телеграм", "Telegram" },
                    { new Guid("6829ce6e-bcb5-4e7b-b5a8-7f46fe9af225"), null, false, "Instagram", "Instagram", "Инстаграм", "Instagram" },
                    { new Guid("8d596863-fdf1-446f-98ba-8f83738eaa88"), null, false, "Zoom", "Zoom", "Zoom", "Zoom" },
                    { new Guid("b8fac034-9ba1-4b57-8cc2-cf70aef772c6"), null, false, "GitHub", "GitHub", "GitHub", "GitHub" },
                    { new Guid("be443f0d-a194-43fb-afe2-354da91e8305"), null, false, "GitLab", "GitLab", "GitLab", "GitLab" },
                    { new Guid("cc1b88af-a918-4330-a81e-bf54fdc6ef06"), null, false, "Thread", "Thread", "Thread", "Thread" },
                    { new Guid("d155e1d8-d638-4fff-a2ae-3d252c9cb154"), null, false, "Skype", "Skype", "Skype", "Skype" },
                    { new Guid("e20b0a1d-761f-4be0-b5a8-57c9ba6e240e"), null, false, "WhatsUp", "WhatsApp", "WhatsApp", "WhatsUp" }
                });

            migrationBuilder.InsertData(
                table: "WorkTypes",
                columns: new[] { "Id", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("4542bdfc-2cbc-4485-ab38-50f072a99224"), null, "A student or trainee who works in a company to gain work experience.", "A student or trainee who works in a company to gain work experience.", "Студент или стажер, который работает в компании для получения опыта работы.", "Ish tajribasini olish uchun kompaniyada ishlovchi talaba yoki o'quvchi.", false, "Intern", "Intern", "Стажер", "Stajyor" },
                    { new Guid("b5b6b8fa-60bd-4dd7-87e6-599ba1263aea"), null, "Employee works a standard number of hours per week as defined by the employer.", "Employee works a standard number of hours per week as defined by the employer.", "Сотрудник работает стандартное количество часов в неделю, определенное работодателем.", "Ishchi ish haftada ish joyi tomonidan belgilangan standart soatlar bo'yicha ishlaydi.", false, "Full-time", "Full-time", "Полный рабочий день", "To'la vaqti" },
                    { new Guid("e552217c-60f6-40a4-91f3-cd5f804fb5df"), null, "Employee works from a location other than the office.", "Employee works from a location other than the office.", "Сотрудник работает не в офисе, а на удаленной основе.", "Ishchi ofisdan boshqa joydan ishlaydi.", false, "Remote", "Remote", "Удаленная работа", "Masofaviy" },
                    { new Guid("f9cfb973-847b-456d-a83e-4e5a5750f78a"), null, "Employee works fewer hours than a full-time employee.", "Employee works fewer hours than a full-time employee.", "Сотрудник работает меньше часов, чем на полный рабочий день.", "Ishchi to'la vaqtli ishchidan kam soat ishlaydi.", false, "Part-time", "Part-time", "Неполный рабочий день", "Qisman ish" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountyId", "CreatedById", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("00cf648f-85ef-4e91-8f85-81a5f87dbcf1"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Temirtau", "Temirtau", "Темиртау", "Temirtau" },
                    { new Guid("032d6d06-e71d-471f-8c07-03a83d1ed9b2"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Fergana", "Fergana", "Фергана", "Farg'ona" },
                    { new Guid("04645993-61be-44c6-8410-3dcce33776ea"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Ust-Kamenogorsk", "Ust-Kamenogorsk", "Усть-Каменогорск", "Ust-Kamenogorsk" },
                    { new Guid("0d318c82-ca9b-4026-aef3-7bd2e72b1c4e"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Aktobe", "Aktobe", "Актобе", "Aktobe" },
                    { new Guid("0ddb4194-8a3c-4c04-be21-b396b3c644fc"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Nukus", "Nukus", "Нукус", "Nukus" },
                    { new Guid("1aeb44cc-e679-4fa5-b9f8-818bcc5c5d0c"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Semey", "Semey", "Семей", "Semey" },
                    { new Guid("1fea4888-3394-4192-95ad-7610dd1a7995"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Margilan", "Margilan", "Маргилан", "Marg'ilon" },
                    { new Guid("222cb539-6c3c-4f00-937d-869b92de8774"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Kokshetau", "Kokshetau", "Кокшетау", "Kokshetau" },
                    { new Guid("262531f5-9b94-463d-973d-9225cef89623"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Taraz", "Taraz", "Тараз", "Taraz" },
                    { new Guid("28997ebe-298c-4a11-a46c-dffee6eae28b"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Urgench", "Urgench", "Ургенч", "Urganch" },
                    { new Guid("2a4524f6-0341-4f7b-b19b-56ba270b30c1"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Termez", "Termez", "Термез", "Termiz" },
                    { new Guid("2b4db697-f46e-4717-801c-816f10e5e307"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Bukhara", "Bukhara", "Бухара", "Buxoro" },
                    { new Guid("2caa4b81-9f5c-41dc-9ae8-606f1638f9d8"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Samarkand", "Samarkand", "Самарканд", "Samarqand" },
                    { new Guid("320233cd-d7f5-4c23-bce1-3147b69616fb"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Atyrau", "Atyrau", "Атырау", "Atyrau" },
                    { new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Tashkent", "Tashkent", "Ташкент", "Toshkent" },
                    { new Guid("4dd1affc-7d58-4c87-b022-26e1fcf5591c"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Chirchiq", "Chirchiq", "Чирчик", "Chirchiq" },
                    { new Guid("58087ff8-9dc9-45d7-810f-0edb13b6d4e3"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Taldykorgan", "Taldykorgan", "Талдыкорган", "Taldykorgan" },
                    { new Guid("6586ca4d-d5cb-4716-9284-fb8ac1079c59"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Navoiy", "Navoiy", "Навоий", "Navoiy" },
                    { new Guid("6cfe3480-9cb1-4fe7-a463-99a8f2e0a1a4"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Kyzyl-Orda", "Kyzyl-Orda", "Кызылорда", "Kyzyl-Orda" },
                    { new Guid("798527c0-ec1f-4599-9e98-4b93855a840b"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Andijan", "Andijan", "Андижан", "Andijon" },
                    { new Guid("7d14b288-47d6-454b-a2dd-42e66f1b2f91"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Kokand", "Kokand", "Коканд", "Qo'qon" },
                    { new Guid("87dce3dc-237a-4614-89a6-7c13f5d17dbc"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Balqash", "Balqash", "Балхаш", "Balqash" },
                    { new Guid("91413c5f-83d6-4a0c-afd3-a12623431810"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Shymkent", "Shymkent", "Шымкент", "Shymkent" },
                    { new Guid("974e06f1-5624-43c6-aa85-ce9e49e4392d"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Nur-Sultan", "Nur-Sultan", "Нур-Султан", "Nur-Sultan" },
                    { new Guid("9bb84bb9-beb5-40d5-8a5e-d8b0d20826cc"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Kyzylorda", "Kyzylorda", "Кызылорда", "Kyzylorda" },
                    { new Guid("9cb59fc6-5550-4a54-9835-bb2bd24598cf"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Olmaliq", "Olmaliq", "Олмалиқ", "Olmaliq" },
                    { new Guid("ada2b73c-ce71-453a-bf5a-44396e96aa52"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Pavlodar", "Pavlodar", "Павлодар", "Pavlodar" },
                    { new Guid("aed4a3c1-f088-493b-80a3-7ef420ffb2fb"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Oral", "Oral", "Уральск", "Oral" },
                    { new Guid("bc6c83ef-4270-4f41-804e-9d3c43206a38"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Kostanay", "Kostanay", "Костанай", "Kostanay" },
                    { new Guid("c2e9b36b-acb5-4292-b60b-e0b611aaff18"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Qarshi", "Qarshi", "Карши", "Qarshi" },
                    { new Guid("c355afdf-4beb-4cfc-a53e-a522acde7d25"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Bekobod", "Bekobod", "Бекобод", "Bekobod" },
                    { new Guid("c6731248-8b0e-43b0-97de-cac5b9fde572"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Karaganda", "Karaganda", "Караганда", "Karaganda" },
                    { new Guid("c9640d08-ade0-47ba-b235-e514542fe9d2"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Jizzakh", "Jizzakh", "Джизак", "Jizzax" },
                    { new Guid("ca5104fe-a277-4a36-8f6e-dff573db1d45"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Almaty", "Almaty", "Алматы", "Almaty" },
                    { new Guid("cbb27d8b-ae3e-415b-8576-32f804cb2e88"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Aktau", "Aktau", "Актау", "Aktau" },
                    { new Guid("d0b65890-5346-4519-84cf-9f770231b0c9"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Angren", "Angren", "Ангрен", "Angren" },
                    { new Guid("e09b7aa4-7e23-4448-b0e7-fcf14af88dc0"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Namangan", "Namangan", "Наманган", "Namangan" },
                    { new Guid("e45bd380-ff43-4e96-9c90-91e2bee9dc22"), new Guid("daab4085-2ff0-457a-9506-5160817359db"), null, false, "Shahrisabz", "Shahrisabz", "Шахрисабз", "Shahrisabz" },
                    { new Guid("eb178f3d-5673-4dbd-80d8-e5f703d0ac2e"), new Guid("a564c265-00bf-484b-93d0-04bb3f1b0c01"), null, false, "Petropavl", "Petropavl", "Петропавловск", "Petropavl" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("16006595-9063-4e15-9e96-61f9e46faa3f"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems is a leading global provider of digital platform engineering and software development services.", "EPAM Systems — ведущий мировой поставщик цифровой платформенной инженерии и разработки программного обеспечения.", "EPAM Systems dunyoning eng yuqori darajadagi raqamli platforma injenerlik va dasturlash xizmatlari taqdim etuvchi global tajribali kompaniyadir.", false, "EPAM", "EPAM", "EPAM", "EPAM" },
                    { new Guid("42b9e941-6015-4457-bb84-289bac982399"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel is a global software engineering company that provides full-cycle software development, QA, and testing services.", "Exadel — это международная компания по разработке программного обеспечения, предоставляющая полный цикл разработки ПО, QA и тестирования.", "Exadel global dasturiy injinerlik kompaniyasi, to'liq tsikl dasturiy ta'minot, QA va sinov xizmatlari taqdim etadi.", false, "EXADEL", "EXADEL", "EXADEL", "EXADEL" },
                    { new Guid("61e54c11-4ad9-4823-89a1-f54ff4934e07"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB is a software development and IT consulting company specializing in web and mobile app development.", "BePro-DEVHUB — это компания по разработке программного обеспечения и IT-консалтингу, специализирующаяся на разработке веб и мобильных приложений.", "BePro-DEVHUB veb va mobil ilovalar dasturlashida ihtisoslashgan dasturiy ta'minot va IT konsalting kompaniyasidir.", false, "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB", "BePro-DEVHUB" },
                    { new Guid("faca1e8b-fdfc-4249-a60b-b26907e437e4"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition is a global provider of software development, QA, and consulting services with a focus on advanced technologies.", "ITransition — международный поставщик услуг по разработке программного обеспечения, QA и консалтинга с акцентом на передовые технологии.", "ITransition yuqori texnologiyalar ustida qurilgan dasturlar va ilovalarni rivojlantirish, QA va konsalting xizmatlari taqdim etuvchi global kompaniyadir.", false, "ITransition", "ITransition", "ITransition", "ITransition" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CityId", "CreatedById", "Description", "DescriptionEn", "DescriptionRu", "DescriptionUz", "IsDeleted", "Name", "NameEn", "NameRu", "NameUz" },
                values: new object[,]
                {
                    { new Guid("080ae2fd-92bf-4c1f-9a0b-5a6ae3b8ae8c"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Tashkent University of Information Technologies (TUIT) is a leading educational institution in Uzbekistan specializing in IT and related fields.", "Ташкентский университет информационных технологий (ТАТУ) является ведущим образовательным учреждением в Узбекистане, специализирующимся в области ИТ и смежных направлений.", "Toshkent axborot texnologiyalari universiteti (TATU) O'zbekistonda IT va undan qo'shimcha sohalar bo'yicha yetakchi ta'lim muassasasi hisoblanadi.", false, "Tashkent University of Information Technologies", "Tashkent University of Information Technologies", "Ташкентский университет информационных технологий", "Toshkent axborot texnologiyalari universiteti" },
                    { new Guid("3dc42997-e346-436a-b876-ec8cdd704866"), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "Najot Ta'lim IT Academy is an educational institution in Uzbekistan that specializes in IT education and training.", "IT-академия «Наджот Таълим» - образовательное учреждение в Узбекистане, специализирующееся на образовании и тренинге в области информационных технологий.", "Najot Ta'lim IT Akademiyasi O'zbekistonda IT ta'limi va tayyorlash sohasiga ixtisoslashgan ta'lim muassasasi.", false, "Najot Ta'lim IT Academy", "Najot Ta'lim IT Academy", "IT-академия «Наджот Таълим»", "Najot Ta'lim IT Akademiyasi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AboutMe", "Birthday", "CityId", "CreatedById", "Email", "EmailConfirmed", "Firstname", "Gender", "IsDeleted", "Lastname", "Middlename", "PasswordHash", "Phone", "PhotoName", "PositionId", "ResumeName", "UIThemeId" },
                values: new object[] { new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac"), "I am a junior Software Engineer. Skilled and curious young software engineer with 1.5 years of experience in building robust systems using .NET Core on backend and React, Typescript on frontend. Wants to design solid architecture and clean code. Good understanding of object oriented programming and fast learning.", new DateOnly(2002, 3, 16), new Guid("326e9d9b-fff1-41f3-9832-e1538bbfb247"), null, "abduqodirovsarvar.2002@gmail.com", true, "Sarvarbek", 1, false, "Abduqodirov", "Xasan o'g'li", "hnCh7L+J7zhoRIEK6JSlWxRyPG5tWobtZxAFZO/5RwwQ6YK9oKQIm17KFOdH7U1nBt9QXjz7kRWFTOIAnqmnJg==", "+998932340316", null, new Guid("eb1a1bcb-ff8b-4f1c-8424-96c0a4376c5f"), null, null });

            migrationBuilder.InsertData(
                table: "UserEducations",
                columns: new[] { "Id", "CreatedById", "EducationId", "From", "IsDeleted", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("9326c966-d013-4962-aaeb-c701614909f9"), null, new Guid("080ae2fd-92bf-4c1f-9a0b-5a6ae3b8ae8c"), new DateOnly(2020, 9, 4), false, new DateOnly(2024, 6, 15), new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") },
                    { new Guid("afe899eb-50fb-48f0-b779-8617514f78c2"), null, new Guid("3dc42997-e346-436a-b876-ec8cdd704866"), new DateOnly(2022, 7, 1), false, new DateOnly(2023, 4, 30), new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") }
                });

            migrationBuilder.InsertData(
                table: "UserSocialNetworks",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "SocialNetworkId", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("1e18a7f1-9d84-4e38-af9d-e70e2b2b87d1"), null, false, new Guid("34d78494-8612-415f-816c-7ed967bf527b"), "https://www.linkedin.com/in/abduqodirov-sarvarbek/", new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") },
                    { new Guid("372e103e-acf4-411c-979f-560fc6ba8fe4"), null, false, new Guid("b8fac034-9ba1-4b57-8cc2-cf70aef772c6"), "https://github.com/AbduqodirovSarvar", new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") },
                    { new Guid("50f12780-bd12-408c-815f-7e0fc1e0f9fa"), null, false, new Guid("646618d5-1034-4f2d-b86f-9db45374916a"), "https://t.me/Sarvarbek_Abduqodirov", new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") },
                    { new Guid("7954a5b9-64f2-40aa-8514-4d98fe75509a"), null, false, new Guid("be443f0d-a194-43fb-afe2-354da91e8305"), "https://gitlab.com/Abduqodirov_Sarvar", new Guid("25ba6780-cc87-439c-aa51-b96c763c2eac") }
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
