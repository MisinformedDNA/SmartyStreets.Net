StreetSmarts client library for .NET
=================
Use of this API requires free registration [here](http://smartystreets.com/). Official documentation for SmartyStreets is [here](http://smartystreets.com/kb/liveaddress-api).

----

*Making a request is easy.*

First set up your client

    _client = new SmartyStreetsClient(
        ConfigurationManager.AppSettings["smartystreets:AuthId"], 
        ConfigurationManager.AppSettings["smartystreets:AuthToken"]);

If you want to verify an address

    var request = new StreetAddressRequest
    {
        Street = "3785 s las vegs av.",
        City = "los vegos,",
        State = "nevada",
        Zipcode = "90210",
    };
  
    var response = await _client.StreetAddressAsync(request);
    var result = await response.GetResultsAsync();

You can also use their zipcode library

    private static async Task CityStateToZipcodeExample()
    {
        var request = new ZipcodeRequest { City = "Los Angeles", State = "California" };

        var response = await _client.ZipcodeAsync(request);
        var result = await response.GetResultsAsync();
    }

The official StreetSmarts API also allows for batch processing, which this API also supports.

    var response = await _client.StreetAddressAsync(new[] { request });

If you want to set custom headers in the request

    _client.HttpRequestHeaders.Add("x-standardize-only", "true")

If you want to have full control over deserialization and observing headers, the `HttpResponseMessage` is also included.

     var result = await response.ResponseMessage.Content.ReadAsStringAsync();

Please report any issues or suggestions. PRs appreciated.
