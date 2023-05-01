using System;
using System.Text.Json.Serialization;


namespace WMI
{
    public class WMIDTO
    {
        [JsonPropertyName("Id")]
        public int id { get; set; }
        [JsonPropertyName("Name")]
        public string name { get; set; }
        [JsonPropertyName("Country")]
        public string country { get; set; }
        [JsonPropertyName("VehicleType")]
        public string vehicleType { get; set; }
        [JsonPropertyName("WMI")]
        public string wmi { get; set; }
        [JsonPropertyName("DateAvailableToPublic")]
        public DateTime dateAvailableToPublic { get; set; }
        [JsonPropertyName("CreatedOn")]
        public DateTime createdOn { get; set; }
        [JsonPropertyName("UpdatedOn")]
        public DateTime? updatedOn { get; set; }
    }
}
