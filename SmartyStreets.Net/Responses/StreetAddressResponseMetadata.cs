namespace SmartyStreets.Responses
{
    public class StreetAddressResponseMetadata
    {
        public string RecordType { get; set; }
        public string ZipType { get; set; }
        public string CountyFips { get; set; }
        public string CountyName { get; set; }
        public string CarrierRoute { get; set; }
        public string CongressionalDistrict { get; set; }
        public string BuildingDefaultIndicator { get; set; }
        public string Rdi { get; set; }
        public string ElotSequence { get; set; }
        public string ElotSort { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Precision { get; set; }
        public string TimeZone { get; set; }
        public decimal UtcOffset { get; set; }
        public string Dst { get; set; }
    }
}
