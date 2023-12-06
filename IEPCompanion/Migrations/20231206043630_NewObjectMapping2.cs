using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class NewObjectMapping2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Email", "FirstName", "LastName", "Role", "UserId" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 50);

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
        }
    }
}
