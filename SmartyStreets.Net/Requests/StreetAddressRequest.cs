using Newtonsoft.Json;
using System.ComponentModel;

namespace SmartyStreets.Requests
{
    /// <summary>
    /// Request object to get street addresses
    /// </summary>
    /// <remarks>Documentation from http://smartystreets.com/kb/liveaddress-api/rest-endpoint </remarks>
    public class StreetAddressRequest
    {
        /// <summary>
        /// Any unique identifier that you use to reference the input address. The output will be identical to the input.
        /// </summary>
        public string InputId { get; set; }

        /// <summary>
        /// The street address, or a single-line (freeform*) address.
        /// * <a href="http://smartystreets.com/kb/faq/parse-and-verify-freeform-street-addresses">Important information about freeform addresses</a>
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Any extra address information
        /// </summary>
        [JsonProperty(PropertyName = "street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// If used, usually contains apartment or suite number. Should also contain the designator (apt, suite, unit...) or # as the default.
        /// </summary>
        public string Secondary { get; set; }

        /// <summary>
        /// The city name
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state name
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The ZIP Code
        /// </summary>
        public string Zipcode { get; set; }

        /// <summary>
        /// The city, state, and ZIP Code combined
        /// </summary>
        public string Lastline { get; set; }

        /// <summary>
        /// The recipient's name or FirmName. Can also be the company.
        /// </summary>
        public string Addressee { get; set; }

        /// <summary>
        /// Only used with Puerto Rican addresses
        /// </summary>
        public string Urbanization { get; set; }

        /// <summary>
        /// The maximum number of valid addresses returned when the input address is ambiguous.
        /// (Max = 10, default = 1)  <a href="http://smartystreets.com/kb/faq/how-do-you-handle-address-suggestions">Will this give me address suggestions?</a>
        /// </summary>
        [DefaultValue(1)]
        public int Candidates { get; set; }
    }
}
