using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests
{
    public class CalculaJurosETest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public CalculaJurosETest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Theory]
        [InlineData(100, 5)]
        public async Task RetornaTaxa_Get_OkResponse(decimal valorInicial, int meses)
        {
            // Act
            var response = await _client.GetAsync($"api/CalculaJuros?valorInicial{valorInicial}&meses={meses}");

            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
