namespace SmartyStreets.Responses
{
    public class StreetAddressResponseResult
    {
        public string InputId { get; set; }
        public int InputIndex { get; set; }
        public int CandidateIndex { get; set; }
        public string Addressee { get; set; }
        public string DeliveryLine1 { get; set; }
        public string DeliveryLine2 { get; set; }
        public string LastLine { get; set; }
        public string DeliveryPointBarcode { get; set; }

        public StreetAddressResponseComponents Components { get; set; }
        public StreetAddressResponseMetadata Metadata { get; set; }
        public StreetAddressResponseAnalysis Analysis { get; set; }
    }
}
