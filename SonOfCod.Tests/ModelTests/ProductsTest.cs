using System;
using Xunit;
using SonOfCod.Models;
using SonOfCod.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SonOfCod.Tests
{
    public class ProductsTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var product = new Product();
            product.Name = "Albacore Tuna";
            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Albacore Tuna", result);
        }

        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var product = new Product();
            product.Description = "Albacore roam tropical and temperate waters throughout the world.";
            //Act
            var result = product.Description;

            //Assert
            Assert.Equal("Albacore roam tropical and temperate waters throughout the world.", result);
        }

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ProductsController controller = new ProductsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ProductsController controller = new ProductsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Product>>(result);
        }
    }
}
