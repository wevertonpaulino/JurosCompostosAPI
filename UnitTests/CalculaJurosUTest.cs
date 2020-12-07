using CalculaJurosWebApi.Controllers;
using CalculaJurosWebApi.Services;
using Moq;
using Xunit;

namespace UnitTests
{
    public class CalculaJurosUTest
    {
        [Fact]
        public void CalculaJuros_Get_ValorCalculado()
        {
            // Arrange
            var expected = 105.10m;
            var mock = new Mock<IRetornaTaxaService>();
            mock.Setup(x => x.Get()).Returns(0.01m);
            var controller = new CalculaJurosController(mock.Object);

            // Act
            var actual = controller.Get(100m, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
