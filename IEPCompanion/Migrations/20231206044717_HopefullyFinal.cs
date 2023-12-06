using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IEPCompanion.Migrations
{
    public partial class HopefullyFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disability",
                table: "IEPs");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "IEPs");

            migrationBuilder.DropColumn(
                name: "SchoolYear",
                table: "IEPs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Disability",
                table: "IEPs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Goals",
                table: "IEPs",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "SchoolYear",
                table: "IEPs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
