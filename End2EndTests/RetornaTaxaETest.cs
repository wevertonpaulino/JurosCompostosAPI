using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTests
{
    public class RetornaTaxaETest : IClassFixture<WebApplicationFactory<RetornaTaxaWebApi.Startup>>
    {
        private readonly WebApplicationFactory<RetornaTaxaWebApi.Startup> _factory;

        public RetornaTaxaETest(WebApplicationFactory<RetornaTaxaWebApi.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task RetornaTaxa_Get_OkResponse()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("api/RetornaTaxa");

            // Assert
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
