using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shipment_Project.Model
{
    public class Shipment_Rate
    {
        [Key]
        public int Shipment_rate_id { get; set; }
        public string Shipment_rate_class { get; set; }
        public string Shipment_rate_description { get; set; }
        public ICollection<Shipment> Shipments { get; set; }
    }
}
