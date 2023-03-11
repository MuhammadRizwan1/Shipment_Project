using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shipment_Project.Data.DBContext;
using Shipment_Project.Model;
using Shipment_Project.Shared.Response;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

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

        public  List<Shipper_Shipments_Detail> ShipperShipmentDetails(int id)
        {
            try
            {
                var ssidParam = new SqlParameter("@shipperId", id);
                var result = _dbContext.Shipper_Shipments_Detail.FromSqlRaw("exec Shipper_Shipment_Details @shipperId", ssidParam).AsNoTracking().ToList();
                return result;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
