using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class finalMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 2,
                column: "AccommodationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 3,
                column: "AccommodationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 1,
                column: "ChallengeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 2,
                column: "ChallengeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 3,
                column: "ChallengeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 1,
                column: "IEPSummary",
                value: "JohnsonAlice_2022");

            migrationBuilder.InsertData(
                table: "IEPs",
                columns: new[] { "IEPId", "IEPSummary", "UserId" },
                values: new object[,]
                {
                    { 2, "SmithBob_2022", null },
                    { 3, "WilliamsCarol_2022", null },
                    { 4, "BrownDavid_2022", null },
                    { 5, "JonesEve_2022", null },
                    { 6, "MillerFrank_2022", null },
                    { 7, "DavisGrace_2022", null },
                    { 8, "GarciaHenry_2022", null },
                    { 9, "RodriguezIvy_2022", null },
                    { 10, "WilsonJack_2022", null },
                    { 11, "MartinezKaren_2022", null },
                    { 12, "AndersonLeo_2022", null },
                    { 13, "TaylorMia_2022", null },
                    { 14, "ThomasNick_2022", null },
                    { 15, "HernandezOlivia_2022", null },
                    { 16, "MoorePaul_2022", null },
                    { 17, "JacksonQuinn_2022", null },
                    { 18, "MartinRachel_2022", null },
                    { 19, "LeeSteve_2022", null },
                    { 20, "PerezTina_2022", null }
                });

            migrationBuilder.InsertData(
                table: "IEPAccommodations",
                columns: new[] { "IEPAccommodationId", "AccommodationId", "IEPId" },
                values: new object[,]
                {
                    { 4, 1, 2 },
                    { 5, 2, 2 },
                    { 6, 3, 2 },
                    { 7, 1, 3 },
                    { 8, 2, 3 },
                    { 9, 3, 3 },
                    { 10, 1, 4 },
                    { 11, 2, 4 },
                    { 12, 3, 4 },
                    { 13, 1, 5 },
                    { 14, 2, 5 },
                    { 15, 3, 5 },
                    { 16, 1, 6 },
                    { 17, 2, 6 },
                    { 18, 3, 6 },
                    { 19, 1, 7 },
                    { 20, 2, 7 },
                    { 21, 3, 7 },
                    { 22, 1, 8 },
                    { 23, 2, 8 },
                    { 24, 3, 8 },
                    { 25, 1, 9 },
                    { 26, 2, 9 },
                    { 27, 3, 9 },
                    { 28, 1, 10 },
                    { 29, 2, 10 },
                    { 30, 3, 10 },
                    { 31, 1, 11 },
                    { 32, 2, 11 },
                    { 33, 3, 11 },
                    { 34, 1, 12 },
                    { 35, 2, 12 },
                    { 36, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "IEPChallenges",
                columns: new[] { "IEPChallengeId", "ChallengeId", "IEPId" },
                values: new object[,]
                {
                    { 4, 4, 2 },
                    { 5, 5, 2 },
                    { 6, 6, 2 },
                    { 7, 4, 3 },
                    { 8, 8, 3 },
                    { 9, 9, 3 },
                    { 10, 1, 4 },
                    { 11, 4, 4 },
                    { 12, 14, 4 },
                    { 13, 12, 5 },
                    { 15, 10, 5 },
                    { 16, 8, 5 },
                    { 17, 1, 6 },
                    { 18, 3, 6 },
                    { 19, 6, 6 },
                    { 20, 7, 7 },
                    { 21, 8, 7 },
                    { 22, 9, 7 },
                    { 23, 7, 8 },
                    { 24, 6, 8 },
                    { 25, 9, 8 },
                    { 26, 7, 9 },
                    { 27, 4, 9 },
                    { 28, 9, 9 },
                    { 29, 7, 10 },
                    { 30, 11, 10 },
                    { 31, 9, 10 },
                    { 32, 7, 11 },
                    { 33, 12, 11 },
                    { 34, 9, 11 },
                    { 35, 7, 12 },
                    { 36, 14, 12 },
                    { 37, 9, 12 }
                });

            migrationBuilder.InsertData(
                table: "IEPPersons",
                columns: new[] { "IEPPersonId", "IEPId", "PersonId" },
                values: new object[,]
                {
                    { 3, 2, 2 },
                    { 4, 2, 32 },
                    { 5, 3, 3 },
                    { 6, 3, 33 },
                    { 7, 4, 4 },
                    { 8, 4, 34 },
                    { 9, 5, 5 },
                    { 10, 5, 35 },
                    { 11, 6, 6 },
                    { 12, 6, 36 },
                    { 13, 7, 7 },
                    { 14, 7, 37 },
                    { 15, 8, 8 },
                    { 16, 8, 38 },
                    { 17, 9, 9 },
                    { 18, 9, 39 },
                    { 19, 10, 10 },
                    { 20, 10, 40 },
                    { 21, 11, 11 },
                    { 22, 11, 41 },
                    { 23, 12, 12 },
                    { 24, 12, 42 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IEPPersons",
                keyColumn: "IEPPersonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 2,
                column: "AccommodationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "IEPAccommodations",
                keyColumn: "IEPAccommodationId",
                keyValue: 3,
                column: "AccommodationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 1,
                column: "ChallengeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 2,
                column: "ChallengeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "IEPChallenges",
                keyColumn: "IEPChallengeId",
                keyValue: 3,
                column: "ChallengeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "IEPs",
                keyColumn: "IEPId",
                keyValue: 1,
                column: "IEPSummary",
                value: "ScottGen_2011");
        }
    }
}
