using System;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Controllers;
using Xunit;

namespace MovieMvcTest
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void Index_ActionExecutes_ReturnsAViewResult()
        {
            // Arrange
            var helloWorldController = new HelloWorldController();

            // Act
            var result = helloWorldController.Index();

            // Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
