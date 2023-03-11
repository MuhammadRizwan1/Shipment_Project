using System.ComponentModel.DataAnnotations;

namespace Shipment_Project.Model
{

    public class Shipment
    {
        [Key]
        public int Shipment_id { get; set; }
        public string Shipment_description { get; set; }
        public string Shipment_weight { get; set; }

        public Carrier Carrier { get; set; }
        public Shipment_Rate Shipment_Rate { get; set; }
        public Shipper Shipper { get; set; }
    }
}
