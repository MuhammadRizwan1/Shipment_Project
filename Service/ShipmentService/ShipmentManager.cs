using Shipment_Project.Data.DBContext;
using Shipment_Project.Shared.Response;
using System.Collections.Generic;
using System.Linq;

namespace Shipment_Project.Service.ShipmentService
{
    public class ShipmentManager : IShipmentManager
    {
        
        private readonly ShipmentDbContext _dbContext;

        public ShipmentManager(ShipmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ShipperDetails> GetShipperDetails()
        {
            var item = _dbContext.Shipper.Select(x=>x.Shipper_name).ToList();

            List<ShipperDetails> shipperDetails = new List<ShipperDetails>();
            foreach (var name in item)
            {
                shipperDetails.Add(new ShipperDetails()
                {
                    Shipper_name= name
                });
            }
            return shipperDetails;
        }
    }
}
