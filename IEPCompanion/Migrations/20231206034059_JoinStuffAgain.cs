using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class JoinStuffAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                table: "IEPAccommodations");

            migrationBuilder.DropForeignKey(
                name: "FK_IEPPerson_IEPs_IEPId",
                table: "IEPPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_IEPPerson_Persons_PersonId",
                table: "IEPPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IEPPerson",
                table: "IEPPerson");

            migrationBuilder.RenameTable(
                name: "IEPPerson",
                newName: "IEPPersons");

            migrationBuilder.RenameIndex(
                name: "IX_IEPPerson_PersonId",
                table: "IEPPersons",
                newName: "IX_IEPPersons_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_IEPPerson_IEPId",
                table: "IEPPersons",
                newName: "IX_IEPPersons_IEPId");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "IEPAccommodations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IEPPersons",
                table: "IEPPersons",
                column: "IEPPersonId");

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

            migrationBuilder.CreateIndex(
                name: "IX_IEPChallenges_ChallengeId",
                table: "IEPChallenges",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_IEPChallenges_IEPId",
                table: "IEPChallenges",
                column: "IEPId");

            migrationBuilder.AddForeignKey(
                name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                table: "IEPAccommodations",
                column: "AccommodationId",
                principalTable: "Accommodations",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IEPPersons_IEPs_IEPId",
                table: "IEPPersons",
                column: "IEPId",
                principalTable: "IEPs",
                principalColumn: "IEPId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IEPPersons_Persons_PersonId",
                table: "IEPPersons",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                table: "IEPAccommodations");

            migrationBuilder.DropForeignKey(
                name: "FK_IEPPersons_IEPs_IEPId",
                table: "IEPPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_IEPPersons_Persons_PersonId",
                table: "IEPPersons");

            migrationBuilder.DropTable(
                name: "IEPChallenges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IEPPersons",
                table: "IEPPersons");

            migrationBuilder.RenameTable(
                name: "IEPPersons",
                newName: "IEPPerson");

            migrationBuilder.RenameIndex(
                name: "IX_IEPPersons_PersonId",
                table: "IEPPerson",
                newName: "IX_IEPPerson_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_IEPPersons_IEPId",
                table: "IEPPerson",
                newName: "IX_IEPPerson_IEPId");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "IEPAccommodations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IEPPerson",
                table: "IEPPerson",
                column: "IEPPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_IEPAccommodations_Accommodations_AccommodationId",
                table: "IEPAccommodations",
                column: "AccommodationId",
                principalTable: "Accommodations",
                principalColumn: "AccommodationId");

            migrationBuilder.AddForeignKey(
                name: "FK_IEPPerson_IEPs_IEPId",
                table: "IEPPerson",
                column: "IEPId",
                principalTable: "IEPs",
                principalColumn: "IEPId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IEPPerson_Persons_PersonId",
                table: "IEPPerson",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
