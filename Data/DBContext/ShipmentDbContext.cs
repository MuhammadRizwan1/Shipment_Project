using Microsoft.EntityFrameworkCore;
using Shipment_Project.Model;

namespace Shipment_Project.Data.DBContext
{

    public class ShipmentDbContext : DbContext
    {
        public ShipmentDbContext(DbContextOptions<ShipmentDbContext> context) : base(context)
        {

        }

        public DbSet<Carrier> Carrier { get; set; }
        public DbSet<Shipment> Shipment { get; set; }
        public DbSet<Shipment_Rate> Shipment_Rate { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Shipper_Shipments_Detail> Shipper_Shipments_Detail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

    


}
