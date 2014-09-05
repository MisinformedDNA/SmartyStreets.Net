namespace SmartyStreets.Requests
{
    /// <remarks>Documentation can be found at http://smartystreets.com/kb/liveaddress-api/zipcode-api </remarks>
    public class ZipcodeRequest
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}
