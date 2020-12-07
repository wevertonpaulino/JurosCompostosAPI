using Moq;
using Xunit;

namespace UnitTests
{
    public class CalculaJurosUTest
    {
        // CalculaJurosController _controller;

        public CalculaJurosUTest()
        {
            // _controller = new CalculaJurosController();
        }

        [Fact]
        public void CalculaJuros_Get_ValorCalculado()
        {
            // Arrange
            var mock = new Mock<IRetornaTaxaService>();
            mock.Setup(x => x.Get()).Returns(0.01m);
            var controller = new CalculaJurosController(mock.Object);
            var expected = 105.10m;

            // Act
            var actual = controller.Get(100m, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
