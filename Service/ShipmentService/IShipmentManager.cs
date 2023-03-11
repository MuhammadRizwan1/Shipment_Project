using Shipment_Project.Model;
using Shipment_Project.Shared.Response;
using System.Collections.Generic;

namespace Shipment_Project.Service.ShipmentService
{
    public interface IShipmentManager
    {
        List<ShipperDetails> GetShipperDetails();
        List<Shipper_Shipments_Detail> ShipperShipmentDetails(int id);
    }
}
