using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Shipment_Project.Model
{
    [Keyless]
    public class Shipper_Shipments_Detail
    {
        public int Shipment_id { get; set; }
        public string Shipper_name { get; set; }
        public string Carrier_name { get; set; }
        public string Shipment_description { get; set; }
        public string Shipment_weight { get; set; }
        public string Shipment_rate_description { get; set; }
    }
}
