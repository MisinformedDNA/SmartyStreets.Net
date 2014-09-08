using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using SmartyStreets.Helpers;

namespace SmartyStreets
{
    public class SmartyStreetResponse<T>
    {
        private readonly HttpResponseMessage _responseMessage;

        public SmartyStreetResponse(HttpResponseMessage responseMessage)
        {
            _responseMessage = responseMessage;
        }

        public HttpResponseMessage ResponseMessage { get { return _responseMessage; } }

        public HttpStatusCode StatusCode { get { return _responseMessage.StatusCode; } }

        public async Task<List<T>> GetResultsAsync()
        {
            List<T> content;
            using (var stream = await _responseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer { ContractResolver = new SnakeCaseContractResolver() };
                content = serializer.Deserialize<List<T>>(jsonReader);
            }

            return content;
        }

    }
}
