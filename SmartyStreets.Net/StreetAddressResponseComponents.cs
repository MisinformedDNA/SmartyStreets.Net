using Newtonsoft.Json;

namespace SmartyStreets
{
    public class StreetAddressResponseComponents
    {
        public string Urbanization { get; set; }
        public string PrimaryNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetPredirection { get; set; }
        public string StreetPostdirection { get; set; }
        public string StreetSuffix { get; set; }
        public string SecondaryNumber { get; set; }
        public string SecondaryDesignator { get; set; }
        public string ExtraSecondaryNumber { get; set; }
        public string ExtraSecondaryDesignator { get; set; }
        public string PmbDesignator { get; set; }
        public string PmbNumber { get; set; }
        public string CityName { get; set; }
        public string DefaultCityName { get; set; }
        public string StateAbbreviation { get; set; }
        public string Zipcode { get; set; }

        [JsonProperty(PropertyName = "plus4_code")]
        public string Plus4Code { get; set; }

        public string DeliveryPoint { get; set; }
        public char DeliveryPointCheckDigit { get; set; }
    }
}
