using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using Moq;
using MovieMvc.Controllers;
using MovieMvc.Models;
using Xunit;

namespace MovieMvcTest
{
    public class HomeControllerUnitTests
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

        [Fact]
        public void Error_ActionExecutes_RetrunsAViewResult()
        {
            // Arrange
            var homeController = new HomeController(_logger);
            homeController.ControllerContext = new ControllerContext();
            homeController.ControllerContext.HttpContext = new DefaultHttpContext();
            homeController.ControllerContext.HttpContext.TraceIdentifier = "1";

            // Act
            var result = homeController.Error();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<ErrorViewModel>(viewResult.Model);
            Assert.True(model.ShowRequestId);
        }
    }
}
