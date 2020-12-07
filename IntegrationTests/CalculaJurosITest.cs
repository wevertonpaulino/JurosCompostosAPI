using Xunit;

namespace IntegrationTests
{
    public class CalculaJurosITest
    {
        CalculaJurosController _controller;

        public CalculaJurosITest()
        {
            _controller = new CalculaJurosController();
        }

        [Theory]
        [InlineData(100, 5)]
        public void CalculaJuros_Get_ValorCalculador(decimal valorInicial, int meses)
        {
            // Arrange
            var expected = 105.10m;

            // Act
            var actual = _controller.Get(valorInicial, meses);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
