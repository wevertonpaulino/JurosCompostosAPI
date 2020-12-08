using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests
{
    public class ShowMeTheCodeETest : IClassFixture<WebApplicationFactory<CalculaJurosWebApi.Startup>>
    {
        private readonly WebApplicationFactory<CalculaJurosWebApi.Startup> _factory;

        public ShowMeTheCodeETest(WebApplicationFactory<CalculaJurosWebApi.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShowMeTheCode_Get_OkResponse()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"api/ShowMeTheCode");

            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
