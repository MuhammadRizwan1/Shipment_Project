using Microsoft.EntityFrameworkCore.Migrations;

namespace Shipment_Project.Migrations
{
    public partial class sp_Shipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = "Create PROCEDURE [dbo].[Shipper_Shipment_Details] @shipperId INT AS BEGIN SELECT t1.Shipment_id,t2.Shipper_name,t3.Carrier_name, t1.Shipment_description,t1.Shipment_weight, t4.Shipment_rate_description FROM dbo.Shipment t1 JOIN dbo.Shipper t2 ON t1.Shipper_id = @shipperId JOIN dbo.Carrier t3 ON t1.Carrier_id = t3.Carrier_id JOIN dbo.Shipment_Rate t4 ON t1.Shipment_rate_id = t4.Shipment_rate_id Where t1.Shipment_id=@shipperId ORDER BY t2.Shipper_name ASC; END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
