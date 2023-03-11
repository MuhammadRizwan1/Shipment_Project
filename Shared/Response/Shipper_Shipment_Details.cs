namespace Shipment_Project.Shared.Response
{
    public class Shipper_Shipment_Details
    {
        public int Shipment_id { get; set; }
        public string Shipper_name { get; set; }
        public string Carrier_name { get; set; }
        public string Shipment_description { get; set; }
        public string Shipment_weight { get; set; }
        public string Shipment_rate_description { get; set; }
    }
}
