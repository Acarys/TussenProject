using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TussenTijdProject.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsManual",
                table: "TechnicalSpecs");

            migrationBuilder.AddColumn<bool>(
                name: "IsManual",
                table: "CarModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsManual",
                value: false);

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsManual",
                value: false);

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsManual",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsManual",
                table: "CarModels");

            migrationBuilder.AddColumn<bool>(
                name: "IsManual",
                table: "TechnicalSpecs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TechnicalSpecs",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsManual",
                value: false);

            migrationBuilder.UpdateData(
                table: "TechnicalSpecs",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsManual",
                value: false);

            migrationBuilder.UpdateData(
                table: "TechnicalSpecs",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsManual",
                value: true);
        }
    }
}
