using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TussenTijdProject.Database.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fiscalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListPriceExclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenefitInKindPerMonth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountUpgradeInclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountDowngradeInclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiscalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelConsumption = table.Column<double>(type: "float", nullable: false),
                    EVConsumption = table.Column<double>(type: "float", nullable: false),
                    BatteryCapacity = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    MaxTowingCapacity = table.Column<int>(type: "int", nullable: false),
                    MaxDCCharging = table.Column<double>(type: "float", nullable: false),
                    MaxACCharging = table.Column<double>(type: "float", nullable: false),
                    IsManual = table.Column<bool>(type: "bit", nullable: false),
                    IsHeatPump = table.Column<bool>(type: "bit", nullable: false),
                    WLTPRange = table.Column<int>(type: "int", nullable: false),
                    RealRange = table.Column<int>(type: "int", nullable: false),
                    CO2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSpecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Pack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarType = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedDeliveryPeriodInMonths = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicalSpecsId = table.Column<int>(type: "int", nullable: false),
                    FiscalityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_Fiscalities_FiscalityId",
                        column: x => x.FiscalityId,
                        principalTable: "Fiscalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModels_TechnicalSpecs_TechnicalSpecsId",
                        column: x => x.TechnicalSpecsId,
                        principalTable: "TechnicalSpecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fiscalities",
                columns: new[] { "Id", "AmountDowngradeInclVAT", "AmountUpgradeInclVAT", "BenefitInKindPerMonth", "ListPriceExclVAT" },
                values: new object[,]
                {
                    { 1, 0m, 0m, 500m, 80000m },
                    { 2, 0m, 0m, 300m, 45000m },
                    { 3, 0m, 0m, 400m, 60000m }
                });

            migrationBuilder.InsertData(
                table: "TechnicalSpecs",
                columns: new[] { "Id", "BatteryCapacity", "CO2", "EVConsumption", "FuelConsumption", "Horsepower", "IsHeatPump", "IsManual", "MaxACCharging", "MaxDCCharging", "MaxTowingCapacity", "RealRange", "WLTPRange" },
                values: new object[,]
                {
                    { 1, 100, 0, 0.0, 0.0, 400, true, false, 11.0, 150.0, 2000, 450, 500 },
                    { 2, 0, 120, 0.0, 6.5, 150, false, false, 7.4000000000000004, 0.0, 1800, 350, 400 },
                    { 3, 0, 100, 0.0, 5.5, 200, false, true, 7.2000000000000002, 0.0, 1500, 500, 550 }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "Brand", "CarType", "Category", "ExpectedDeliveryPeriodInMonths", "FiscalityId", "FuelType", "Model", "Pack", "Remarks", "TechnicalSpecsId" },
                values: new object[,]
                {
                    { 1, 5, 3, 1, 3, 1, 1, "Model X", "Standard", "Luxury SUV", 1 },
                    { 2, 1, 3, 2, 2, 2, 0, "Tiguan", "Comfort", "Family SUV", 2 },
                    { 3, 0, 1, 3, 2, 3, 0, "A4", "Luxury", "Executive Sedan", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_FiscalityId",
                table: "CarModels",
                column: "FiscalityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_TechnicalSpecsId",
                table: "CarModels",
                column: "TechnicalSpecsId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Fiscalities");

            migrationBuilder.DropTable(
                name: "TechnicalSpecs");
        }
    }
}
