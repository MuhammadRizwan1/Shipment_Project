using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shipment_Project.Model
{
    public class Carrier
    {
        [Key]
        public int Carrier_id { get; set; }
        public string Carrier_name { get; set; }
        public string Carrier_mode { get; set; }

        public ICollection<Shipment> Shipments { get; set; }
    }
}
