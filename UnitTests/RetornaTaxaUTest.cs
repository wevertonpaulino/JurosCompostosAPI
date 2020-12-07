using System;
using Xunit;

namespace UnitTests
{
    public class RetornaTaxaUTest
    {
        RetornaTaxaController _controller;

        public RetornaTaxaUTest()
        {
            _controller = new RetornaTaxaController();
        }

        [Fact]
        public void RetornaTaxa_Get_UmPorCento()
        {
            // Arrange
            var expected = 0.01m;

            // Act
            var actual = _controller.Get();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
