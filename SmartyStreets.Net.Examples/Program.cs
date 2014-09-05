using SmartyStreets.Requests;
using System.Configuration;
using System.Threading.Tasks;

namespace SmartyStreets.Net.Examples
{
    class Program
    {
        private static SmartyStreetsClient _client;

        static void Main()
        {
            _client = new SmartyStreetsClient(
                ConfigurationManager.AppSettings["smartystreets:AuthId"], 
                ConfigurationManager.AppSettings["smartystreets:AuthToken"]);

            Task.Run(() => StreetAddressExample()).Wait();
            Task.Run(() => ZipcodeToCityStateExample()).Wait();
            Task.Run(() => CityStateToZipcodeExample()).Wait();
            //Task.Run(() => ValidateCityStateZipcodeExample()).Wait();
            //Task.Run(() => InvalidCityStateZipcodeExample()).Wait();
        }

        private static async Task StreetAddressExample()
        {
            var request = new StreetAddressRequest
            {
                Street = "3785 s las vegs av.",
                City = "los vegos,",
                State = "nevada",
                Zipcode = "90210",
            };

            var response = await _client.StreetAddressAsync(new[] { request })
                .ConfigureAwait(false);
            var result = await response.GetResultsAsync()
                .ConfigureAwait(false);
        }

        private static async Task ZipcodeToCityStateExample()
        {
            var request = new ZipcodeRequest { Zipcode = "10167" };

            var response = await _client.ZipcodeAsync(new[] { request });
            var result = await response.GetResultsAsync();
        }

        private static async Task CityStateToZipcodeExample()
        {
            var request = new ZipcodeRequest { City = "Los Angeles", State = "California" };

            var response = await _client.ZipcodeAsync(request);
            var result = await response.GetResultsAsync();
        }

        private static async Task ValidateCityStateZipcodeExample()
        {
            var request = new ZipcodeRequest { City = "Los Angeles", State = "California", Zipcode = "90230" };

            var response = await _client.ZipcodeAsync(new[] { request });
            var result = await response.GetResultsAsync();
        }

        private static async Task InvalidCityStateZipcodeExample()
        {
            var request = new ZipcodeRequest { City = "Los Angeles", State = "California", Zipcode = "10167" };

            var response = await _client.ZipcodeAsync(new[] { request });
            var result = await response.GetResultsAsync();
        }

    }
}
