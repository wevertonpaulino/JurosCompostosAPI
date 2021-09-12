using CalculaJurosWebApi.Controllers;
using CalculaJurosWebApi.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class CalculaJurosUTest
    {
        [Fact]
        public async Task CalculaJuros_Get_ValorCalculado()
        {
            // Arrange
            var expected = 105.10m;
            var mock = new Mock<IRetornaTaxaService>();
            mock.Setup(x => x.GetAsync()).ReturnsAsync(0.01m);
            var controller = new CalculaJurosController(mock.Object);

            // Act
            var actual = await controller.GetAsync(100m, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
