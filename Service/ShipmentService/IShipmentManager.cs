using Shipment_Project.Shared.Response;
using System.Collections.Generic;

namespace Shipment_Project.Service.ShipmentService
{
    public interface IShipmentManager
    {
        List<ShipperDetails> GetShipperDetails();
    }
}
