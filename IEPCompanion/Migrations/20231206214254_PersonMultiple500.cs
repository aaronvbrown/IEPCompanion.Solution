using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class PersonMultiple500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IEPs",
                columns: new[] { "IEPId", "IEPSummary", "UserId" },
                values: new object[] { 1, "ScottGen_2011", null });

            migrationBuilder.InsertData(
                table: "IEPAccommodations",
                columns: new[] { "IEPAccommodationId", "AccommodationId", "IEPId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "IEPChallenges",
                columns: new[] { "IEPChallengeId", "ChallengeId", "IEPId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 4, 1 },
                    { 3, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "IEPPersons",
                columns: new[] { "IEPPersonId", "IEPId", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 31 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 1);
        }
    }
}
