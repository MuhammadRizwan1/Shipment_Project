using Microsoft.AspNetCore.Mvc;
using Shipment_Project.Service.ShipmentService;
using Shipment_Project.Shared.Response;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shipment_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentManager _shipmentManager;

        public ShipmentController(IShipmentManager shipmentManager)
        {
           _shipmentManager = shipmentManager;
        }


        [HttpGet("GetShipperDetails")]
        public List<ShipperDetails> GetShipperDetails()
        {
           var response= _shipmentManager.GetShipperDetails();
            return response;
        }



        [HttpGet("ShipperShipmentDetails")]
        public List<ShipperDetails> ShipperShipmentDetails(int shipperId)
        {
            var response = _shipmentManager.GetShipperDetails();
            return response;
        }









    }
}
