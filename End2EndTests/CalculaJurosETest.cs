using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests
{
    public class CalculaJurosETest : IClassFixture<WebApplicationFactory<CalculaJurosWebApi.Startup>>
    {
        private readonly WebApplicationFactory<CalculaJurosWebApi.Startup> _factory;

        public CalculaJurosETest(WebApplicationFactory<CalculaJurosWebApi.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData(100, 5)]
        public async Task CalculaJuros_Get_OkResponse(decimal valorInicial, int meses)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"api/CalculaJuros?valorInicial{valorInicial}&meses={meses}");

            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
