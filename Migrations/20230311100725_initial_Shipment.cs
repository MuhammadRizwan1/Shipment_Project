using Microsoft.EntityFrameworkCore.Migrations;

namespace Shipment_Project.Migrations
{
    public partial class initial_Shipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    Carrier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carrier_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier_mode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.Carrier_id);
                });

            migrationBuilder.CreateTable(
                name: "Shipment_Rate",
                columns: table => new
                {
                    Shipment_rate_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shipment_rate_class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipment_rate_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment_Rate", x => x.Shipment_rate_id);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    Shipper_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shipper_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.Shipper_id);
                });

            migrationBuilder.CreateTable(
                name: "Shipment",
                columns: table => new
                {
                    Shipment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shipment_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipment_weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier_id = table.Column<int>(type: "int", nullable: true),
                    Shipment_rate_id = table.Column<int>(type: "int", nullable: true),
                    Shipper_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment", x => x.Shipment_id);
                    table.ForeignKey(
                        name: "FK_Shipment_Carrier_Carrier_id",
                        column: x => x.Carrier_id,
                        principalTable: "Carrier",
                        principalColumn: "Carrier_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Shipment_Rate_Shipment_rate_id",
                        column: x => x.Shipment_rate_id,
                        principalTable: "Shipment_Rate",
                        principalColumn: "Shipment_rate_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipment_Shipper_Shipper_id",
                        column: x => x.Shipper_id,
                        principalTable: "Shipper",
                        principalColumn: "Shipper_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_Carrier_id",
                table: "Shipment",
                column: "Carrier_id");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_Shipment_rate_id",
                table: "Shipment",
                column: "Shipment_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_Shipper_id",
                table: "Shipment",
                column: "Shipper_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipment");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropTable(
                name: "Shipment_Rate");

            migrationBuilder.DropTable(
                name: "Shipper");
        }
    }
}
