using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieMvc.Controllers;
using Xunit;

namespace MovieMvcTest
{
    public class HomeControllerTest
    {
        ILogger<HomeController> _logger;

        [Fact]
        public void Index_ActionExecutes_ReturnsAViewResult()
        {
            // Arrange
            var homeController = new HomeController(_logger);

            // Act
            var result = homeController.Index();

            // Assert
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Privacy_ActionExecutes_ReturnsAViewResult()
        {
            // Arrange
            var homeController = new HomeController(_logger);

            // Act
            var result = homeController.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
