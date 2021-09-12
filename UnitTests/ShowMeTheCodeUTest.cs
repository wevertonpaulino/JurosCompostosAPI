using CalculaJurosWebApi.Controllers;
using Xunit;

namespace UnitTests
{
    public class ShowMeTheCodeUTest
    {
        private readonly ShowMeTheCodeController _controller;

        public ShowMeTheCodeUTest()
        {
            _controller = new ShowMeTheCodeController();
        }

        [Fact]
        public void ShowMeTheCode_Get_Url()
        {
            // Arrange
            var expected = "https://github.com/wevertonpaulino/JurosCompostosAPI";

            // Act
            var actual = _controller.Get();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
