using System;
using Xunit;
using SonOfCod.Models;

namespace SonOfCod.Tests
{
    public class ProductsTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var product = new Product();

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("ALBACORE TUNA", result);
        }
    }
}
