using Microsoft.EntityFrameworkCore.Migrations;

namespace Shipment_Project.Migrations
{
    public partial class Shipper_Shipments_Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shipper_Shipments_Detail",
                columns: table => new
                {
                    Shipment_id = table.Column<int>(type: "int", nullable: false),
                    Shipper_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipment_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipment_weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipment_rate_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipper_Shipments_Detail");
        }
    }
}
