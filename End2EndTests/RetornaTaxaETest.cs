using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RetornaTaxaWebApi;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests
{
    public class RetornaTaxaETest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public RetornaTaxaETest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task RetornaTaxa_Get_OkResponse()
        {
            // Act
            var response = await _client.GetAsync("api/RetornaTaxa");

            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
