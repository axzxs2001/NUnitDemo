using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MyWebProject.IntegrationTesting
{
    [Trait("MyWebProject", "ºØ≥…≤‚ ‘")]
    public class DrugControllerIntegrationTesting
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;
        public DrugControllerIntegrationTesting()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        private async Task<string> GetDrugsResponseJson()
        {
            var request = "/getdrugs";
            var response = await _client.GetAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        [Fact]
        public async Task ReturnInstructionsGivenEmptyQueryString()
        {
            var responseJson = await GetDrugsResponseJson();
            var backJson = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseJson>(responseJson);
            Assert.Equal(0, (backJson.data as IList).Count);         
        }

    }

    class ResponseJson
    {
        public int result
        { get; set; }
        public string message
        { get; set; }

        public dynamic data
        { get; set; }
    }
}
