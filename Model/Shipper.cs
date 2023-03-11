using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shipment_Project.Model
{
    public class Shipper
    {
        [Key]
        public int Shipper_id { get; set; }
        public string Shipper_name { get; set; }
        public ICollection<Shipment> Shipments { get; set; }
    }
}
