using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class JoinEntitiesFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "IEPAccommodations",
                columns: table => new
                {
                    IEPAccommodationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IEPId = table.Column<int>(type: "int", nullable: false),
                    AccommodationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEPAccommodations", x => x.IEPAccommodationId);
                    table.ForeignKey(
                        name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodations",
                        principalColumn: "AccommodationId");
                    table.ForeignKey(
                        name: "FK_IEPAccommodations_IEPs_IEPId",
                        column: x => x.IEPId,
                        principalTable: "IEPs",
                        principalColumn: "IEPId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                    { 30, "Derek.Young@email.com", "Derek", "Young", "Student", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IEPAccommodations_AccommodationId",
                table: "IEPAccommodations",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPAccommodations_IEPId",
                table: "IEPAccommodations",
                column: "IEPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IEPAccommodations");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 30);

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
    }
}
