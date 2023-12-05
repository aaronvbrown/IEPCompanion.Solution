using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 51, "Alice.Johnson@email.com", "Alice", "Johnson", "Student", null },
                    { 52, "Bob.Smith@email.com", "Bob", "Smith", "Student", null },
                    { 53, "Carol.Williams@email.com", "Carol", "Williams", "Student", null },
                    { 54, "David.Brown@email.com", "David", "Brown", "Student", null },
                    { 55, "Eve.Jones@email.com", "Eve", "Jones", "Student", null },
                    { 56, "Frank.Miller@email.com", "Frank", "Miller", "Student", null },
                    { 57, "Grace.Davis@email.com", "Grace", "Davis", "Student", null },
                    { 58, "Henry.Garcia@email.com", "Henry", "Garcia", "Student", null },
                    { 59, "Ivy.Rodriguez@email.com", "Ivy", "Rodriguez", "Student", null },
                    { 60, "Jack.Wilson@email.com", "Jack", "Wilson", "Student", null },
                    { 61, "Karen.Martinez@email.com", "Karen", "Martinez", "Student", null },
                    { 62, "Leo.Anderson@email.com", "Leo", "Anderson", "Student", null },
                    { 63, "Mia.Taylor@email.com", "Mia", "Taylor", "Student", null },
                    { 64, "Nick.Thomas@email.com", "Nick", "Thomas", "Student", null },
                    { 65, "Olivia.Hernandez@email.com", "Olivia", "Hernandez", "Student", null },
                    { 66, "Paul.Moore@email.com", "Paul", "Moore", "Student", null },
                    { 67, "Quinn.Jackson@email.com", "Quinn", "Jackson", "Student", null },
                    { 68, "Rachel.Martin@email.com", "Rachel", "Martin", "Student", null },
                    { 69, "Steve.Lee@email.com", "Steve", "Lee", "Student", null },
                    { 70, "Tina.Perez@email.com", "Tina", "Perez", "Student", null },
                    { 71, "Uma.Thompson@email.com", "Uma", "Thompson", "Student", null },
                    { 72, "Victor.White@email.com", "Victor", "White", "Student", null },
                    { 73, "Wendy.Harris@email.com", "Wendy", "Harris", "Student", null },
                    { 74, "Xavier.Sanchez@email.com", "Xavier", "Sanchez", "Student", null },
                    { 75, "Yvonne.Clark@email.com", "Yvonne", "Clark", "Student", null },
                    { 76, "Zack.Ramirez@email.com", "Zack", "Ramirez", "Student", null },
                    { 77, "Amber.Lewis@email.com", "Amber", "Lewis", "Student", null },
                    { 78, "Brad.Robinson@email.com", "Brad", "Robinson", "Student", null },
                    { 79, "Cindy.Walker@email.com", "Cindy", "Walker", "Student", null },
                    { 80, "Derek.Young@email.com", "Derek", "Young", "Student", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accommodations");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 80);
        }
    }
}
