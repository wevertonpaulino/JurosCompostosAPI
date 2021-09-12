using CalculaJurosWebApi.Controllers;
using CalculaJurosWebApi.Services;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class CalculaJurosITest
    {
        private readonly CalculaJurosController _controller;
        private readonly RetornaTaxaService _service;

        public CalculaJurosITest()
        {
            _service = new RetornaTaxaService();
            _controller = new CalculaJurosController(_service);
        }

        [Theory]
        [InlineData(100, 5)]
        public async Task CalculaJuros_Get_ValorCalculado(decimal valorInicial, int meses)
        {
            // Arrange
            var expected = 105.10m;

            // Act
            var actual = await _controller.GetAsync(valorInicial, meses);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
