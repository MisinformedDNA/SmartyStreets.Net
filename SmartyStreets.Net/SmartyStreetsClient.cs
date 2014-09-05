using Newtonsoft.Json;
using SmartyStreets.Helpers;
using SmartyStreets.Requests;
using SmartyStreets.Responses;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SmartyStreets
{
    public class SmartyStreetsClient
    {
        private const string BaseUrl = "https://api.smartystreets.com/";

        private readonly string _authId;
        private readonly string _authToken;
        private readonly HttpClient _httpClient = new HttpClient();

        public SmartyStreetsClient(string authId, string authToken)
        {
            _authId = authId;
            _authToken = authToken;
        }

        /// <summary>
        /// Gets the headers which should be sent with each request. You may specify <a href="http://smartystreets.com/kb/liveaddress-api/rest-endpoint#headers">HTTP headers</a> with requests to the API to modify its behavior.
        /// </summary>
        public HttpRequestHeaders HttpRequestHeaders
        {
            get { return _httpClient.DefaultRequestHeaders; }
        }

        public async Task<SmartyStreetResponse<StreetAddressResponseResult>> StreetAddressAsync(params StreetAddressRequest[] streetAddresses)
        {
            var url = GetEndpoint("street-address");

            var serializer = new JsonSerializerSettings { ContractResolver = new SnakeCaseContractResolver() };
            var addressJson = JsonConvert.SerializeObject(streetAddresses, serializer);
            var content = new StringContent(addressJson, null, "application/json");

            var response = await _httpClient.PostAsync(url, content)
                .ConfigureAwait(false);

            return new SmartyStreetResponse<StreetAddressResponseResult>(response);
        }

        public async Task<SmartyStreetResponse<ZipcodeResponseResult>> ZipcodeAsync(params ZipcodeRequest[] zipcodes)
        {
            var url = GetEndpoint("zipcode");

            var serializer = new JsonSerializerSettings { ContractResolver = new SnakeCaseContractResolver() };
            var addressJson = JsonConvert.SerializeObject(zipcodes, serializer);
            var content = new StringContent(addressJson, null, "application/json");

            var response = await _httpClient.PostAsync(url, content)
                .ConfigureAwait(false);

            return new SmartyStreetResponse<ZipcodeResponseResult>(response);
        }

        private string GetEndpoint(string path)
        {
            return string.Format("{0}{1}?auth-id={2}&auth-token={3}", BaseUrl, path, _authId, _authToken);
        }
    }
}
