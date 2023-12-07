using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class PersonMultiple2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accommodations",
                columns: table => new
                {
                    AccommodationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodations", x => x.AccommodationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IEPs",
                columns: table => new
                {
                    IEPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IEPSummary = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEPs", x => x.IEPId);
                    table.ForeignKey(
                        name: "FK_IEPs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IEPAccommodations",
                columns: table => new
                {
                    IEPAccommodationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IEPId = table.Column<int>(type: "int", nullable: false),
                    AccommodationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEPAccommodations", x => x.IEPAccommodationId);
                    table.ForeignKey(
                        name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodations",
                        principalColumn: "AccommodationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IEPAccommodations_IEPs_IEPId",
                        column: x => x.IEPId,
                        principalTable: "IEPs",
                        principalColumn: "IEPId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IEPChallenges",
                columns: table => new
                {
                    IEPChallengeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ChallengeId = table.Column<int>(type: "int", nullable: false),
                    IEPId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEPChallenges", x => x.IEPChallengeId);
                    table.ForeignKey(
                        name: "FK_IEPChallenges_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "ChallengeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IEPChallenges_IEPs_IEPId",
                        column: x => x.IEPId,
                        principalTable: "IEPs",
                        principalColumn: "IEPId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IEPPersons",
                columns: table => new
                {
                    IEPPersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    IEPId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEPPersons", x => x.IEPPersonId);
                    table.ForeignKey(
                        name: "FK_IEPPersons_IEPs_IEPId",
                        column: x => x.IEPId,
                        principalTable: "IEPs",
                        principalColumn: "IEPId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IEPPersons_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Accommodations",
                columns: new[] { "AccommodationId", "Description" },
                values: new object[,]
                {
                    { 1, "Extended Time" },
                    { 2, "Frequent Breaks" },
                    { 3, "Modified Assignments" },
                    { 4, "Assistive Technology" },
                    { 5, "Preferred Seating" },
                    { 6, "Sensory Supports" },
                    { 7, "Visual Aids" },
                    { 8, "Verbal Instructions" },
                    { 9, "Note-taking Assistance" },
                    { 10, "Flexible Grading" },
                    { 11, "Alternative Testing Arrangements" },
                    { 12, "Behavioral Support Plan" },
                    { 13, "Speech/Language Services" },
                    { 14, "Occupational Therapy" },
                    { 15, "Physical Therapy" },
                    { 16, "Social Skills Training" },
                    { 17, "Transition Planning" }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "ChallengeId", "Description" },
                values: new object[,]
                {
                    { 1, "Learning Disabilities" },
                    { 2, "ADHD" },
                    { 3, "ASD" },
                    { 4, "Physical Disabilities" },
                    { 5, "Intellectual Disabilities" },
                    { 6, "Emotional or Behavioral Challenges" },
                    { 7, "Speech and Language Disorders" },
                    { 8, "Visual Impairments" },
                    { 9, "Hearing Impairments" },
                    { 10, "Medical Conditions" },
                    { 11, "Executive Functioning Deficits" },
                    { 12, "Social Skills Deficits" },
                    { 13, "Sensory Processing Issues" },
                    { 14, "Mental Health Challenges" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Email", "FirstName", "LastName", "Role", "UserId" },
                values: new object[,]
                {
                    { 1, "Alice.Johnson@email.com", "Alice", "Johnson", "Student", null },
                    { 2, "Bob.Smith@email.com", "Bob", "Smith", "Student", null },
                    { 3, "Carol.Williams@email.com", "Carol", "Williams", "Student", null },
                    { 4, "David.Brown@email.com", "David", "Brown", "Student", null },
                    { 5, "Eve.Jones@email.com", "Eve", "Jones", "Student", null },
                    { 6, "Frank.Miller@email.com", "Frank", "Miller", "Student", null },
                    { 7, "Grace.Davis@email.com", "Grace", "Davis", "Student", null },
                    { 8, "Henry.Garcia@email.com", "Henry", "Garcia", "Student", null },
                    { 9, "Ivy.Rodriguez@email.com", "Ivy", "Rodriguez", "Student", null },
                    { 10, "Jack.Wilson@email.com", "Jack", "Wilson", "Student", null },
                    { 11, "Karen.Martinez@email.com", "Karen", "Martinez", "Student", null },
                    { 12, "Leo.Anderson@email.com", "Leo", "Anderson", "Student", null },
                    { 13, "Mia.Taylor@email.com", "Mia", "Taylor", "Student", null },
                    { 14, "Nick.Thomas@email.com", "Nick", "Thomas", "Student", null },
                    { 15, "Olivia.Hernandez@email.com", "Olivia", "Hernandez", "Student", null },
                    { 16, "Paul.Moore@email.com", "Paul", "Moore", "Student", null },
                    { 17, "Quinn.Jackson@email.com", "Quinn", "Jackson", "Student", null },
                    { 18, "Rachel.Martin@email.com", "Rachel", "Martin", "Student", null },
                    { 19, "Steve.Lee@email.com", "Steve", "Lee", "Student", null },
                    { 20, "Tina.Perez@email.com", "Tina", "Perez", "Student", null },
                    { 21, "Uma.Thompson@email.com", "Uma", "Thompson", "Student", null },
                    { 22, "Victor.White@email.com", "Victor", "White", "Student", null },
                    { 23, "Wendy.Harris@email.com", "Wendy", "Harris", "Student", null },
                    { 24, "Xavier.Sanchez@email.com", "Xavier", "Sanchez", "Student", null },
                    { 25, "Yvonne.Clark@email.com", "Yvonne", "Clark", "Student", null },
                    { 26, "Zack.Ramirez@email.com", "Zack", "Ramirez", "Student", null },
                    { 27, "Amber.Lewis@email.com", "Amber", "Lewis", "Student", null },
                    { 28, "Brad.Robinson@email.com", "Brad", "Robinson", "Student", null },
                    { 29, "Cindy.Walker@email.com", "Cindy", "Walker", "Student", null },
                    { 30, "Derek.Young@email.com", "Derek", "Young", "Student", null },
                    { 31, "Alan.Taylor@email.com", "Alan", "Taylor", "Teacher", null },
                    { 32, "Beth.Morris@email.com", "Beth", "Morris", "Teacher", null },
                    { 33, "Cara.Ellis@email.com", "Cara", "Ellis", "Teacher", null },
                    { 34, "Derek.Grant@email.com", "Derek", "Grant", "Teacher", null },
                    { 35, "Elaine.Peters@email.com", "Elaine", "Peters", "Teacher", null },
                    { 36, "Frank.Olson@email.com", "Frank", "Olson", "Teacher", null },
                    { 37, "Gina.Harper@email.com", "Gina", "Harper", "Teacher", null },
                    { 38, "Hank.Bishop@email.com", "Hank", "Bishop", "Teacher", null },
                    { 39, "Irene.Knight@email.com", "Irene", "Knight", "Teacher", null },
                    { 40, "Jason.Sims@email.com", "Jason", "Sims", "Teacher", null },
                    { 41, "Kelly.Day@email.com", "Kelly", "Day", "Teacher", null },
                    { 42, "Leo.Reed@email.com", "Leo", "Reed", "Teacher", null },
                    { 43, "Mona.Cook@email.com", "Mona", "Cook", "Teacher", null },
                    { 44, "Nolan.Bailey@email.com", "Nolan", "Bailey", "Teacher", null },
                    { 45, "Olga.Dunn@email.com", "Olga", "Dunn", "Teacher", null },
                    { 46, "Paul.Brooks@email.com", "Paul", "Brooks", "Teacher", null },
                    { 47, "Quincy.Rice@email.com", "Quincy", "Rice", "Teacher", null },
                    { 48, "Rita.Payne@email.com", "Rita", "Payne", "Teacher", null },
                    { 49, "Sam.Black@email.com", "Sam", "Black", "Teacher", null },
                    { 50, "Tina.Woods@email.com", "Tina", "Woods", "Teacher", null },
                    { 51, "Uma.Tucker@email.com", "Uma", "Tucker", "Teacher", null },
                    { 52, "Victor.Porter@email.com", "Victor", "Porter", "Teacher", null },
                    { 53, "Wendy.Sanders@email.com", "Wendy", "Sanders", "Teacher", null },
                    { 54, "Xander.Price@email.com", "Xander", "Price", "Teacher", null },
                    { 55, "Yolanda.Burns@email.com", "Yolanda", "Burns", "Teacher", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IEPAccommodations_AccommodationId",
                table: "IEPAccommodations",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPAccommodations_IEPId",
                table: "IEPAccommodations",
                column: "IEPId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPChallenges_ChallengeId",
                table: "IEPChallenges",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPChallenges_IEPId",
                table: "IEPChallenges",
                column: "IEPId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPPersons_IEPId",
                table: "IEPPersons",
                column: "IEPId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPPersons_PersonId",
                table: "IEPPersons",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPs_UserId",
                table: "IEPs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_UserId",
                table: "Persons",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IEPAccommodations");

            migrationBuilder.DropTable(
                name: "IEPChallenges");

            migrationBuilder.DropTable(
                name: "IEPPersons");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Accommodations");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "IEPs");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
